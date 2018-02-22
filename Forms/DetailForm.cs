using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO: When doing dialogue, look at this: https://gamedev.stackexchange.com/questions/40519/how-do-dialog-trees-work
namespace QuestEditor
{
    public partial class DetailForm : Form
    {
        public DetailForm()
        {
            InitializeComponent();
            
            Setup();
        }

        public DetailForm(string activeEntity, int action, string passiveEntity, string amount, string timer, string timeDonyBy)
        {
            InitializeComponent();
            Setup();

            textBox_ActiveEntity.Text = activeEntity;
            textBox_PassiveEntity.Text = passiveEntity;
            textBox_Amount.Text = amount;
            textBox_Timer.Text = timer;
            textBox_DateDoneBy.Text = timeDonyBy;

            comboBox_Action.SelectedIndex = action;

            button_CreateDetail.Text = "Edit Detail";
        }

        void Setup()
        {
            foreach (DataRow row in DatabaseManager.GetActions().Rows)
            {
                comboBox_Action.Items.Add(row["Action"].ToString());
            }
        }

        private void button_CreateDetail_Click(object sender, EventArgs e)
        {
            //TODO: Entity is a generic public GameObject. 
            this.DialogResult = DialogResult.Abort;
            if (ValidateData())
                this.DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Abort;  //TODO: Error message instead?
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        bool ValidateData()
        {
            if (String.IsNullOrWhiteSpace(textBox_ActiveEntity.Text))
                textBox_ActiveEntity.Text = "Speak to Quest Creator";
                //return false;
            if (String.IsNullOrWhiteSpace(textBox_PassiveEntity.Text))
                textBox_PassiveEntity.Text = "Speak to Quest Creator";
            //return false;

            try
            {
                GetTimerDuration();
            }
            catch (Exception ex)
            {
                var temp = ex;
                //TODO: Error message?
                textBox_Timer.Text = "-1";
            }
            try
            {
                GetTimerDuration();
            }
            catch (Exception ex)
            {
                var temp = ex;
                //TODO: Error message?
                textBox_DateDoneBy.Text = "-1";
            }

            try
            {
                GetAmount();
            }
            catch (Exception ex)
            {
                var temp = ex;
                //TODO: Error message?
                textBox_Amount.Text = "-1";
            }

            try
            {
                //TODO: First, we make a calendar, then we make a parse function, and THEN, then we get the dates
                //We'll also have to update the save and edit functions 
            }
            catch(Exception ex)
            {

            }

            return true;
        }
        
        public string   ActiveEntity    { get { return textBox_ActiveEntity.Text; } }
        public string   PassiveEntity   { get { return textBox_PassiveEntity.Text; } }
        public string   DateLimit       { get { return textBox_DateDoneBy.Text; } }

        public int      Action          { get { return comboBox_Action.SelectedIndex; } }
        public int      Amount          { get { return GetAmount(); } }
        public int      Timer           { get { return GetTimerDuration(); } }
        int GetAmount()
        {
            return Int32.Parse(textBox_Amount.Text);
        }
        int GetTimerDuration()
        {
            return Int32.Parse(textBox_Timer.Text);
        }
        string GetDateLimit()
        {
            return textBox_DateDoneBy.Text;
        }
    }
}
