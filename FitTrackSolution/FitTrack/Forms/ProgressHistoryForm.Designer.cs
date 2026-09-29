namespace FitTrack.Forms
{
    partial class ProgressHistoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblGoalName = new Label();
            lblEmptyHistory = new Label();
            dgvHistory = new DataGridView();
            btnClose = new Button();
            colEntryDate = new DataGridViewTextBoxColumn();
            colLoggedValue = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // lblGoalName
            // 
            lblGoalName.AutoEllipsis = true;
            lblGoalName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGoalName.Location = new Point(20, 20);
            lblGoalName.Name = "lblGoalName";
            lblGoalName.Size = new Size(660, 40);
            lblGoalName.TabIndex = 0;
            lblGoalName.Text = "Goal name";
            // 
            // lblEmptyHistory
            // 
            lblEmptyHistory.Location = new Point(20, 65);
            lblEmptyHistory.Name = "lblEmptyHistory";
            lblEmptyHistory.Size = new Size(660, 25);
            lblEmptyHistory.TabIndex = 1;
            lblEmptyHistory.Text = "No progress entries have been recorded for this goal.";
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = SystemColors.Window;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Columns.AddRange(new DataGridViewColumn[] { colEntryDate, colLoggedValue });
            dgvHistory.Location = new Point(20, 100);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(660, 275);
            dgvHistory.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Location = new Point(570, 395);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 35);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // colEntryDate
            // 
            colEntryDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEntryDate.DataPropertyName = "EntryDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            colEntryDate.DefaultCellStyle = dataGridViewCellStyle1;
            colEntryDate.HeaderText = "Progress Date";
            colEntryDate.Name = "colEntryDate";
            colEntryDate.ReadOnly = true;
            colEntryDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colLoggedValue
            // 
            colLoggedValue.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colLoggedValue.DataPropertyName = "LoggedValue";
            dataGridViewCellStyle2.Format = "0.##";
            dataGridViewCellStyle2.NullValue = null;
            colLoggedValue.DefaultCellStyle = dataGridViewCellStyle2;
            colLoggedValue.HeaderText = "Recorded Value";
            colLoggedValue.Name = "colLoggedValue";
            colLoggedValue.ReadOnly = true;
            colLoggedValue.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ProgressHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(827, 478);
            Controls.Add(btnClose);
            Controls.Add(dgvHistory);
            Controls.Add(lblEmptyHistory);
            Controls.Add(lblGoalName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProgressHistoryForm";
            RightToLeftLayout = true;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Progress History";
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblGoalName;
        private Label lblEmptyHistory;
        private DataGridView dgvHistory;
        private Button btnClose;
        private DataGridViewTextBoxColumn colEntryDate;
        private DataGridViewTextBoxColumn colLoggedValue;
    }
}