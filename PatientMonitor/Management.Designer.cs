namespace PatientMonitor
{
    partial class Management
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabShifts = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabResponseTimes = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monitorDB = new PatientMonitor.MonitorDB();
            this.staffIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alarmTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.respondTime1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responseTimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shiftsTableAdapter1 = new PatientMonitor.MonitorDBTableAdapters.ShiftsTableAdapter();
            this.responseTimesTableAdapter = new PatientMonitor.MonitorDBTableAdapters.ResponseTimesTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabShifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabResponseTimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseTimesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(363, 258);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabShifts);
            this.tabControl1.Controls.Add(this.tabResponseTimes);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 229);
            this.tabControl1.TabIndex = 2;
            // 
            // tabShifts
            // 
            this.tabShifts.Controls.Add(this.dataGridView1);
            this.tabShifts.Location = new System.Drawing.Point(4, 22);
            this.tabShifts.Name = "tabShifts";
            this.tabShifts.Padding = new System.Windows.Forms.Padding(3);
            this.tabShifts.Size = new System.Drawing.Size(417, 203);
            this.tabShifts.TabIndex = 0;
            this.tabShifts.Text = "Staff Shifts";
            this.tabShifts.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shiftsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(411, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabResponseTimes
            // 
            this.tabResponseTimes.Controls.Add(this.dataGridView2);
            this.tabResponseTimes.Location = new System.Drawing.Point(4, 22);
            this.tabResponseTimes.Name = "tabResponseTimes";
            this.tabResponseTimes.Padding = new System.Windows.Forms.Padding(3);
            this.tabResponseTimes.Size = new System.Drawing.Size(417, 203);
            this.tabResponseTimes.TabIndex = 1;
            this.tabResponseTimes.Text = "Response Times";
            this.tabResponseTimes.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn1,
            this.bedDataGridViewTextBoxColumn,
            this.alarmTimeDataGridViewTextBoxColumn,
            this.respondTime1DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.responseTimesBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(411, 197);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(13, 257);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 23);
            this.btnAddStaff.TabIndex = 3;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "Staff ID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.staffIDDataGridViewTextBoxColumn.Width = 68;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shiftsBindingSource
            // 
            this.shiftsBindingSource.DataMember = "Shifts";
            this.shiftsBindingSource.DataSource = this.monitorDB;
            // 
            // monitorDB
            // 
            this.monitorDB.DataSetName = "MonitorDB";
            this.monitorDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffIDDataGridViewTextBoxColumn1
            // 
            this.staffIDDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.staffIDDataGridViewTextBoxColumn1.DataPropertyName = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.HeaderText = "StaffID";
            this.staffIDDataGridViewTextBoxColumn1.Name = "staffIDDataGridViewTextBoxColumn1";
            this.staffIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.staffIDDataGridViewTextBoxColumn1.Visible = false;
            this.staffIDDataGridViewTextBoxColumn1.Width = 65;
            // 
            // bedDataGridViewTextBoxColumn
            // 
            this.bedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.bedDataGridViewTextBoxColumn.DataPropertyName = "Bed";
            this.bedDataGridViewTextBoxColumn.HeaderText = "Bed";
            this.bedDataGridViewTextBoxColumn.Name = "bedDataGridViewTextBoxColumn";
            this.bedDataGridViewTextBoxColumn.ReadOnly = true;
            this.bedDataGridViewTextBoxColumn.Width = 51;
            // 
            // alarmTimeDataGridViewTextBoxColumn
            // 
            this.alarmTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.alarmTimeDataGridViewTextBoxColumn.DataPropertyName = "AlarmTime";
            this.alarmTimeDataGridViewTextBoxColumn.HeaderText = "Responded";
            this.alarmTimeDataGridViewTextBoxColumn.Name = "alarmTimeDataGridViewTextBoxColumn";
            this.alarmTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.alarmTimeDataGridViewTextBoxColumn.Width = 87;
            // 
            // respondTime1DataGridViewTextBoxColumn
            // 
            this.respondTime1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.respondTime1DataGridViewTextBoxColumn.DataPropertyName = "RespondTime1";
            this.respondTime1DataGridViewTextBoxColumn.HeaderText = "Time Taken (Seconds)";
            this.respondTime1DataGridViewTextBoxColumn.Name = "respondTime1DataGridViewTextBoxColumn";
            this.respondTime1DataGridViewTextBoxColumn.ReadOnly = true;
            this.respondTime1DataGridViewTextBoxColumn.Width = 128;
            // 
            // responseTimesBindingSource
            // 
            this.responseTimesBindingSource.DataMember = "ResponseTimes";
            this.responseTimesBindingSource.DataSource = this.monitorDB;
            // 
            // shiftsTableAdapter1
            // 
            this.shiftsTableAdapter1.ClearBeforeFill = true;
            // 
            // responseTimesTableAdapter
            // 
            this.responseTimesTableAdapter.ClearBeforeFill = true;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 293);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClose);
            this.Name = "Management";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabShifts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabResponseTimes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseTimesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabShifts;
        private System.Windows.Forms.TabPage tabResponseTimes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MonitorDB monitorDB;
        private System.Windows.Forms.BindingSource shiftsBindingSource;
        private MonitorDBTableAdapters.ShiftsTableAdapter shiftsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource responseTimesBindingSource;
        private MonitorDBTableAdapters.ResponseTimesTableAdapter responseTimesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alarmTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn respondTime1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddStaff;
    }
}