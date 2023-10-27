namespace SP_Lab1
{
    partial class ProcessesInformation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessesInformation));
            label1 = new Label();
            ProcessesCount = new TextBox();
            label2 = new Label();
            ThreadsCount = new TextBox();
            Update = new Button();
            ProcessesTable = new DataGridView();
            ProcessId = new DataGridViewTextBoxColumn();
            ProcessName = new DataGridViewTextBoxColumn();
            MemoryUsage = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            ProcessPriority = new DataGridViewTextBoxColumn();
            ThreadsTable = new DataGridView();
            ThreadsId = new DataGridViewTextBoxColumn();
            ThreadsPriority = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ProcessesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ThreadsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 611);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 2;
            label1.Text = "Processes";
            // 
            // ProcessesCount
            // 
            ProcessesCount.Enabled = false;
            ProcessesCount.Location = new Point(117, 612);
            ProcessesCount.Name = "ProcessesCount";
            ProcessesCount.PlaceholderText = "0";
            ProcessesCount.Size = new Size(148, 27);
            ProcessesCount.TabIndex = 3;
            ProcessesCount.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(893, 614);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 4;
            label2.Text = "Threads";
            // 
            // ThreadsCount
            // 
            ThreadsCount.Enabled = false;
            ThreadsCount.Location = new Point(1006, 614);
            ThreadsCount.Name = "ThreadsCount";
            ThreadsCount.PlaceholderText = "0";
            ThreadsCount.Size = new Size(148, 27);
            ThreadsCount.TabIndex = 5;
            ThreadsCount.TextAlign = HorizontalAlignment.Center;
            // 
            // Update
            // 
            Update.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Update.Location = new Point(747, 612);
            Update.Name = "Update";
            Update.Size = new Size(125, 29);
            Update.TabIndex = 6;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // ProcessesTable
            // 
            ProcessesTable.AllowUserToAddRows = false;
            ProcessesTable.AllowUserToDeleteRows = false;
            ProcessesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProcessesTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProcessesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ProcessesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProcessesTable.Columns.AddRange(new DataGridViewColumn[] { ProcessId, ProcessName, MemoryUsage, UserName, ProcessPriority });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ProcessesTable.DefaultCellStyle = dataGridViewCellStyle2;
            ProcessesTable.Location = new Point(12, 12);
            ProcessesTable.MultiSelect = false;
            ProcessesTable.Name = "ProcessesTable";
            ProcessesTable.ReadOnly = true;
            ProcessesTable.RowHeadersWidth = 51;
            ProcessesTable.RowTemplate.Height = 29;
            ProcessesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProcessesTable.Size = new Size(860, 593);
            ProcessesTable.TabIndex = 9;
            ProcessesTable.RowEnter += ProcessesTable_RowEnter;
            // 
            // ProcessId
            // 
            ProcessId.HeaderText = "Process Id";
            ProcessId.MinimumWidth = 6;
            ProcessId.Name = "ProcessId";
            ProcessId.ReadOnly = true;
            // 
            // ProcessName
            // 
            ProcessName.HeaderText = "Process Name";
            ProcessName.MinimumWidth = 6;
            ProcessName.Name = "ProcessName";
            ProcessName.ReadOnly = true;
            // 
            // MemoryUsage
            // 
            MemoryUsage.HeaderText = "Memory Usage(MB)";
            MemoryUsage.MinimumWidth = 6;
            MemoryUsage.Name = "MemoryUsage";
            MemoryUsage.ReadOnly = true;
            // 
            // UserName
            // 
            UserName.HeaderText = "User Name";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // ProcessPriority
            // 
            ProcessPriority.HeaderText = "Process Priority";
            ProcessPriority.MinimumWidth = 6;
            ProcessPriority.Name = "ProcessPriority";
            ProcessPriority.ReadOnly = true;
            // 
            // ThreadsTable
            // 
            ThreadsTable.AllowUserToAddRows = false;
            ThreadsTable.AllowUserToDeleteRows = false;
            ThreadsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ThreadsTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            ThreadsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            ThreadsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ThreadsTable.Columns.AddRange(new DataGridViewColumn[] { ThreadsId, ThreadsPriority });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            ThreadsTable.DefaultCellStyle = dataGridViewCellStyle4;
            ThreadsTable.Location = new Point(893, 12);
            ThreadsTable.Name = "ThreadsTable";
            ThreadsTable.RowHeadersWidth = 51;
            ThreadsTable.RowTemplate.Height = 29;
            ThreadsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ThreadsTable.Size = new Size(261, 593);
            ThreadsTable.TabIndex = 10;
            // 
            // ThreadsId
            // 
            ThreadsId.HeaderText = "Threads Id";
            ThreadsId.MinimumWidth = 6;
            ThreadsId.Name = "ThreadsId";
            ThreadsId.ReadOnly = true;
            // 
            // ThreadsPriority
            // 
            ThreadsPriority.HeaderText = "Threads Priority";
            ThreadsPriority.MinimumWidth = 6;
            ThreadsPriority.Name = "ThreadsPriority";
            ThreadsPriority.ReadOnly = true;
            // 
            // ProcessesInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 645);
            Controls.Add(ThreadsTable);
            Controls.Add(ProcessesTable);
            Controls.Add(Update);
            Controls.Add(ThreadsCount);
            Controls.Add(label2);
            Controls.Add(ProcessesCount);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ProcessesInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Manager";
            ((System.ComponentModel.ISupportInitialize)ProcessesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)ThreadsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox ProcessesCount;
        private Label label2;
        private TextBox ThreadsCount;
        private Button Update;
        private DataGridView ProcessesTable;
        private DataGridView ThreadsTable;
        private DataGridViewTextBoxColumn ThreadsId;
        private DataGridViewTextBoxColumn ThreadsPriority;
        private DataGridViewTextBoxColumn ProcessId;
        private DataGridViewTextBoxColumn ProcessName;
        private DataGridViewTextBoxColumn MemoryUsage;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn ProcessPriority;
    }
}