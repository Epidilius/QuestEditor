using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuestEditor
{
    public static class DatabaseManager
    {
        //TODO: Refactor this class
        static string ConnectionString = ConfigurationManager.ConnectionStrings["QuestEditor.Properties.Settings.ParallelZodiacConnectionString"].ConnectionString;
        private static readonly object _syncObject = new object();

        //Utility Functions
        static SqlCommand CreateCommand(string query)
        {
            SqlConnection con = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = query;

            return command;
        }
        static SqlCommand CreateCommandWithArgs(string query, Dictionary<string, object> values)
        {
            SqlConnection con = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;

            var firstHalf = "";
            var secondHalf = "";

            int i = 0;
            var firstLoop = true;

            foreach (KeyValuePair<string, object> value in values)
            {
                if (firstLoop)
                {
                    firstHalf += "(";
                    secondHalf += "(";
                    firstLoop = false;
                }
                else
                {
                    firstHalf += ", ";
                    secondHalf += ", ";
                }

                firstHalf += value.Key;
                secondHalf += "@val" + i.ToString();
                i++;
            }

            i = 0;
            firstHalf += ")";
            secondHalf += ")";

            query += firstHalf + " VALUES " + secondHalf;

            command.CommandText = query;

            foreach (KeyValuePair<string, object> value in values)
            {
                try
                {
                    if (!String.IsNullOrWhiteSpace(value.Value.ToString()))
                        command.Parameters.AddWithValue("@val" + i.ToString(), value.Value);
                    else
                        command.Parameters.AddWithValue("@val" + i.ToString(), "");
                }
                catch (Exception ex)
                {
                    command.Parameters.AddWithValue("@val" + i.ToString(), "");
                }
                i++;
            }

            return command;
        }
        static SqlDataAdapter CreateDataAdapter(SqlCommand command)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            return adapter;
        }
        static DataTable CreateDataTable(SqlDataAdapter dataAdapter)
        {
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            return table;
        }
        public static DataTable RunQuery(string query)   //TODO: Rename this
        {
            lock (_syncObject)
            {
                SqlCommand command = CreateCommand(query);
                SqlDataAdapter adapter = CreateDataAdapter(command);
                DataTable table = CreateDataTable(adapter);

                return table;
            }
        }
        public static DataTable RunQueryWithArgs(string query, Dictionary<string, object> values)
        {
            lock (_syncObject)
            {
                SqlCommand command = CreateCommandWithArgs(query, values);
                SqlDataAdapter adapter = CreateDataAdapter(command);
                DataTable table = CreateDataTable(adapter);

                return table;
            }
        }

        //Get Functions
        public static DataTable GetQuestFromID(int questID)
        {
            var query = "SELECT * FROM Quests WHERE ID = '" + questID + "'";
            var dataTable = RunQuery(query);
            return dataTable;
        }
        public static DataTable GetQuestFromName(string questName)
        {
            var query = "SELECT * FROM Quests WHERE Name = '" + questName + "'";
            var dataTable = RunQuery(query);
            return dataTable;
        }
        public static DataTable GetQuestList()
        {
            return RunQuery("SELECT ID FROM Quests");
        }
        public static DataTable GetStepsForQuest(int questID)
        {
            return RunQuery("SELECT * FROM Steps WHERE QuestID LIKE '" + questID + "'");
        }
        public static DataTable GetStepIDsForQuest(int questID)
        {
            return RunQuery("SELECT ID FROM Steps WHERE QuestID LIKE '" + questID + "'");
        }
        public static DataTable GetDetailsForStep(/*int questID, */int stepID)
        {
            return RunQuery("SELECT * FROM Details WHERE StepID LIKE '" + stepID + "'");
        }
        public static DataTable GetDetailIDsForStep(/*int questID, */int stepID)
        {
            return RunQuery("SELECT ID FROM Details WHERE StepID LIKE '" + stepID + "'");
        }
        public static DataTable GetStep(int stepID)
        {
            return RunQuery("SELECT * FROM Steps WHERE ID LIKE '" + stepID + "'");
        }
        public static DataTable GetDetail(int detailID)
        {
            return RunQuery("SELECT * FROM Details WHERE ID LIKE '" + detailID + "'");
        }
        public static DataTable GetActions()
        {
            return RunQuery("SELECT * FROM Actions");
        }

        //Modify Functions
        public static void AddOneToInventory(string name, string set, bool foil)
        {
            name = name.Replace(@"'", @"''");
            set = set.Replace(@"'", @"''");
            var query = "UPDATE MtG ";
            if (foil)
            {
                query += "SET foilInventory = foilInventory + 1 ";
            }
            else
            {
                query += "SET Inventory = Inventory + 1 ";
            }
            query += "WHERE NAME = \'" + name + "\' AND EXPANSION = \'" + set + "\'";

            RunQuery(query);
        }
        public static void RemoveOneToInventory(string name, string set, bool foil)
        {
            name = name.Replace(@"'", @"''");
            set = set.Replace(@"'", @"''");
            var query = "UPDATE MtG ";
            if (foil)
            {
                query += "SET foilInventory = foilInventory - 1 ";
            }
            else
            {
                query += "SET Inventory = Inventory - 1 ";
            }
            query += "WHERE NAME = \'" + name + "\' AND EXPANSION = \'" + set + "\'";

            RunQuery(query);
        }
        public static void UpdateInventory(string name, string set, int newAmount, int newFoilAmount)
        {
            name = name.Replace(@"'", @"''");
            set = set.Replace(@"'", @"''");
            var query = "UPDATE MtG SET foilInventory = " + newFoilAmount + ", inventory = " + newAmount;

            query += " WHERE NAME = \'" + name + "\' AND EXPANSION = \'" + set + "\'";

            RunQuery(query);
        }
        public static void UpdateSetID(string set, int id)
        {
            var query = "UPDATE Sets SET SetID = \'" + id.ToString() + "\' WHERE name = \'" + set + "\'";
            RunQuery(query);
        }


        //Check/Toggle Functions
        public static bool CheckIfCardExists(string multiverseID)
        {
            var dataTable = RunQuery("SELECT * FROM MtG WHERE MULTIVERSEID = \'" + multiverseID + "\'");

            if (dataTable.Rows.Count == 0) return false;
            return true;
        }
        public static bool CheckIfSetExists(string set)
        {
            var dataTable = RunQuery("SELECT * FROM Sets WHERE Name = \'" + set + "\'");

            if (dataTable.Rows.Count == 0) return false;
            return true;
        }
        public static bool CheckIfSetExistsByAbbreviation(string setAbbr)
        {
            var dataTable = RunQuery("SELECT * FROM Sets WHERE Abbreviation = \'" + setAbbr + "\'");

            if (dataTable.Rows.Count == 0) return false;
            return true;
        }
        public static bool IsSetLocked(string set)
        {
            var dataTable = RunQuery("SELECT Locked FROM Sets WHERE Name = \'" + set + "\'");

            bool data = (bool)dataTable.Rows[0].ItemArray[0];

            return data;
        }
        public static void LockSet(string set)
        {
            var query = "UPDATE Sets SET Locked = 1 WHERE Name = \'" + set + "\'";
            RunQuery(query);
        }
        public static void UnlockSet(string set)
        {
            var query = "UPDATE Sets SET Locked = 0 WHERE Name = \'" + set + "\'";
            RunQuery(query);
        }
        public static void UnlockAllSets()
        {
            var query = "UPDATE Sets SET Locked = 0";
            RunQuery(query);
        }

        //Create Functions
        public static void CreateQuest(string questName, string description)
        {
            var connString = ConfigurationManager.ConnectionStrings["QuestEditor.Properties.Settings.ParallelZodiacConnectionString"].ConnectionString;
            var cmdString = "INSERT INTO Quests (Name, Description, Version) VALUES (@val1, @val2, @val3)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = cmdString;
                    comm.Parameters.AddWithValue("@val1", questName);
                    comm.Parameters.AddWithValue("@val2", description);
                    comm.Parameters.AddWithValue("@val3", "1.0.0");
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        var temp = e;
                    }
                }
            }
        }
        public static void CreateStep(int questID, string stepName, string dialogue, string exDialolgue, int useGeneric, int useTyped, string reward, int rewardAmount)
        {
            var connString = ConfigurationManager.ConnectionStrings["QuestEditor.Properties.Settings.ParallelZodiacConnectionString"].ConnectionString;
            var cmdString = "INSERT INTO Steps (QuestID, StepName, Dialogue, ExceptionDialogue, UseGenericExceptionDialogue, UseTypedExceptionDialogue, Reward, RewardAmount) VALUES (@val1, @val2, @val3, @val4, @val5, @val6, @val7, @val8)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = cmdString;
                    comm.Parameters.AddWithValue("@val1", questID);
                    comm.Parameters.AddWithValue("@val2", stepName);
                    comm.Parameters.AddWithValue("@val3", dialogue);
                    comm.Parameters.AddWithValue("@val4", exDialolgue);
                    comm.Parameters.AddWithValue("@val5", useGeneric);
                    comm.Parameters.AddWithValue("@val6", useTyped);
                    comm.Parameters.AddWithValue("@val7", reward);
                    comm.Parameters.AddWithValue("@val8", rewardAmount);

                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        var temp = e;
                    }
                }
            }
        }
        public static void CreateDetail(int stepID, string activeEntity, int action, int amount, int timer, string passiveEntity)
        {
            var connString = ConfigurationManager.ConnectionStrings["QuestEditor.Properties.Settings.ParallelZodiacConnectionString"].ConnectionString;
            var cmdString = "INSERT INTO Details (StepID, ActiveEntity, Action, Amount, Timer, PassiveEntity) VALUES (@val1, @val2, @val3, @val4, @val5, @val6)";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = cmdString;
                    comm.Parameters.AddWithValue("@val1", stepID);
                    comm.Parameters.AddWithValue("@val2", activeEntity);
                    comm.Parameters.AddWithValue("@val3", action);
                    comm.Parameters.AddWithValue("@val4", amount);
                    comm.Parameters.AddWithValue("@val5", timer);
                    comm.Parameters.AddWithValue("@val6", passiveEntity);
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        var temp = e;
                    }
                }
            }
        }
        public static void EditQuest(int questID, string questName, string description)
        {
            UpdateVersion(questID, "quest");

            var setQuery = "UPDATE Quests SET Name = '" + questName + "', Description = '" + description + "' WHERE ID = '" + questID + "'";

            RunQuery(setQuery);
        }
        public static void EditStep(int questID, int stepID, string stepName, string dialogue, string exDialolgue, int useGeneric, int useTyped, string reward, int rewardAmount)
        {
            UpdateVersion(questID, "step");

            var setQuery = "UPDATE Steps SET StepName = '" + stepName + "', " +
                "Dialogue = '" + dialogue + "', " +
                "ExceptionDialogue = '" + exDialolgue + "', " +
                "UseGenericExceptionDialogue = '" + useGeneric + "', " +
                "UseTypedExceptionDialogue = '" + useTyped + "', " +
                "Reward = '" + reward + "', " +
                "RewardAmount = '" + rewardAmount + "' " +
                "WHERE ID = '" + stepID + "'";

            RunQuery(setQuery);
        }
        public static void EditDetail(int questID, int detailID, string activeEntity, int action, int amount, int timer, string passiveEntity)
        {
            UpdateVersion(questID, "detail");

            var setQuery = "UPDATE Details SET ActiveEntity = '" + activeEntity + "', " +
                "Action = '" + action + "', " +
                "Amount = '" + amount + "', " +
                "Timer = '" + timer + "', " +
                "DateLimit = '" + "" + "', " +
                "PassiveEntity = '" + passiveEntity + "' " +
                "WHERE ID = '" + detailID + "'";

            RunQuery(setQuery);
        }
        static void UpdateVersion(int questID, string updatePlacement)
        {
            var versionQuery = "SELECT Version FROM Quests WHERE ID = '" + questID + "'";
            var currentVersion = RunQuery(versionQuery).Rows[0][0].ToString();

            var splitVersion = currentVersion.Split('.');
            var newVersion = "";

            if (updatePlacement == "quest")
                newVersion = (Convert.ToInt32(splitVersion[0]) + 1) + "." + splitVersion[1] + "." + splitVersion[2];
            if (updatePlacement == "step")
                newVersion = splitVersion[0] + "." + (Convert.ToInt32(splitVersion[1]) + 1) + "." + splitVersion[2];
            if (updatePlacement == "detail")
                newVersion = splitVersion[0] + "." + splitVersion[1] + "." + (Convert.ToInt32(splitVersion[2]) + 1);

            versionQuery = "UPDATE Quests SET Version = '" + newVersion + "' WHERE ID = '" + questID + "'";
            RunQuery(versionQuery);
        }

        //Delete Fucntions
        public static void DeleteQuest(int questID)
        {
            var stepIDs = RunQuery("SELECT ID FROM Steps WHERE QuestID LIKE '" + questID + "'").Rows;
            foreach (DataRow stepID in stepIDs)
            {
                DeleteStep(Convert.ToInt32(stepID[0]));
            }

            var query = "DELETE FROM Quests WHERE ID = '" + questID + "'";
            RunQuery(query);
        }
        public static void DeleteStep(int stepID)
        {
            var detailIDs = RunQuery("SELECT ID FROM Details WHERE StepID LIKE '" + stepID + "'").Rows;
            foreach (DataRow detailID in detailIDs)
            {
                DeleteDetail(Convert.ToInt32(detailID[0]));
            }

            var query = "DELETE FROM Steps WHERE ID = '" + stepID + "'";
            RunQuery(query);
        }
        public static void DeleteDetail(int detailID)
        {
            var query = "DELETE FROM Details WHERE ID = '" + detailID + "'";
            RunQuery(query);
        }
    }

    //TODO: This?
    public struct QuestData
    {

    }
    public struct StepData
    {

    }
    public struct DetailData
    {

    }

    /*
    //ITEMS - OBTAIN 
    Fetch Item
    Steal Item
    Gather Item
    Obtain Item (another way)

    //ITEMS - INTERACT
    Use Item
    Destroy Item
    Examine Item
    Destroy Item

    //PUZZLE/EVENTS
    Solve Puzzle
    Fail to Solve Puzzle
    Destroy Puzzle
    Complete Dungeon
    Complete Job
    Fail Job
    Win Battle
    Lose Battle

    //ENEMIES
    Kill Enemy
    Kill Amount of Enemy
    Kill Type of Enemy
    Fail to Kill Enemy
    Recruit Enemy
    Befriend Enemy

    //NPC/FACTIONS
    Talk to NPC
    Escort NPC
    Kill NPC
    Fail to Kill NPC
    Befriend NPC (Raise Affinity to Certain Amount)
    Make Choice in Conversation with NPC (Favourable/Unfavourable)
    Threaten NPC
    Recruit Follower
    Dismiss Follower
    Be in Relationship With (Character)

    Examine Background (Object)
    Destroy Background (Object)
    Examine Text (Background Object)
    Create Text (Background Object)
    */
}