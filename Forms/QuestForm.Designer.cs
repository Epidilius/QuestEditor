namespace QuestEditor
{
    partial class QuestForm

    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_QuestName = new System.Windows.Forms.TextBox();
            this.button_CreateQuest = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.richTextBox_Description = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quest Name";
            // 
            // textBox_QuestName
            // 
            this.textBox_QuestName.Location = new System.Drawing.Point(12, 27);
            this.textBox_QuestName.Name = "textBox_QuestName";
            this.textBox_QuestName.Size = new System.Drawing.Size(348, 20);
            this.textBox_QuestName.TabIndex = 1;
            // 
            // button_CreateQuest
            // 
            this.button_CreateQuest.Location = new System.Drawing.Point(12, 401);
            this.button_CreateQuest.Name = "button_CreateQuest";
            this.button_CreateQuest.Size = new System.Drawing.Size(100, 100);
            this.button_CreateQuest.TabIndex = 2;
            this.button_CreateQuest.Text = "Create Quest";
            this.button_CreateQuest.UseVisualStyleBackColor = true;
            this.button_CreateQuest.Click += new System.EventHandler(this.button_CreateQuest_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(260, 401);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(100, 100);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // richTextBox_Description
            // 
            this.richTextBox_Description.Location = new System.Drawing.Point(12, 54);
            this.richTextBox_Description.Name = "richTextBox_Description";
            this.richTextBox_Description.Size = new System.Drawing.Size(348, 341);
            this.richTextBox_Description.TabIndex = 4;
            this.richTextBox_Description.Text = "";
            // 
            // Quest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 513);
            this.Controls.Add(this.richTextBox_Description);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_CreateQuest);
            this.Controls.Add(this.textBox_QuestName);
            this.Controls.Add(this.label1);
            this.Name = "QuestForm";
            this.Text = "QuestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_QuestName;
        private System.Windows.Forms.Button button_CreateQuest;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.RichTextBox richTextBox_Description;
    }
}