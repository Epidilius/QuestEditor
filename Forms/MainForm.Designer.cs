namespace QuestEditor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button_AddQuest = new System.Windows.Forms.Button();
            this.button_EditQuest = new System.Windows.Forms.Button();
            this.button_AddStep = new System.Windows.Forms.Button();
            this.button_EditStep = new System.Windows.Forms.Button();
            this.button_AddDetails = new System.Windows.Forms.Button();
            this.button_EditDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_Details = new System.Windows.Forms.DataGridView();
            this.DetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassiveEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parallelZodiacDataSetDetails = new QuestEditor.DataSets.ParallelZodiacDataSetDialogue();
            this.dataGridView_Steps = new System.Windows.Forms.DataGridView();
            this.StepID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestID_StepTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stepsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parallelZodiacDataSetSteps = new QuestEditor.DataSets.ParallelZodiacDataSetSteps();
            this.dataGridView_Quests = new System.Windows.Forms.DataGridView();
            this.QuestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parallelZodiacDataSet = new QuestEditor.DataSets.ParallelZodiacDataSet();
            this.questsTableAdapter = new QuestEditor.DataSets.ParallelZodiacDataSetTableAdapters.QuestsTableAdapter();
            this.stepsTableAdapter = new QuestEditor.DataSets.ParallelZodiacDataSetStepsTableAdapters.StepsTableAdapter();
            this.detailsTableAdapter = new QuestEditor.DataSets.ParallelZodiacDataSetDialogueTableAdapters.DetailsTableAdapter();
            this.button_DeleteQuest = new System.Windows.Forms.Button();
            this.button_DeleteStep = new System.Windows.Forms.Button();
            this.button_DeleteDetail = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buildAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildSelectedQuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildOutOfDateQuestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelZodiacDataSetDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Steps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelZodiacDataSetSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Quests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelZodiacDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_AddQuest
            // 
            this.button_AddQuest.Location = new System.Drawing.Point(12, 65);
            this.button_AddQuest.Name = "button_AddQuest";
            this.button_AddQuest.Size = new System.Drawing.Size(100, 100);
            this.button_AddQuest.TabIndex = 3;
            this.button_AddQuest.Text = "Add Quest";
            this.button_AddQuest.UseVisualStyleBackColor = true;
            this.button_AddQuest.Click += new System.EventHandler(this.button_AddQuest_Click);
            // 
            // button_EditQuest
            // 
            this.button_EditQuest.Location = new System.Drawing.Point(162, 65);
            this.button_EditQuest.Name = "button_EditQuest";
            this.button_EditQuest.Size = new System.Drawing.Size(100, 100);
            this.button_EditQuest.TabIndex = 4;
            this.button_EditQuest.Text = "Edit Quest";
            this.button_EditQuest.UseVisualStyleBackColor = true;
            this.button_EditQuest.Click += new System.EventHandler(this.button_EditQuest_Click);
            // 
            // button_AddStep
            // 
            this.button_AddStep.Location = new System.Drawing.Point(428, 65);
            this.button_AddStep.Name = "button_AddStep";
            this.button_AddStep.Size = new System.Drawing.Size(100, 100);
            this.button_AddStep.TabIndex = 5;
            this.button_AddStep.Text = "Add Step";
            this.button_AddStep.UseVisualStyleBackColor = true;
            this.button_AddStep.Click += new System.EventHandler(this.button_AddStep_Click);
            // 
            // button_EditStep
            // 
            this.button_EditStep.Location = new System.Drawing.Point(585, 65);
            this.button_EditStep.Name = "button_EditStep";
            this.button_EditStep.Size = new System.Drawing.Size(100, 100);
            this.button_EditStep.TabIndex = 6;
            this.button_EditStep.Text = "Edit Step";
            this.button_EditStep.UseVisualStyleBackColor = true;
            this.button_EditStep.Click += new System.EventHandler(this.button_EditStep_Click);
            // 
            // button_AddDetails
            // 
            this.button_AddDetails.Location = new System.Drawing.Point(841, 65);
            this.button_AddDetails.Name = "button_AddDetails";
            this.button_AddDetails.Size = new System.Drawing.Size(100, 100);
            this.button_AddDetails.TabIndex = 7;
            this.button_AddDetails.Text = "Add Detail";
            this.button_AddDetails.UseVisualStyleBackColor = true;
            this.button_AddDetails.Click += new System.EventHandler(this.button_AddDetails_Click);
            // 
            // button_EditDetails
            // 
            this.button_EditDetails.Location = new System.Drawing.Point(1004, 65);
            this.button_EditDetails.Name = "button_EditDetails";
            this.button_EditDetails.Size = new System.Drawing.Size(100, 100);
            this.button_EditDetails.TabIndex = 8;
            this.button_EditDetails.Text = "Edit Detail";
            this.button_EditDetails.UseVisualStyleBackColor = true;
            this.button_EditDetails.Click += new System.EventHandler(this.button_EditDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Steps";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1046, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_Details, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_Steps, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_Quests, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 171);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 513F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1240, 513);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // dataGridView_Details
            // 
            this.dataGridView_Details.AutoGenerateColumns = false;
            this.dataGridView_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetailID,
            this.ActiveEntity,
            this.Action,
            this.Amount,
            this.Timer,
            this.PassiveEntity});
            this.dataGridView_Details.DataSource = this.detailsBindingSource;
            this.dataGridView_Details.Location = new System.Drawing.Point(829, 3);
            this.dataGridView_Details.MultiSelect = false;
            this.dataGridView_Details.Name = "dataGridView_Details";
            this.dataGridView_Details.ReadOnly = true;
            this.dataGridView_Details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Details.Size = new System.Drawing.Size(407, 495);
            this.dataGridView_Details.TabIndex = 15;
            this.dataGridView_Details.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Details_CellContentClick);
            // 
            // DetailID
            // 
            this.DetailID.DataPropertyName = "ID";
            this.DetailID.HeaderText = "ID";
            this.DetailID.Name = "DetailID";
            this.DetailID.ReadOnly = true;
            // 
            // ActiveEntity
            // 
            this.ActiveEntity.DataPropertyName = "ActiveEntity";
            this.ActiveEntity.HeaderText = "Active Entity";
            this.ActiveEntity.Name = "ActiveEntity";
            this.ActiveEntity.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.DataPropertyName = "Action";
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Timer
            // 
            this.Timer.DataPropertyName = "Timer";
            this.Timer.HeaderText = "Timer";
            this.Timer.Name = "Timer";
            this.Timer.ReadOnly = true;
            // 
            // PassiveEntity
            // 
            this.PassiveEntity.DataPropertyName = "PassiveEntity";
            this.PassiveEntity.HeaderText = "Passive Entity";
            this.PassiveEntity.Name = "PassiveEntity";
            this.PassiveEntity.ReadOnly = true;
            // 
            // detailsBindingSource
            // 
            this.detailsBindingSource.DataMember = "Details";
            this.detailsBindingSource.DataSource = this.parallelZodiacDataSetDetails;
            // 
            // parallelZodiacDataSetDetails
            // 
            this.parallelZodiacDataSetDetails.DataSetName = "ParallelZodiacDataSetDetails";
            this.parallelZodiacDataSetDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_Steps
            // 
            this.dataGridView_Steps.AutoGenerateColumns = false;
            this.dataGridView_Steps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Steps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StepID,
            this.QuestID_StepTable,
            this.StepName});
            this.dataGridView_Steps.DataSource = this.stepsBindingSource;
            this.dataGridView_Steps.Location = new System.Drawing.Point(416, 3);
            this.dataGridView_Steps.MultiSelect = false;
            this.dataGridView_Steps.Name = "dataGridView_Steps";
            this.dataGridView_Steps.ReadOnly = true;
            this.dataGridView_Steps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Steps.Size = new System.Drawing.Size(407, 495);
            this.dataGridView_Steps.TabIndex = 14;
            this.dataGridView_Steps.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Steps_CellClick);
            // 
            // StepID
            // 
            this.StepID.DataPropertyName = "ID";
            this.StepID.HeaderText = "ID";
            this.StepID.Name = "StepID";
            this.StepID.ReadOnly = true;
            // 
            // QuestID_StepTable
            // 
            this.QuestID_StepTable.DataPropertyName = "QuestID";
            this.QuestID_StepTable.HeaderText = "QuestID";
            this.QuestID_StepTable.Name = "QuestID_StepTable";
            this.QuestID_StepTable.ReadOnly = true;
            // 
            // StepName
            // 
            this.StepName.DataPropertyName = "StepName";
            this.StepName.HeaderText = "StepName";
            this.StepName.Name = "StepName";
            this.StepName.ReadOnly = true;
            // 
            // stepsBindingSource
            // 
            this.stepsBindingSource.DataMember = "Steps";
            this.stepsBindingSource.DataSource = this.parallelZodiacDataSetSteps;
            // 
            // parallelZodiacDataSetSteps
            // 
            this.parallelZodiacDataSetSteps.DataSetName = "ParallelZodiacDataSetSteps";
            this.parallelZodiacDataSetSteps.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_Quests
            // 
            this.dataGridView_Quests.AutoGenerateColumns = false;
            this.dataGridView_Quests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Quests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestID,
            this.QuestName,
            this.QuestDescription,
            this.CurrentStep});
            this.dataGridView_Quests.DataSource = this.questsBindingSource;
            this.dataGridView_Quests.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Quests.MultiSelect = false;
            this.dataGridView_Quests.Name = "dataGridView_Quests";
            this.dataGridView_Quests.ReadOnly = true;
            this.dataGridView_Quests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Quests.Size = new System.Drawing.Size(407, 495);
            this.dataGridView_Quests.TabIndex = 13;
            this.dataGridView_Quests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Quests_CellClick);
            // 
            // QuestID
            // 
            this.QuestID.DataPropertyName = "ID";
            this.QuestID.HeaderText = "ID";
            this.QuestID.Name = "QuestID";
            this.QuestID.ReadOnly = true;
            // 
            // QuestName
            // 
            this.QuestName.DataPropertyName = "Name";
            this.QuestName.HeaderText = "Name";
            this.QuestName.Name = "QuestName";
            this.QuestName.ReadOnly = true;
            // 
            // QuestDescription
            // 
            this.QuestDescription.DataPropertyName = "Description";
            this.QuestDescription.HeaderText = "Description";
            this.QuestDescription.Name = "QuestDescription";
            this.QuestDescription.ReadOnly = true;
            // 
            // CurrentStep
            // 
            this.CurrentStep.DataPropertyName = "CurrentStep";
            this.CurrentStep.HeaderText = "CurrentStep";
            this.CurrentStep.Name = "CurrentStep";
            this.CurrentStep.ReadOnly = true;
            // 
            // questsBindingSource
            // 
            this.questsBindingSource.DataMember = "Quests";
            this.questsBindingSource.DataSource = this.parallelZodiacDataSet;
            // 
            // parallelZodiacDataSet
            // 
            this.parallelZodiacDataSet.DataSetName = "ParallelZodiacDataSet";
            this.parallelZodiacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // questsTableAdapter
            // 
            this.questsTableAdapter.ClearBeforeFill = true;
            // 
            // stepsTableAdapter
            // 
            this.stepsTableAdapter.ClearBeforeFill = true;
            // 
            // detailsTableAdapter
            // 
            this.detailsTableAdapter.ClearBeforeFill = true;
            // 
            // button_DeleteQuest
            // 
            this.button_DeleteQuest.Location = new System.Drawing.Point(322, 65);
            this.button_DeleteQuest.Name = "button_DeleteQuest";
            this.button_DeleteQuest.Size = new System.Drawing.Size(100, 100);
            this.button_DeleteQuest.TabIndex = 13;
            this.button_DeleteQuest.Text = "Delete Quest";
            this.button_DeleteQuest.UseVisualStyleBackColor = true;
            this.button_DeleteQuest.Click += new System.EventHandler(this.button_DeleteQuest_Click);
            // 
            // button_DeleteStep
            // 
            this.button_DeleteStep.Location = new System.Drawing.Point(735, 65);
            this.button_DeleteStep.Name = "button_DeleteStep";
            this.button_DeleteStep.Size = new System.Drawing.Size(100, 100);
            this.button_DeleteStep.TabIndex = 14;
            this.button_DeleteStep.Text = "Delete Step";
            this.button_DeleteStep.UseVisualStyleBackColor = true;
            this.button_DeleteStep.Click += new System.EventHandler(this.button_DeleteStep_Click);
            // 
            // button_DeleteDetail
            // 
            this.button_DeleteDetail.Location = new System.Drawing.Point(1148, 65);
            this.button_DeleteDetail.Name = "button_DeleteDetail";
            this.button_DeleteDetail.Size = new System.Drawing.Size(100, 100);
            this.button_DeleteDetail.TabIndex = 15;
            this.button_DeleteDetail.Text = "Delete Detail";
            this.button_DeleteDetail.UseVisualStyleBackColor = true;
            this.button_DeleteDetail.Click += new System.EventHandler(this.button_DeleteDetail_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildAllToolStripMenuItem,
            this.buildSelectedQuestToolStripMenuItem,
            this.buildOutOfDateQuestsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buildAllToolStripMenuItem
            // 
            this.buildAllToolStripMenuItem.Name = "buildAllToolStripMenuItem";
            this.buildAllToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.buildAllToolStripMenuItem.Text = "Build All";
            this.buildAllToolStripMenuItem.Click += new System.EventHandler(this.buildAllToolStripMenuItem_Click);
            // 
            // buildSelectedQuestToolStripMenuItem
            // 
            this.buildSelectedQuestToolStripMenuItem.Name = "buildSelectedQuestToolStripMenuItem";
            this.buildSelectedQuestToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.buildSelectedQuestToolStripMenuItem.Text = "Build Selected Quest";
            this.buildSelectedQuestToolStripMenuItem.Click += new System.EventHandler(this.buildSelectedQuestToolStripMenuItem_Click);
            // 
            // buildOutOfDateQuestsToolStripMenuItem
            // 
            this.buildOutOfDateQuestsToolStripMenuItem.Name = "buildOutOfDateQuestsToolStripMenuItem";
            this.buildOutOfDateQuestsToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.buildOutOfDateQuestsToolStripMenuItem.Text = "Build Out Of Date Quests";
            this.buildOutOfDateQuestsToolStripMenuItem.Click += new System.EventHandler(this.buildOutOfDateQuestsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button_DeleteDetail);
            this.Controls.Add(this.button_DeleteStep);
            this.Controls.Add(this.button_DeleteQuest);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_EditDetails);
            this.Controls.Add(this.button_AddDetails);
            this.Controls.Add(this.button_EditStep);
            this.Controls.Add(this.button_AddStep);
            this.Controls.Add(this.button_EditQuest);
            this.Controls.Add(this.button_AddQuest);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelZodiacDataSetDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Steps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelZodiacDataSetSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Quests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelZodiacDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_AddQuest;
        private System.Windows.Forms.Button button_EditQuest;
        private System.Windows.Forms.Button button_AddStep;
        private System.Windows.Forms.Button button_EditStep;
        private System.Windows.Forms.Button button_AddDetails;
        private System.Windows.Forms.Button button_EditDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DataSets.ParallelZodiacDataSet parallelZodiacDataSet;
        private System.Windows.Forms.BindingSource questsBindingSource;
        private DataSets.ParallelZodiacDataSetTableAdapters.QuestsTableAdapter questsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_Quests;
        private System.Windows.Forms.DataGridView dataGridView_Details;
        private System.Windows.Forms.DataGridView dataGridView_Steps;
        private DataSets.ParallelZodiacDataSetSteps parallelZodiacDataSetSteps;
        private System.Windows.Forms.BindingSource stepsBindingSource;
        private DataSets.ParallelZodiacDataSetStepsTableAdapters.StepsTableAdapter stepsTableAdapter;
        private DataSets.ParallelZodiacDataSetDialogue parallelZodiacDataSetDetails;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private DataSets.ParallelZodiacDataSetDialogueTableAdapters.DetailsTableAdapter detailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassiveEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestID_StepTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentStep;
        private System.Windows.Forms.Button button_DeleteQuest;
        private System.Windows.Forms.Button button_DeleteStep;
        private System.Windows.Forms.Button button_DeleteDetail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buildAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildSelectedQuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildOutOfDateQuestsToolStripMenuItem;
    }
}

