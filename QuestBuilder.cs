using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace QuestEditor
{
    public static class QuestBuilder
    {
        static string FILE_PATH = @"C:\ParallelZodiac\Quests\";
        static string FILE_TYPE = ".cs";
        
        public static void BuildAllQuests()
        {
            var questIDs = DatabaseManager.GetQuestList();

            for(int i = 0; i < questIDs.Rows.Count; i++)
            {
                var questID = Convert.ToInt32(questIDs.Rows[i]["ID"]);
                BuildSpecificQuest(questID);
            }
        }
        public static void BuildOutOfDateQuests()
        {
            var questIDs = DatabaseManager.GetQuestList();

            for (int i = 0; i < questIDs.Rows.Count; i++)
            {
                var questID = Convert.ToInt32(questIDs.Rows[i]["ID"]);

                var dbVersion = DatabaseManager.GetQuestFromID(questID).Rows[0]["Version"].ToString();
                var fileVersion = GetQuestVersionFromFile(questID);

                if (ShouldRebuild(dbVersion, fileVersion))
                    BuildSpecificQuest(questID);
            }
        }
        public static void BuildSpecificQuest(string questName)
        {
            //TODO: Do I want to do this? If I do, I have to find each quest that matches the name, the get their IDs, then build them
        }
        public static void BuildSpecificQuest(int questID)
        {
            var questTemplate = "";
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("QuestEditor.QuestFiles.QuestTemplate.txt"))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    questTemplate = reader.ReadToEnd();
                }
            }
            
            questTemplate = CreateQuestData(questID, questTemplate);

            var stepIDs = DatabaseManager.GetStepIDsForQuest(questID);
            for(int i = 0; i < stepIDs.Rows.Count; i++)
            {
                var stepID = Convert.ToInt32(stepIDs.Rows[i][0]);
                questTemplate = (CreateStepData(stepID, questTemplate));

                var detailIDs = DatabaseManager.GetDetailIDsForStep(stepID);
                for(int j = 0; j < detailIDs.Rows.Count; j++)
                {
                    var detailID = Convert.ToInt32(detailIDs.Rows[j][0]);
                    questTemplate = CreateDetailData(detailID, questTemplate);
                }
            }

            questTemplate = RemovePlaceholders(questTemplate);
            CreateQuestFile(questID, questTemplate);
        }

        static string CreatePath(int questID)
        {
            return FILE_PATH + questID + FILE_TYPE;
        }
        static void CreateQuestFile(int questID, string questTemplate)
        {
            if (String.IsNullOrWhiteSpace(questTemplate))
                return;

            var questPath = CreatePath(questID);
            Directory.CreateDirectory(FILE_PATH);
            File.WriteAllText(questPath, questTemplate);
        }
        static bool ShouldRebuild(string dbVersion, string fileVersion)
        {
            for (int j = 0; j < 3; j++)
            {
                var dbvers = Convert.ToInt32(dbVersion.Split('.').ElementAt(j));
                var filevers = Convert.ToInt32(fileVersion.Split('.').ElementAt(j));

                if (dbvers != filevers)
                    return true;
            }
            return false;
        }
        static string GetQuestVersionFromFile(int questID)
        {
            var result = new FileInfo(CreatePath(questID)).ReadAndFilter(s => s.Contains("Version")).ElementAt(0).ToString();
            result = Regex.Replace(result, "[^0-9.]", "");
            return result;
        }
        static IEnumerable<string> ReadAndFilter(this FileInfo info, Predicate<string> condition)
        {
            string line;
            using (var reader = new StreamReader(info.FullName))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (condition(line)) yield return line;
                }
            }
        }

        static string CreateQuestData(int questID, string questTemplate) //TODO: Pass by ref?
        {
            var questData = DatabaseManager.GetQuestFromID(questID);
            if (questData.Rows.Count < 1)
                return string.Empty;

            var questClass      = questData.Rows[0]["Name"].ToString().Replace(" ", String.Empty);
            var questName       = questData.Rows[0]["Name"].ToString();
            var questDesc       = questData.Rows[0]["Description"].ToString().Replace("\r\n", "\\r\\n");
            var questVersion    = questData.Rows[0]["Version"].ToString();

            questTemplate = questTemplate.Replace("[[QUESTCLASS]]", questClass);
            questTemplate = questTemplate.Replace("[[QUESTID]]", questID.ToString());
            questTemplate = questTemplate.Replace("[[QUESTNAME]]", questName);
            questTemplate = questTemplate.Replace("[[QUESTDESCRIPTION]]", questDesc);
            questTemplate = questTemplate.Replace("[[QUESTVERSION]]", questVersion);

            return questTemplate;
        }
        static string CreateStepData(int stepID, string questTemplate)
        {
            var stepData = DatabaseManager.GetStep(stepID);
            if (stepData.Rows.Count < 1)
                return String.Empty;

            var questID           = stepData.Rows[0]["QuestID"].ToString();
            var name              = stepData.Rows[0]["StepName"].ToString();
            var dialogue          = stepData.Rows[0]["Dialogue"].ToString().Replace("\n", "\\r\\n");
            var exDialogue        = stepData.Rows[0]["ExceptionDialogue"].ToString().Replace("\n", "\\r\\n");
            var useGeneric        = stepData.Rows[0]["UseGenericExceptionDialogue"].ToString();
            var useTyped          = stepData.Rows[0]["UseTypedExceptionDialogue"].ToString();
            var reward            = stepData.Rows[0]["Reward"].ToString();
            var rewardAmount      = stepData.Rows[0]["RewardAmount"].ToString();
            var attempts          = stepData.Rows[0]["AmountOfAttempts"].ToString();
            var attemptsCompleted = stepData.Rows[0]["AttemptsCompleted"].ToString();

            //Steps.Add(CreateStep(1, QuestID, "Reach the top of the castle", "kjfhdg...", "", false, false, Gold, 3000));
            var creationString = "Steps.Add(CreateStep(STEPID, QUESTID, \"NAME\", \"DIALOGUE\", \"EXCEPTION\", USEGENERIC, USETYPED, \"REWARD\", \"AMOUNT\", ATTEMPTS, COMPLETED));";

            creationString = creationString.Replace("STEPID", stepID.ToString());
            creationString = creationString.Replace("QUESTID", questID);
            creationString = creationString.Replace("NAME", name);
            creationString = creationString.Replace("DIALOGUE", dialogue);
            creationString = creationString.Replace("EXCEPTION", exDialogue);
            creationString = creationString.Replace("USEGENERIC", useGeneric);
            creationString = creationString.Replace("USETYPED", useTyped);
            creationString = creationString.Replace("REWARD", reward);
            creationString = creationString.Replace("AMOUNT", rewardAmount);
            creationString = creationString.Replace("ATTEMPTS", attempts);
            creationString = creationString.Replace("COMPLETED", attemptsCompleted);

            questTemplate = questTemplate.Replace("[[STEPCREATION]]", "\t\t\t" + creationString + "\r\n[[STEPCREATION]]");
            return questTemplate;
        }
        static string CreateDetailData(int detailID, string questTemplate)
        {
            var detailData = DatabaseManager.GetDetail(detailID);
            if (detailData.Rows.Count < 1)
                return string.Empty;

            var stepID        = detailData.Rows[0]["StepID"].ToString();    //TODO: Swap the .ToString()s with Convert.ToString. Same with CreateStepData
            var activeEntity  = detailData.Rows[0]["ActiveEntity"].ToString();
            var action        = detailData.Rows[0]["Action"].ToString();
            var amount        = detailData.Rows[0]["Amount"].ToString();
            var timerLength   = detailData.Rows[0]["Timer"].ToString();
            var passiveEntity = detailData.Rows[0]["PassiveEntity"].ToString();

            //The ID is the StepID from the Details table. NOT minus 1 because the step at 0 is from CreateFirstStep()
            //Steps[1].Details.Add(CreateDetail(1002, 1, "Shiro", 5, -1, -1, "Doug"));
            var creationString = "Steps[STEPID].Details.Add(CreateDetail(DETAILID, STEPID, \"ACTIVE\", ACTION, AMOUNT, TIMERLENGTH, \"PASSIVE\"));";

            creationString = creationString.Replace("STEPID", stepID);
            creationString = creationString.Replace("DETAILID", detailID.ToString());
            creationString = creationString.Replace("ACTIVE", activeEntity.Replace(" ", ""));   //TODO: This space removal?
            creationString = creationString.Replace("ACTION", action);
            creationString = creationString.Replace("AMOUNT", amount);
            creationString = creationString.Replace("TIMERLENGTH", timerLength);
            creationString = creationString.Replace("PASSIVE", passiveEntity.Replace(" ", ""));

            questTemplate = questTemplate.Replace("[[DETAILCREATION]]", "\t\t\t" + creationString + "\r\n[[DETAILCREATION]]");
            return questTemplate;
        }
        
        static string RemovePlaceholders(string questTemplate)
        {
            questTemplate = questTemplate.Replace("\r\n[[STEPCREATION]]", String.Empty);
            questTemplate = questTemplate.Replace("\r\n[[DETAILCREATION]]", String.Empty);

            return questTemplate;
        }
    }
}
