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
            this.detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parallelZodiacDataSetDetails = new QuestEditor.DataSets.ParallelZodiacDataSetDialogue();
            this.stepsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parallelZodiacDataSetSteps = new QuestEditor.DataSets.ParallelZodiacDataSetSteps();
            this.questsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parallelZodiacDataSet = new QuestEditor.DataSets.ParallelZodiacDataSet();
            this.questsTableAdapter = new QuestEditor.DataSets.ParallelZodiacDataSetTableAdapters.QuestsTableAdapter();
            this.stepsTableAdapter = new QuestEditor.DataSets.ParallelZodiacDataSetStepsTableAdapters.StepsTableAdapter();
            this.detailsTableAdapter = new QuestEditor.DataSets.ParallelZodiacDataSetDialogueTableAdapters.DetailsTableAdapter();
            this.button_DeleteQuest = new System.Windows.Forms.Button();
            this.button_DeleteStep = new System.Windows.Forms.Button();
            this.button_DeleteDetail = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Quests = new System.Windows.Forms.DataGridView();
            this.dataGridView_Steps = new System.Windows.Forms.DataGridView();
            this.StepID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestID_StepTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_Details = new System.Windows.Forms.DataGridView();
            this.DetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassiveEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buildAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildOutOfDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelZodiacDataSetDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelZodiacDataSetSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelZodiacDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Quests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Steps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Details)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_AddQuest
            // 
            this.button_AddQuest.Location = new System.Drawing.Point(6, 19);
            this.button_AddQuest.Name = "button_AddQuest";
            this.button_AddQuest.Size = new System.Drawing.Size(100, 100);
            this.button_AddQuest.TabIndex = 3;
            this.button_AddQuest.Text = "Add Quest";
            this.button_AddQuest.UseVisualStyleBackColor = true;
            this.button_AddQuest.Click += new System.EventHandler(this.button_AddQuest_Click);
            // 
            // button_EditQuest
            // 
            this.button_EditQuest.Location = new System.Drawing.Point(112, 19);
            this.button_EditQuest.Name = "button_EditQuest";
            this.button_EditQuest.Size = new System.Drawing.Size(100, 100);
            this.button_EditQuest.TabIndex = 4;
            this.button_EditQuest.Text = "Edit Quest";
            this.button_EditQuest.UseVisualStyleBackColor = true;
            this.button_EditQuest.Click += new System.EventHandler(this.button_EditQuest_Click);
            // 
            // button_AddStep
            // 
            this.button_AddStep.Location = new System.Drawing.Point(6, 19);
            this.button_AddStep.Name = "button_AddStep";
            this.button_AddStep.Size = new System.Drawing.Size(100, 100);
            this.button_AddStep.TabIndex = 5;
            this.button_AddStep.Text = "Add Step";
            this.button_AddStep.UseVisualStyleBackColor = true;
            this.button_AddStep.Click += new System.EventHandler(this.button_AddStep_Click);
            // 
            // button_EditStep
            // 
            this.button_EditStep.Location = new System.Drawing.Point(112, 19);
            this.button_EditStep.Name = "button_EditStep";
            this.button_EditStep.Size = new System.Drawing.Size(100, 100);
            this.button_EditStep.TabIndex = 6;
            this.button_EditStep.Text = "Edit Step";
            this.button_EditStep.UseVisualStyleBackColor = true;
            this.button_EditStep.Click += new System.EventHandler(this.button_EditStep_Click);
            // 
            // button_AddDetails
            // 
            this.button_AddDetails.Location = new System.Drawing.Point(6, 19);
            this.button_AddDetails.Name = "button_AddDetails";
            this.button_AddDetails.Size = new System.Drawing.Size(100, 100);
            this.button_AddDetails.TabIndex = 7;
            this.button_AddDetails.Text = "Add Detail";
            this.button_AddDetails.UseVisualStyleBackColor = true;
            this.button_AddDetails.Click += new System.EventHandler(this.button_AddDetails_Click);
            // 
            // button_EditDetails
            // 
            this.button_EditDetails.Location = new System.Drawing.Point(112, 19);
            this.button_EditDetails.Name = "button_EditDetails";
            this.button_EditDetails.Size = new System.Drawing.Size(100, 100);
            this.button_EditDetails.TabIndex = 8;
            this.button_EditDetails.Text = "Edit Detail";
            this.button_EditDetails.UseVisualStyleBackColor = true;
            this.button_EditDetails.Click += new System.EventHandler(this.button_EditDetails_Click);
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
            this.button_DeleteQuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeleteQuest.Location = new System.Drawing.Point(339, 19);
            this.button_DeleteQuest.Name = "button_DeleteQuest";
            this.button_DeleteQuest.Size = new System.Drawing.Size(100, 100);
            this.button_DeleteQuest.TabIndex = 13;
            this.button_DeleteQuest.Text = "Delete Quest";
            this.button_DeleteQuest.UseVisualStyleBackColor = true;
            this.button_DeleteQuest.Click += new System.EventHandler(this.button_DeleteQuest_Click);
            // 
            // button_DeleteStep
            // 
            this.button_DeleteStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeleteStep.Location = new System.Drawing.Point(339, 19);
            this.button_DeleteStep.Name = "button_DeleteStep";
            this.button_DeleteStep.Size = new System.Drawing.Size(100, 100);
            this.button_DeleteStep.TabIndex = 14;
            this.button_DeleteStep.Text = "Delete Step";
            this.button_DeleteStep.UseVisualStyleBackColor = true;
            this.button_DeleteStep.Click += new System.EventHandler(this.button_DeleteStep_Click);
            // 
            // button_DeleteDetail
            // 
            this.button_DeleteDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DeleteDetail.Location = new System.Drawing.Point(342, 19);
            this.button_DeleteDetail.Name = "button_DeleteDetail";
            this.button_DeleteDetail.Size = new System.Drawing.Size(100, 100);
            this.button_DeleteDetail.TabIndex = 15;
            this.button_DeleteDetail.Text = "Delete Detail";
            this.button_DeleteDetail.UseVisualStyleBackColor = true;
            this.button_DeleteDetail.Click += new System.EventHandler(this.button_DeleteDetail_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_AddQuest);
            this.groupBox1.Controls.Add(this.button_EditQuest);
            this.groupBox1.Controls.Add(this.button_DeleteQuest);
            this.groupBox1.Controls.Add(this.dataGridView_Quests);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 687);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quests";
            // 
            // dataGridView_Quests
            // 
            this.dataGridView_Quests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Quests.AutoGenerateColumns = false;
            this.dataGridView_Quests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Quests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestID,
            this.QuestName,
            this.QuestDescription,
            this.CurrentStep});
            this.dataGridView_Quests.DataSource = this.questsBindingSource;
            this.dataGridView_Quests.Location = new System.Drawing.Point(6, 148);
            this.dataGridView_Quests.MultiSelect = false;
            this.dataGridView_Quests.Name = "dataGridView_Quests";
            this.dataGridView_Quests.ReadOnly = true;
            this.dataGridView_Quests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Quests.Size = new System.Drawing.Size(433, 536);
            this.dataGridView_Quests.TabIndex = 13;
            this.dataGridView_Quests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Quests_CellClick);
            // 
            // dataGridView_Steps
            // 
            this.dataGridView_Steps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Steps.AutoGenerateColumns = false;
            this.dataGridView_Steps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Steps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StepID,
            this.QuestID_StepTable,
            this.StepName});
            this.dataGridView_Steps.DataSource = this.stepsBindingSource;
            this.dataGridView_Steps.Location = new System.Drawing.Point(6, 141);
            this.dataGridView_Steps.MultiSelect = false;
            this.dataGridView_Steps.Name = "dataGridView_Steps";
            this.dataGridView_Steps.ReadOnly = true;
            this.dataGridView_Steps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Steps.Size = new System.Drawing.Size(433, 543);
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
            // dataGridView_Details
            // 
            this.dataGridView_Details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView_Details.Location = new System.Drawing.Point(6, 125);
            this.dataGridView_Details.MultiSelect = false;
            this.dataGridView_Details.Name = "dataGridView_Details";
            this.dataGridView_Details.ReadOnly = true;
            this.dataGridView_Details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Details.Size = new System.Drawing.Size(436, 559);
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button_AddStep);
            this.groupBox2.Controls.Add(this.button_EditStep);
            this.groupBox2.Controls.Add(this.button_DeleteStep);
            this.groupBox2.Controls.Add(this.dataGridView_Steps);
            this.groupBox2.Location = new System.Drawing.Point(454, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 687);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Steps";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button_AddDetails);
            this.groupBox3.Controls.Add(this.button_EditDetails);
            this.groupBox3.Controls.Add(this.dataGridView_Details);
            this.groupBox3.Controls.Add(this.button_DeleteDetail);
            this.groupBox3.Location = new System.Drawing.Point(905, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 687);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1356, 713);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildAllToolStripMenuItem,
            this.buildSelectedToolStripMenuItem,
            this.buildOutOfDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1356, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buildAllToolStripMenuItem
            // 
            this.buildAllToolStripMenuItem.Name = "buildAllToolStripMenuItem";
            this.buildAllToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.buildAllToolStripMenuItem.Text = "Build All";
            this.buildAllToolStripMenuItem.Click += new System.EventHandler(this.buildAllToolStripMenuItem_Click);
            // 
            // buildSelectedToolStripMenuItem
            // 
            this.buildSelectedToolStripMenuItem.Name = "buildSelectedToolStripMenuItem";
            this.buildSelectedToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.buildSelectedToolStripMenuItem.Text = "Build Selected";
            this.buildSelectedToolStripMenuItem.Click += new System.EventHandler(this.buildSelectedQuestToolStripMenuItem_Click);
            // 
            // buildOutOfDateToolStripMenuItem
            // 
            this.buildOutOfDateToolStripMenuItem.Name = "buildOutOfDateToolStripMenuItem";
            this.buildOutOfDateToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.buildOutOfDateToolStripMenuItem.Text = "Build Out of Date";
            this.buildOutOfDateToolStripMenuItem.Click += new System.EventHandler(this.buildOutOfDateToolStripMenuItem_Click);
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
            this.CurrentStep.HeaderText = "Current Step";
            this.CurrentStep.Name = "CurrentStep";
            this.CurrentStep.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 737);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelZodiacDataSetDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelZodiacDataSetSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelZodiacDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Quests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Steps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Details)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private DataSets.ParallelZodiacDataSet parallelZodiacDataSet;
        private System.Windows.Forms.BindingSource questsBindingSource;
        private DataSets.ParallelZodiacDataSetTableAdapters.QuestsTableAdapter questsTableAdapter;
        private DataSets.ParallelZodiacDataSetSteps parallelZodiacDataSetSteps;
        private System.Windows.Forms.BindingSource stepsBindingSource;
        private DataSets.ParallelZodiacDataSetStepsTableAdapters.StepsTableAdapter stepsTableAdapter;
        private DataSets.ParallelZodiacDataSetDialogue parallelZodiacDataSetDetails;
        private System.Windows.Forms.BindingSource detailsBindingSource;
        private DataSets.ParallelZodiacDataSetDialogueTableAdapters.DetailsTableAdapter detailsTableAdapter;
        private System.Windows.Forms.Button button_DeleteQuest;
        private System.Windows.Forms.Button button_DeleteStep;
        private System.Windows.Forms.Button button_DeleteDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_Quests;
        private System.Windows.Forms.DataGridView dataGridView_Steps;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestID_StepTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepName;
        private System.Windows.Forms.DataGridView dataGridView_Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassiveEntity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buildAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildOutOfDateToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentStep;
    }
}

