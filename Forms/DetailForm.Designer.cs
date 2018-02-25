namespace QuestEditor
{
    partial class DetailForm
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
            this.button_CreateDetail = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.comboBox_Action = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ActiveEntity = new System.Windows.Forms.TextBox();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_PassiveEntity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Timer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_DateDoneBy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_CreateDetail
            // 
            this.button_CreateDetail.Location = new System.Drawing.Point(12, 55);
            this.button_CreateDetail.Name = "button_CreateDetail";
            this.button_CreateDetail.Size = new System.Drawing.Size(95, 118);
            this.button_CreateDetail.TabIndex = 3;
            this.button_CreateDetail.Text = "Create Detail";
            this.button_CreateDetail.UseVisualStyleBackColor = true;
            this.button_CreateDetail.Click += new System.EventHandler(this.button_CreateDetail_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.Location = new System.Drawing.Point(506, 57);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(100, 116);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // comboBox_Action
            // 
            this.comboBox_Action.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Action.FormattingEnabled = true;
            this.comboBox_Action.Location = new System.Drawing.Point(212, 24);
            this.comboBox_Action.Name = "comboBox_Action";
            this.comboBox_Action.Size = new System.Drawing.Size(194, 21);
            this.comboBox_Action.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Active Entity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Action";
            // 
            // textBox_ActiveEntity
            // 
            this.textBox_ActiveEntity.Location = new System.Drawing.Point(12, 25);
            this.textBox_ActiveEntity.Name = "textBox_ActiveEntity";
            this.textBox_ActiveEntity.Size = new System.Drawing.Size(194, 20);
            this.textBox_ActiveEntity.TabIndex = 9;
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Amount.Location = new System.Drawing.Point(212, 75);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(194, 20);
            this.textBox_Amount.TabIndex = 27;
            this.textBox_Amount.Text = "-1 for unique passive entity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Amount";
            // 
            // textBox_PassiveEntity
            // 
            this.textBox_PassiveEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_PassiveEntity.Location = new System.Drawing.Point(412, 25);
            this.textBox_PassiveEntity.Name = "textBox_PassiveEntity";
            this.textBox_PassiveEntity.Size = new System.Drawing.Size(194, 20);
            this.textBox_PassiveEntity.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Passive Entity";
            // 
            // textBox_Timer
            // 
            this.textBox_Timer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Timer.Location = new System.Drawing.Point(212, 114);
            this.textBox_Timer.Name = "textBox_Timer";
            this.textBox_Timer.Size = new System.Drawing.Size(194, 20);
            this.textBox_Timer.TabIndex = 36;
            this.textBox_Timer.Text = "-1 for no timer, in minutes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Timer";
            // 
            // textBox_DateDoneBy
            // 
            this.textBox_DateDoneBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_DateDoneBy.Enabled = false;
            this.textBox_DateDoneBy.Location = new System.Drawing.Point(212, 157);
            this.textBox_DateDoneBy.Name = "textBox_DateDoneBy";
            this.textBox_DateDoneBy.Size = new System.Drawing.Size(194, 20);
            this.textBox_DateDoneBy.TabIndex = 38;
            this.textBox_DateDoneBy.Text = "YY/MM/DD/HH/MM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Time Done By";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 185);
            this.Controls.Add(this.textBox_DateDoneBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Timer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_PassiveEntity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ActiveEntity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Action);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_CreateDetail);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_CreateDetail;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ComboBox comboBox_Action;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ActiveEntity;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_PassiveEntity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Timer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_DateDoneBy;
        private System.Windows.Forms.Label label4;
    }
}