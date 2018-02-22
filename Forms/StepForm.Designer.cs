namespace QuestEditor
{
    partial class StepForm
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_CreateStep = new System.Windows.Forms.Button();
            this.textBox_StepName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_TypedExDialogue = new System.Windows.Forms.CheckBox();
            this.checkBox_GenericExDialogue = new System.Windows.Forms.CheckBox();
            this.richTextBox_ExceptionDialogue = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBox_Dialogue = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_RewardAmount = new System.Windows.Forms.TextBox();
            this.textBox_Reward = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(521, 380);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(100, 100);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_CreateStep
            // 
            this.button_CreateStep.Location = new System.Drawing.Point(521, 274);
            this.button_CreateStep.Name = "button_CreateStep";
            this.button_CreateStep.Size = new System.Drawing.Size(100, 100);
            this.button_CreateStep.TabIndex = 6;
            this.button_CreateStep.Text = "Create Step";
            this.button_CreateStep.UseVisualStyleBackColor = true;
            this.button_CreateStep.Click += new System.EventHandler(this.button_CreateStep_Click);
            // 
            // textBox_StepName
            // 
            this.textBox_StepName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_StepName.Location = new System.Drawing.Point(12, 27);
            this.textBox_StepName.Name = "textBox_StepName";
            this.textBox_StepName.Size = new System.Drawing.Size(423, 20);
            this.textBox_StepName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Step Name";
            // 
            // checkBox_TypedExDialogue
            // 
            this.checkBox_TypedExDialogue.AutoSize = true;
            this.checkBox_TypedExDialogue.Location = new System.Drawing.Point(441, 35);
            this.checkBox_TypedExDialogue.Name = "checkBox_TypedExDialogue";
            this.checkBox_TypedExDialogue.Size = new System.Drawing.Size(173, 17);
            this.checkBox_TypedExDialogue.TabIndex = 31;
            this.checkBox_TypedExDialogue.Text = "Use Typed Exception Dialogue";
            this.checkBox_TypedExDialogue.UseVisualStyleBackColor = true;
            // 
            // checkBox_GenericExDialogue
            // 
            this.checkBox_GenericExDialogue.AutoSize = true;
            this.checkBox_GenericExDialogue.Location = new System.Drawing.Point(441, 12);
            this.checkBox_GenericExDialogue.Name = "checkBox_GenericExDialogue";
            this.checkBox_GenericExDialogue.Size = new System.Drawing.Size(180, 17);
            this.checkBox_GenericExDialogue.TabIndex = 30;
            this.checkBox_GenericExDialogue.Text = "Use Generic Exception Dialogue";
            this.checkBox_GenericExDialogue.UseVisualStyleBackColor = true;
            // 
            // richTextBox_ExceptionDialogue
            // 
            this.richTextBox_ExceptionDialogue.Location = new System.Drawing.Point(12, 292);
            this.richTextBox_ExceptionDialogue.Name = "richTextBox_ExceptionDialogue";
            this.richTextBox_ExceptionDialogue.Size = new System.Drawing.Size(500, 188);
            this.richTextBox_ExceptionDialogue.TabIndex = 29;
            this.richTextBox_ExceptionDialogue.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Exception Dialogue";
            // 
            // richTextBox_Dialogue
            // 
            this.richTextBox_Dialogue.Location = new System.Drawing.Point(12, 66);
            this.richTextBox_Dialogue.Name = "richTextBox_Dialogue";
            this.richTextBox_Dialogue.Size = new System.Drawing.Size(500, 207);
            this.richTextBox_Dialogue.TabIndex = 27;
            this.richTextBox_Dialogue.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Dialogue";
            // 
            // textBox_RewardAmount
            // 
            this.textBox_RewardAmount.Location = new System.Drawing.Point(521, 248);
            this.textBox_RewardAmount.Name = "textBox_RewardAmount";
            this.textBox_RewardAmount.Size = new System.Drawing.Size(100, 20);
            this.textBox_RewardAmount.TabIndex = 32;
            // 
            // textBox_Reward
            // 
            this.textBox_Reward.Location = new System.Drawing.Point(521, 209);
            this.textBox_Reward.Name = "textBox_Reward";
            this.textBox_Reward.Size = new System.Drawing.Size(100, 20);
            this.textBox_Reward.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Reward Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Reward";
            // 
            // Step
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 492);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Reward);
            this.Controls.Add(this.textBox_RewardAmount);
            this.Controls.Add(this.checkBox_TypedExDialogue);
            this.Controls.Add(this.checkBox_GenericExDialogue);
            this.Controls.Add(this.richTextBox_ExceptionDialogue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.richTextBox_Dialogue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_CreateStep);
            this.Controls.Add(this.textBox_StepName);
            this.Controls.Add(this.label1);
            this.Name = "StepForm";
            this.Text = "StepForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_CreateStep;
        private System.Windows.Forms.TextBox textBox_StepName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_TypedExDialogue;
        private System.Windows.Forms.CheckBox checkBox_GenericExDialogue;
        private System.Windows.Forms.RichTextBox richTextBox_ExceptionDialogue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox_Dialogue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_RewardAmount;
        private System.Windows.Forms.TextBox textBox_Reward;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}