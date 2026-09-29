namespace FitTrack.Forms
{
    partial class MainForm
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
            lblTitle = new Label();
            grpGoalDetails = new GroupBox();
            btnClear = new Button();
            btnAddGoal = new Button();
            dtpGoalTargetDate = new DateTimePicker();
            lblTargetDate = new Label();
            numTargetValue = new NumericUpDown();
            lblTargetValue = new Label();
            numStartValue = new NumericUpDown();
            lblStartValue = new Label();
            txtGoalName = new TextBox();
            lblGoalName = new Label();
            cmbGoalType = new ComboBox();
            lblGoalType = new Label();
            grpGoals = new GroupBox();
            dgvGoals = new DataGridView();
            btnLogProgress = new Button();
            btnDeleteGoal = new Button();
            lblStatusFilter = new Label();
            cmbStatusFilter = new ComboBox();
            btnViewHistory = new Button();
            grpGoalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTargetValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStartValue).BeginInit();
            grpGoals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGoals).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(158, 49);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(408, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Fit Track – Fitness Goal Tracker";
            lblTitle.Click += lblTitle_Click;
            // 
            // grpGoalDetails
            // 
            grpGoalDetails.Controls.Add(btnClear);
            grpGoalDetails.Controls.Add(btnAddGoal);
            grpGoalDetails.Controls.Add(dtpGoalTargetDate);
            grpGoalDetails.Controls.Add(lblTargetDate);
            grpGoalDetails.Controls.Add(numTargetValue);
            grpGoalDetails.Controls.Add(lblTargetValue);
            grpGoalDetails.Controls.Add(numStartValue);
            grpGoalDetails.Controls.Add(lblStartValue);
            grpGoalDetails.Controls.Add(txtGoalName);
            grpGoalDetails.Controls.Add(lblGoalName);
            grpGoalDetails.Controls.Add(cmbGoalType);
            grpGoalDetails.Controls.Add(lblGoalType);
            grpGoalDetails.Location = new Point(30, 100);
            grpGoalDetails.Name = "grpGoalDetails";
            grpGoalDetails.Size = new Size(380, 300);
            grpGoalDetails.TabIndex = 1;
            grpGoalDetails.TabStop = false;
            grpGoalDetails.Text = "Goal Details";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(161, 240);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 35);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddGoal
            // 
            btnAddGoal.Location = new Point(22, 240);
            btnAddGoal.Name = "btnAddGoal";
            btnAddGoal.Size = new Size(110, 35);
            btnAddGoal.TabIndex = 11;
            btnAddGoal.Text = "Add Goal";
            btnAddGoal.UseVisualStyleBackColor = true;
            btnAddGoal.Click += btnAddGoal_Click;
            // 
            // dtpGoalTargetDate
            // 
            dtpGoalTargetDate.Format = DateTimePickerFormat.Short;
            dtpGoalTargetDate.Location = new Point(172, 195);
            dtpGoalTargetDate.Name = "dtpGoalTargetDate";
            dtpGoalTargetDate.Size = new Size(200, 23);
            dtpGoalTargetDate.TabIndex = 10;
            // 
            // lblTargetDate
            // 
            lblTargetDate.AutoSize = true;
            lblTargetDate.Location = new Point(26, 203);
            lblTargetDate.Name = "lblTargetDate";
            lblTargetDate.Size = new Size(70, 15);
            lblTargetDate.TabIndex = 9;
            lblTargetDate.Text = "Target Date:";
            lblTargetDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // numTargetValue
            // 
            numTargetValue.DecimalPlaces = 2;
            numTargetValue.Location = new Point(172, 154);
            numTargetValue.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numTargetValue.Name = "numTargetValue";
            numTargetValue.Size = new Size(200, 23);
            numTargetValue.TabIndex = 7;
            // 
            // lblTargetValue
            // 
            lblTargetValue.AutoSize = true;
            lblTargetValue.Location = new Point(22, 154);
            lblTargetValue.Name = "lblTargetValue";
            lblTargetValue.Size = new Size(74, 15);
            lblTargetValue.TabIndex = 6;
            lblTargetValue.Text = "Target Value:";
            // 
            // numStartValue
            // 
            numStartValue.DecimalPlaces = 2;
            numStartValue.Location = new Point(172, 113);
            numStartValue.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numStartValue.Name = "numStartValue";
            numStartValue.Size = new Size(200, 23);
            numStartValue.TabIndex = 5;
            // 
            // lblStartValue
            // 
            lblStartValue.AutoSize = true;
            lblStartValue.Location = new Point(18, 113);
            lblStartValue.Name = "lblStartValue";
            lblStartValue.Size = new Size(65, 15);
            lblStartValue.TabIndex = 4;
            lblStartValue.Text = "Start Value:";
            // 
            // txtGoalName
            // 
            txtGoalName.Location = new Point(172, 79);
            txtGoalName.Name = "txtGoalName";
            txtGoalName.Size = new Size(200, 23);
            txtGoalName.TabIndex = 3;
            // 
            // lblGoalName
            // 
            lblGoalName.AutoSize = true;
            lblGoalName.Location = new Point(18, 79);
            lblGoalName.Name = "lblGoalName";
            lblGoalName.Size = new Size(69, 15);
            lblGoalName.TabIndex = 2;
            lblGoalName.Text = "Goal Name:";
            // 
            // cmbGoalType
            // 
            cmbGoalType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGoalType.FormattingEnabled = true;
            cmbGoalType.Items.AddRange(new object[] { "Weight Loss", "", "Fat Loss", "", "Strength", "", "Endurance" });
            cmbGoalType.Location = new Point(172, 42);
            cmbGoalType.Name = "cmbGoalType";
            cmbGoalType.Size = new Size(200, 23);
            cmbGoalType.TabIndex = 1;
            // 
            // lblGoalType
            // 
            lblGoalType.AutoSize = true;
            lblGoalType.Location = new Point(18, 40);
            lblGoalType.Name = "lblGoalType";
            lblGoalType.Size = new Size(62, 15);
            lblGoalType.TabIndex = 0;
            lblGoalType.Text = "Goal Type:";
            // 
            // grpGoals
            // 
            grpGoals.Controls.Add(dgvGoals);
            grpGoals.Location = new Point(416, 100);
            grpGoals.Name = "grpGoals";
            grpGoals.Size = new Size(874, 310);
            grpGoals.TabIndex = 2;
            grpGoals.TabStop = false;
            grpGoals.Text = "Fitness Goals";
            // 
            // dgvGoals
            // 
            dgvGoals.AllowUserToAddRows = false;
            dgvGoals.AllowUserToDeleteRows = false;
            dgvGoals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvGoals.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvGoals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGoals.Dock = DockStyle.Fill;
            dgvGoals.Location = new Point(3, 19);
            dgvGoals.MultiSelect = false;
            dgvGoals.Name = "dgvGoals";
            dgvGoals.ReadOnly = true;
            dgvGoals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGoals.Size = new Size(868, 288);
            dgvGoals.TabIndex = 0;
            // 
            // btnLogProgress
            // 
            btnLogProgress.Location = new Point(452, 416);
            btnLogProgress.Name = "btnLogProgress";
            btnLogProgress.Size = new Size(120, 35);
            btnLogProgress.TabIndex = 3;
            btnLogProgress.Text = "Log Progress";
            btnLogProgress.UseVisualStyleBackColor = true;
            btnLogProgress.Click += btnLogProgress_Click;
            // 
            // btnDeleteGoal
            // 
            btnDeleteGoal.Location = new Point(600, 416);
            btnDeleteGoal.Name = "btnDeleteGoal";
            btnDeleteGoal.Size = new Size(120, 35);
            btnDeleteGoal.TabIndex = 4;
            btnDeleteGoal.Text = "Delete Goal";
            btnDeleteGoal.UseVisualStyleBackColor = true;
            btnDeleteGoal.Click += btnDeleteGoal_Click;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Location = new Point(619, 67);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(70, 15);
            lblStatusFilter.TabIndex = 5;
            lblStatusFilter.Text = "Show goals:";
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "All", "Active", "Completed" });
            cmbStatusFilter.Location = new Point(710, 64);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(200, 23);
            cmbStatusFilter.TabIndex = 6;
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Location = new Point(756, 416);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(120, 35);
            btnViewHistory.TabIndex = 7;
            btnViewHistory.Text = "View History";
            btnViewHistory.UseVisualStyleBackColor = true;
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1326, 661);
            Controls.Add(btnViewHistory);
            Controls.Add(cmbStatusFilter);
            Controls.Add(lblStatusFilter);
            Controls.Add(btnDeleteGoal);
            Controls.Add(btnLogProgress);
            Controls.Add(grpGoals);
            Controls.Add(grpGoalDetails);
            Controls.Add(lblTitle);
            MinimumSize = new Size(1342, 700);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fit Track";
            Load += MainForm_Load;
            grpGoalDetails.ResumeLayout(false);
            grpGoalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTargetValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStartValue).EndInit();
            grpGoals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGoals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpGoalDetails;
        private Label lblGoalType;
        private ComboBox cmbGoalType;
        private TextBox txtGoalName;
        private Label lblGoalName;
        private Label lblStartValue;
        private NumericUpDown numStartValue;
        private Label lblTargetValue;
        private NumericUpDown numTargetValue;
        private Label lblTargetDate;
        private DateTimePicker dtpGoalTargetDate;
        private Button btnAddGoal;
        private Button btnClear;
        private GroupBox grpGoals;
        private DataGridView dgvGoals;
        private Button btnLogProgress;
        private Button btnDeleteGoal;
        private Label lblStatusFilter;
        private ComboBox cmbStatusFilter;
        private Button btnViewHistory;
    }
}