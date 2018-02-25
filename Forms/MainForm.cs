using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PopulateQuestTable();
        }
        
        //DB STUFF
        private void CreateQuest(string questName, string description)
        {
            DatabaseManager.CreateQuest(questName, description);
            PopulateQuestTable();
        }
        private void EditQuest(int questID, string newQuestName, string newDescription)
        {
            DatabaseManager.EditQuest(questID, newQuestName, newDescription);
            PopulateQuestTable();
        }
        private void CreateStep(int questID, string stepName, string dialogue, string exDialolgue, int useGeneric, int useTyped, Dictionary<string, string> reward, int amountOfAttempts)
        {
            DatabaseManager.CreateStep(questID, stepName, dialogue, exDialolgue, useGeneric, useTyped, reward, amountOfAttempts);
            PopulateStepsTable(questID);
        }
        private void EditStep(int questID, int stepID, string newStepName, string dialogue, string exDialolgue, int useGeneric, int useTyped, Dictionary<string, string> reward, int amountOfAttempts) 
        {
            DatabaseManager.EditStep(questID, stepID, newStepName, dialogue, exDialolgue, useGeneric, useTyped, reward, amountOfAttempts);
        }
        private void CreateDetail(int stepID, string activeEntity, int action, int amount, int timer, string passiveEntity)
        {
            DatabaseManager.CreateDetail(stepID, activeEntity, action, amount, timer, passiveEntity);
            PopulateDetailsTable(stepID);
        }
        private void EditDetail(int questID, int detailID, string activeEntity, int action, int amount, int timer, string passiveEntity)
        {
            DatabaseManager.EditDetail(questID, detailID, activeEntity, action, amount, timer, passiveEntity);
        }

        //GRID VIEWS
        void PopulateQuestTable()
        {
            var data = DatabaseManager.GetAllQuestData();
            dataGridView_Quests.DataSource = data;
            //this.questsTableAdapter.Fill(this.parallelZodiacDataSet.Quests);
        }
        void PopulateStepsTable(int questID)
        {
            var data = DatabaseManager.GetStepsForQuest(questID);
            dataGridView_Steps.DataSource = data;
            //this.stepsTableAdapter.Fill(this.parallelZodiacDataSetSteps.Steps);
        }
        void PopulateDetailsTable(int stepID)
        {
            var data = DatabaseManager.GetDetailsForStep(stepID);
            dataGridView_Details.DataSource = data;
            //this.detailsTableAdapter.Fill(this.parallelZodiacDataSetDetails.Details);
        }        
        
        //Item Selected
        private void dataGridView_Quests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateStepsTable(GetQuestID());
        }
        private void dataGridView_Steps_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PopulateDetailsTable(GetStepID());
        }
        private void dataGridView_Details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO: Should this do anything?
        }

        //Utility
        int GetQuestID()
        {
            var index = -1;
            var dgvIndex = dataGridView_Quests.CurrentCell.RowIndex;

            Int32.TryParse(dataGridView_Quests.Rows[dgvIndex].Cells[0].Value.ToString(), out index);

            return index;
        }
        int GetStepID()
        {
            var index = -1;
            var dgvIndex = dataGridView_Steps.CurrentCell.RowIndex;

            Int32.TryParse(dataGridView_Steps.Rows[dgvIndex].Cells[0].Value.ToString(), out index);

            return index;
        }
        int GetDetailID()
        {
            var index = -1;
            var dgvIndex = dataGridView_Details.CurrentCell.RowIndex;

            Int32.TryParse(dataGridView_Details.Rows[dgvIndex].Cells[0].Value.ToString(), out index);

            return index;
        }

        //ADD
        private void button_AddQuest_Click(object sender, EventArgs e)
        {
            QuestForm questForm = new QuestForm();            
            if(questForm.ShowDialog() == DialogResult.OK)
                CreateQuest(questForm.QuestName, questForm.QuestDescription);            
        }
        private void button_AddStep_Click(object sender, EventArgs e)
        {
            StepForm stepForm = new StepForm();
            if (stepForm.ShowDialog() == DialogResult.OK)
                CreateStep(GetQuestID(), stepForm.StepName, stepForm.Dialogue, stepForm.ExceptionDialogue, stepForm.GenericExDialogue, stepForm.TypedExDialogue, stepForm.GetReward(), stepForm.AmountOfAttempts);
        }
        private void button_AddDetails_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm();
            if(detailForm.ShowDialog() == DialogResult.OK)
                CreateDetail(GetStepID(), detailForm.ActiveEntity, detailForm.Action, detailForm.Amount, detailForm.Timer, detailForm.PassiveEntity);
        }

        //EDIT
        private void button_EditQuest_Click(object sender, EventArgs e)
        {
            var questName = "";
            var questDescription = "";
            var dataIndex = -1;

            if (dataGridView_Quests.SelectedRows.Count != 0 || dataGridView_Quests.SelectedCells.Count != 0)
            {
                dataIndex = dataGridView_Quests.CurrentCell.RowIndex;

                DataGridViewRow row = dataGridView_Quests.Rows[dataIndex];
                questName = row.Cells["QuestName"].Value.ToString();
                questDescription = row.Cells["QuestDescription"].Value.ToString();
            }

            if (questName == "" || dataIndex == -1)
                return;

            var questID = Int32.Parse(dataGridView_Quests.Rows[dataIndex].Cells["QuestID"].Value.ToString());

            QuestForm questForm = new QuestForm(questName, questDescription);
            if (questForm.ShowDialog() == DialogResult.OK)
                EditQuest(questID, questForm.QuestName, questForm.QuestDescription);
        }
        private void button_EditStep_Click(object sender, EventArgs e)
        {
            var stepName = "";
            var dataIndex = -1;

            if (dataGridView_Steps.SelectedRows.Count != 0 || dataGridView_Steps.SelectedCells.Count != 0)
            {
                dataIndex = dataGridView_Steps.CurrentCell.RowIndex;

                DataGridViewRow row = dataGridView_Steps.Rows[dataIndex];
                stepName = row.Cells["StepName"].Value.ToString();
            }

            if (stepName == "" || dataIndex == -1)
                return;

            var stepID = Int32.Parse(dataGridView_Steps.Rows[dataIndex].Cells["StepID"].Value.ToString());

            var results = DatabaseManager.GetStep(stepID).Rows[0];

            var dialogue     = Convert.ToString(results["Dialogue"]);
            var exDialogue   = Convert.ToString(results["ExceptionDialogue"]);
            var attempts     = Convert.ToString(results["AmountOfAttempts"]);
            var reward       = Convert.ToString(results["Reward"]).Split('|');
            var rewardAmount = Convert.ToString(results["RewardAmount"]).Split('|');

            var useGenerics  = Convert.ToBoolean(results["UseGenericExceptionDialogue"]);
            var useTyped     = Convert.ToBoolean(results["UseTypedExceptionDialogue"]);

            StepForm stepForm = new StepForm(stepName, dialogue, exDialogue, useGenerics, useTyped, reward, rewardAmount, attempts);
            if (stepForm.ShowDialog() == DialogResult.OK)
            {
                EditStep(GetQuestID(), stepID, stepForm.StepName, stepForm.Dialogue, stepForm.ExceptionDialogue, stepForm.GenericExDialogue, stepForm.TypedExDialogue, stepForm.GetReward(), stepForm.AmountOfAttempts);
            }

            PopulateStepsTable(GetQuestID());
        }
        private void button_EditDetails_Click(object sender, EventArgs e)
        {
            var dataIndex = -1;

            if (dataGridView_Details.SelectedRows.Count != 0 || dataGridView_Details.SelectedCells.Count != 0)
            {
                dataIndex = dataGridView_Details.CurrentCell.RowIndex;
            }

            if (dataIndex == -1)
                return;

            var detailID = Int32.Parse(dataGridView_Details.Rows[dataIndex].Cells["DetailID"].Value.ToString());

            var results = DatabaseManager.GetDetail(detailID).Rows[0];

            var activeEntity  = Convert.ToString(results["ActiveEntity"]);
            var passiveEntity = Convert.ToString(results["PassiveEntity"]);
            var amount        = Convert.ToString(results["Amount"]);
            var timer         = Convert.ToString(results["Timer"]);
            var action        = Convert.ToInt32(results["Action"]);

            DetailForm detailForm = new DetailForm(activeEntity, action, passiveEntity, amount, timer, String.Empty);
            if (detailForm.ShowDialog() == DialogResult.OK)
            {
                EditDetail(GetQuestID(), detailID, detailForm.ActiveEntity, detailForm.Action, detailForm.Amount, detailForm.Timer, detailForm.PassiveEntity);
            }
        }

        //DELETE
        private void button_DeleteQuest_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this quest?\r\nQuest ID: " + GetQuestID().ToString(), "Confirm Quest Deletion", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteQuest(GetQuestID());
            }
        }
        private void button_DeleteStep_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this step?\r\nStep ID: " + GetStepID().ToString(), "Confirm Step Deletion", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteStep(GetStepID());
            }
        }
        private void button_DeleteDetail_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this detail?\r\nDetail ID: " + GetDetailID().ToString(), "Confirm Detail Deletion", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DeleteDetail(GetDetailID());
            }
        }
        void DeleteQuest(int questID)
        {
            DatabaseManager.DeleteQuest(questID);
            PopulateQuestTable();
            PopulateStepsTable(GetStepID());
            PopulateDetailsTable(GetDetailID());
        }
        void DeleteStep(int stepID)
        {
            DatabaseManager.DeleteStep(stepID);
            PopulateStepsTable(GetQuestID());
            PopulateStepsTable(GetStepID());
        }
        void DeleteDetail(int detailID)
        {
            DatabaseManager.DeleteDetail(detailID);
            PopulateDetailsTable(GetStepID());
        }

        //QUEST BUILDING
        private void buildAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuestBuilder.BuildAllQuests();
        }
        private void buildSelectedQuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var questID = GetQuestID();
            if (questID != -1) QuestBuilder.BuildSpecificQuest(questID);
        }
        private void buildOutOfDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuestBuilder.BuildOutOfDateQuests();
        }
    }
}
