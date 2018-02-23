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
    public partial class StepForm : Form
    {
        //TODO: Change the reward stuff to a grid view. One column for item, one for amount 
        public StepForm()
        {
            InitializeComponent();
        }
        
        public StepForm(string stepName, string dialogue, string exDialogue, bool useGenerics, bool useTyped, string[] reward, string[] rewardAmount)
        {
            InitializeComponent();

            textBox_StepName.Text = stepName;
            richTextBox_Dialogue.Text = dialogue;
            richTextBox_ExceptionDialogue.Text = exDialogue;
            checkBox_GenericExDialogue.Checked = useGenerics;
            checkBox_TypedExDialogue.Checked = useTyped;

            for(int i = 0; i < reward.Length; i++)
            {
                dataGridView_RewardData.Rows.Add(reward[i], rewardAmount[i]);
            }

            button_CreateStep.Text = "Edit Step";
        }        

        private void button_CreateStep_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            if (!String.IsNullOrWhiteSpace(textBox_StepName.Text))
                this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public string StepName { get { return textBox_StepName.Text; } }

        public string Dialogue { get { return richTextBox_Dialogue.Text; } }
        public string ExceptionDialogue { get { return richTextBox_ExceptionDialogue.Text; } }
        public int GenericExDialogue { get { return (checkBox_GenericExDialogue.Checked ? 1 : 0); } }
        public int TypedExDialogue { get { return (checkBox_TypedExDialogue.Checked ? 1 : 0); } }
        public int AmountOfAttempts {  get { return (String.IsNullOrWhiteSpace(textBox_AmountOfAttempts.Text) ? -1 : Convert.ToInt32(textBox_AmountOfAttempts.Text)); } }

        public Dictionary<string, string> GetReward()
        {
            var rewardData = new Dictionary<string, string>();

            for(int i = 0; i < dataGridView_RewardData.Rows.Count; i++)
            {
                var row = dataGridView_RewardData.Rows[i];
                var reward = row.Cells["Reward"].Value.ToString();
                var amount = row.Cells["Amount"].Value.ToString();
                rewardData.Add(reward, amount);
            }

            return rewardData;
        } 
    }
}
