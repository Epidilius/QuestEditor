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
    public partial class QuestForm : Form
    {
        public QuestForm()
        {
            InitializeComponent();
        }

        public QuestForm(string questName, string questDescription)
        {
            InitializeComponent();
            textBox_QuestName.Text = questName;
            richTextBox_Description.Text = questDescription;
            button_CreateQuest.Text = "Edit Quest";
        }

        private void button_CreateQuest_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            if(!String.IsNullOrWhiteSpace(textBox_QuestName.Text))
                this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public string QuestName { get { return textBox_QuestName.Text; } }
        public string QuestDescription{ get { return richTextBox_Description.Text; } }
    }
}
