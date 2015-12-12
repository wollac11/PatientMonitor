namespace PatientMonitor
{
    partial class Monitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
            this.btnSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.heartRate = new System.Windows.Forms.Label();
            this.breathingRate = new System.Windows.Forms.Label();
            this.bloodPressure = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.cbxBed = new System.Windows.Forms.ComboBox();
            this.Btn_close = new System.Windows.Forms.Button();
            this.gbxThresholds = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblBRMin = new System.Windows.Forms.Label();
            this.lblTempMin = new System.Windows.Forms.Label();
            this.tbrDiaPressureMin = new System.Windows.Forms.TrackBar();
            this.lblDiaPressureMin = new System.Windows.Forms.Label();
            this.lblSysPressureMin = new System.Windows.Forms.Label();
            this.lblHRMin = new System.Windows.Forms.Label();
            this.lblSystolic = new System.Windows.Forms.Label();
            this.lblHeart = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblDiastolic = new System.Windows.Forms.Label();
            this.lblBreath = new System.Windows.Forms.Label();
            this.tbrTempMin = new System.Windows.Forms.TrackBar();
            this.tbrSysPressureMin = new System.Windows.Forms.TrackBar();
            this.tbrHRMin = new System.Windows.Forms.TrackBar();
            this.tbrBRMin = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblBRMax = new System.Windows.Forms.Label();
            this.tbrDiaPressureMax = new System.Windows.Forms.TrackBar();
            this.lblTempMax = new System.Windows.Forms.Label();
            this.lblDiaPressureMax = new System.Windows.Forms.Label();
            this.tbrSysPressureMax = new System.Windows.Forms.TrackBar();
            this.lblSysPressureMax = new System.Windows.Forms.Label();
            this.tbrTempMax = new System.Windows.Forms.TrackBar();
            this.lblHRMax = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbrHRMax = new System.Windows.Forms.TrackBar();
            this.tbrBRMax = new System.Windows.Forms.TrackBar();
            this.gbxMonitor = new System.Windows.Forms.GroupBox();
            this.lblDiaPressure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.tipThresholds = new System.Windows.Forms.ToolTip(this.components);
            this.btnOptions = new System.Windows.Forms.Button();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.lblNurse = new System.Windows.Forms.Label();
            this.lblNurseName = new System.Windows.Forms.Label();
            this.btnStation = new System.Windows.Forms.Button();
            this.gbxThresholds.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrDiaPressureMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrTempMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSysPressureMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHRMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBRMin)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrDiaPressureMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSysPressureMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrTempMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHRMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBRMax)).BeginInit();
            this.gbxMonitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSet
            // 
            this.btnSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSet.Location = new System.Drawing.Point(378, 186);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "Apply";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pulse Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Breathing Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Systolic Pressure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Temperature (°C)";
            // 
            // heartRate
            // 
            this.heartRate.AutoSize = true;
            this.heartRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heartRate.Location = new System.Drawing.Point(52, 70);
            this.heartRate.Name = "heartRate";
            this.heartRate.Size = new System.Drawing.Size(23, 18);
            this.heartRate.TabIndex = 1;
            this.heartRate.Text = "---";
            // 
            // breathingRate
            // 
            this.breathingRate.AutoSize = true;
            this.breathingRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breathingRate.Location = new System.Drawing.Point(361, 70);
            this.breathingRate.Name = "breathingRate";
            this.breathingRate.Size = new System.Drawing.Size(23, 18);
            this.breathingRate.TabIndex = 1;
            this.breathingRate.Text = "---";
            // 
            // bloodPressure
            // 
            this.bloodPressure.AutoSize = true;
            this.bloodPressure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodPressure.Location = new System.Drawing.Point(105, 153);
            this.bloodPressure.Name = "bloodPressure";
            this.bloodPressure.Size = new System.Drawing.Size(23, 18);
            this.bloodPressure.TabIndex = 1;
            this.bloodPressure.Text = "---";
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature.Location = new System.Drawing.Point(204, 70);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(23, 18);
            this.temperature.TabIndex = 1;
            this.temperature.Text = "---";
            // 
            // cbxBed
            // 
            this.cbxBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBed.FormattingEnabled = true;
            this.cbxBed.Items.AddRange(new object[] {
            "Bed 1",
            "Bed 2",
            "Bed 3",
            "Bed 4",
            "Bed 5",
            "Bed 6",
            "Bed 7",
            "Bed 8"});
            this.cbxBed.Location = new System.Drawing.Point(52, 12);
            this.cbxBed.MaxDropDownItems = 10;
            this.cbxBed.Name = "cbxBed";
            this.cbxBed.Size = new System.Drawing.Size(121, 21);
            this.cbxBed.TabIndex = 4;
            this.cbxBed.SelectedIndexChanged += new System.EventHandler(this.cbxBed_SelectedIndexChanged);
            // 
            // Btn_close
            // 
            this.Btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_close.Location = new System.Drawing.Point(388, 472);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(75, 23);
            this.Btn_close.TabIndex = 0;
            this.Btn_close.Text = "Close";
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxThresholds
            // 
            this.gbxThresholds.Controls.Add(this.tabControl1);
            this.gbxThresholds.Controls.Add(this.btnSet);
            this.gbxThresholds.Location = new System.Drawing.Point(10, 253);
            this.gbxThresholds.Name = "gbxThresholds";
            this.gbxThresholds.Size = new System.Drawing.Size(463, 213);
            this.gbxThresholds.TabIndex = 5;
            this.gbxThresholds.TabStop = false;
            this.gbxThresholds.Text = "Alarm Thresholds";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(451, 165);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.lblBRMin);
            this.tabPage1.Controls.Add(this.lblTempMin);
            this.tabPage1.Controls.Add(this.tbrDiaPressureMin);
            this.tabPage1.Controls.Add(this.lblDiaPressureMin);
            this.tabPage1.Controls.Add(this.lblSysPressureMin);
            this.tabPage1.Controls.Add(this.lblHRMin);
            this.tabPage1.Controls.Add(this.lblSystolic);
            this.tabPage1.Controls.Add(this.lblHeart);
            this.tabPage1.Controls.Add(this.lblTemp);
            this.tabPage1.Controls.Add(this.lblDiastolic);
            this.tabPage1.Controls.Add(this.lblBreath);
            this.tabPage1.Controls.Add(this.tbrTempMin);
            this.tabPage1.Controls.Add(this.tbrSysPressureMin);
            this.tabPage1.Controls.Add(this.tbrHRMin);
            this.tabPage1.Controls.Add(this.tbrBRMin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(443, 139);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Minimum";
            // 
            // lblBRMin
            // 
            this.lblBRMin.AutoSize = true;
            this.lblBRMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBRMin.Location = new System.Drawing.Point(407, 32);
            this.lblBRMin.Name = "lblBRMin";
            this.lblBRMin.Size = new System.Drawing.Size(21, 13);
            this.lblBRMin.TabIndex = 16;
            this.lblBRMin.Text = "15";
            // 
            // lblTempMin
            // 
            this.lblTempMin.AutoSize = true;
            this.lblTempMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempMin.Location = new System.Drawing.Point(264, 30);
            this.lblTempMin.Name = "lblTempMin";
            this.lblTempMin.Size = new System.Drawing.Size(21, 13);
            this.lblTempMin.TabIndex = 15;
            this.lblTempMin.Text = "35";
            // 
            // tbrDiaPressureMin
            // 
            this.tbrDiaPressureMin.Location = new System.Drawing.Point(231, 88);
            this.tbrDiaPressureMin.Maximum = 100;
            this.tbrDiaPressureMin.Minimum = 40;
            this.tbrDiaPressureMin.Name = "tbrDiaPressureMin";
            this.tbrDiaPressureMin.Size = new System.Drawing.Size(176, 45);
            this.tbrDiaPressureMin.TabIndex = 2;
            this.tbrDiaPressureMin.TickFrequency = 10;
            this.tbrDiaPressureMin.Value = 50;
            this.tbrDiaPressureMin.ValueChanged += new System.EventHandler(this.tbrDiaPressureMin_OnValueChanged);
            // 
            // lblDiaPressureMin
            // 
            this.lblDiaPressureMin.AutoSize = true;
            this.lblDiaPressureMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaPressureMin.Location = new System.Drawing.Point(413, 88);
            this.lblDiaPressureMin.Name = "lblDiaPressureMin";
            this.lblDiaPressureMin.Size = new System.Drawing.Size(21, 13);
            this.lblDiaPressureMin.TabIndex = 14;
            this.lblDiaPressureMin.Text = "50";
            // 
            // lblSysPressureMin
            // 
            this.lblSysPressureMin.AutoSize = true;
            this.lblSysPressureMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysPressureMin.Location = new System.Drawing.Point(194, 89);
            this.lblSysPressureMin.Name = "lblSysPressureMin";
            this.lblSysPressureMin.Size = new System.Drawing.Size(21, 13);
            this.lblSysPressureMin.TabIndex = 13;
            this.lblSysPressureMin.Text = "80";
            // 
            // lblHRMin
            // 
            this.lblHRMin.AutoSize = true;
            this.lblHRMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRMin.Location = new System.Drawing.Point(115, 32);
            this.lblHRMin.Name = "lblHRMin";
            this.lblHRMin.Size = new System.Drawing.Size(21, 13);
            this.lblHRMin.TabIndex = 12;
            this.lblHRMin.Text = "50";
            // 
            // lblSystolic
            // 
            this.lblSystolic.AutoSize = true;
            this.lblSystolic.Location = new System.Drawing.Point(47, 73);
            this.lblSystolic.Name = "lblSystolic";
            this.lblSystolic.Size = new System.Drawing.Size(87, 13);
            this.lblSystolic.TabIndex = 11;
            this.lblSystolic.Text = "Systolic Pressure";
            // 
            // lblHeart
            // 
            this.lblHeart.AutoSize = true;
            this.lblHeart.Location = new System.Drawing.Point(29, 16);
            this.lblHeart.Name = "lblHeart";
            this.lblHeart.Size = new System.Drawing.Size(59, 13);
            this.lblHeart.TabIndex = 10;
            this.lblHeart.Text = "Pulse Rate";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(172, 15);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(67, 13);
            this.lblTemp.TabIndex = 9;
            this.lblTemp.Text = "Temperature";
            // 
            // lblDiastolic
            // 
            this.lblDiastolic.AutoSize = true;
            this.lblDiastolic.Location = new System.Drawing.Point(283, 73);
            this.lblDiastolic.Name = "lblDiastolic";
            this.lblDiastolic.Size = new System.Drawing.Size(91, 13);
            this.lblDiastolic.TabIndex = 8;
            this.lblDiastolic.Text = "Diastolic Pressure";
            // 
            // lblBreath
            // 
            this.lblBreath.AutoSize = true;
            this.lblBreath.Location = new System.Drawing.Point(311, 15);
            this.lblBreath.Name = "lblBreath";
            this.lblBreath.Size = new System.Drawing.Size(78, 13);
            this.lblBreath.TabIndex = 6;
            this.lblBreath.Text = "Breathing Rate";
            // 
            // tbrTempMin
            // 
            this.tbrTempMin.Location = new System.Drawing.Point(153, 31);
            this.tbrTempMin.Maximum = 45;
            this.tbrTempMin.Minimum = 25;
            this.tbrTempMin.Name = "tbrTempMin";
            this.tbrTempMin.Size = new System.Drawing.Size(104, 45);
            this.tbrTempMin.TabIndex = 4;
            this.tbrTempMin.Value = 35;
            this.tbrTempMin.ValueChanged += new System.EventHandler(this.tbrTempMin_OnValueChanged);
            // 
            // tbrSysPressureMin
            // 
            this.tbrSysPressureMin.Location = new System.Drawing.Point(4, 89);
            this.tbrSysPressureMin.Maximum = 190;
            this.tbrSysPressureMin.Minimum = 70;
            this.tbrSysPressureMin.Name = "tbrSysPressureMin";
            this.tbrSysPressureMin.Size = new System.Drawing.Size(184, 45);
            this.tbrSysPressureMin.TabIndex = 3;
            this.tbrSysPressureMin.TickFrequency = 10;
            this.tbrSysPressureMin.Value = 80;
            this.tbrSysPressureMin.ValueChanged += new System.EventHandler(this.tbrSysPressureMin_OnValueChanged);
            // 
            // tbrHRMin
            // 
            this.tbrHRMin.Location = new System.Drawing.Point(4, 32);
            this.tbrHRMin.Maximum = 180;
            this.tbrHRMin.Minimum = 30;
            this.tbrHRMin.Name = "tbrHRMin";
            this.tbrHRMin.Size = new System.Drawing.Size(105, 45);
            this.tbrHRMin.TabIndex = 1;
            this.tbrHRMin.TickFrequency = 10;
            this.tbrHRMin.Value = 50;
            this.tbrHRMin.ValueChanged += new System.EventHandler(this.tbrHRMin_OnValueChanged);
            // 
            // tbrBRMin
            // 
            this.tbrBRMin.Location = new System.Drawing.Point(296, 32);
            this.tbrBRMin.Maximum = 60;
            this.tbrBRMin.Minimum = 10;
            this.tbrBRMin.Name = "tbrBRMin";
            this.tbrBRMin.Size = new System.Drawing.Size(104, 45);
            this.tbrBRMin.TabIndex = 0;
            this.tbrBRMin.TickFrequency = 5;
            this.tbrBRMin.Value = 15;
            this.tbrBRMin.ValueChanged += new System.EventHandler(this.tbrBRMin_OnValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.lblBRMax);
            this.tabPage2.Controls.Add(this.tbrDiaPressureMax);
            this.tabPage2.Controls.Add(this.lblTempMax);
            this.tabPage2.Controls.Add(this.lblDiaPressureMax);
            this.tabPage2.Controls.Add(this.tbrSysPressureMax);
            this.tabPage2.Controls.Add(this.lblSysPressureMax);
            this.tabPage2.Controls.Add(this.tbrTempMax);
            this.tabPage2.Controls.Add(this.lblHRMax);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.tbrHRMax);
            this.tabPage2.Controls.Add(this.tbrBRMax);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(443, 139);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Maximum";
            // 
            // lblBRMax
            // 
            this.lblBRMax.AutoSize = true;
            this.lblBRMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBRMax.Location = new System.Drawing.Point(407, 32);
            this.lblBRMax.Name = "lblBRMax";
            this.lblBRMax.Size = new System.Drawing.Size(21, 13);
            this.lblBRMax.TabIndex = 31;
            this.lblBRMax.Text = "30";
            // 
            // tbrDiaPressureMax
            // 
            this.tbrDiaPressureMax.Location = new System.Drawing.Point(231, 88);
            this.tbrDiaPressureMax.Maximum = 100;
            this.tbrDiaPressureMax.Minimum = 40;
            this.tbrDiaPressureMax.Name = "tbrDiaPressureMax";
            this.tbrDiaPressureMax.Size = new System.Drawing.Size(176, 45);
            this.tbrDiaPressureMax.TabIndex = 19;
            this.tbrDiaPressureMax.TickFrequency = 10;
            this.tbrDiaPressureMax.Value = 80;
            this.tbrDiaPressureMax.ValueChanged += new System.EventHandler(this.tbrDiaPressureMax_OnValueChanged);
            // 
            // lblTempMax
            // 
            this.lblTempMax.AutoSize = true;
            this.lblTempMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempMax.Location = new System.Drawing.Point(264, 30);
            this.lblTempMax.Name = "lblTempMax";
            this.lblTempMax.Size = new System.Drawing.Size(21, 13);
            this.lblTempMax.TabIndex = 30;
            this.lblTempMax.Text = "40";
            // 
            // lblDiaPressureMax
            // 
            this.lblDiaPressureMax.AutoSize = true;
            this.lblDiaPressureMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaPressureMax.Location = new System.Drawing.Point(413, 88);
            this.lblDiaPressureMax.Name = "lblDiaPressureMax";
            this.lblDiaPressureMax.Size = new System.Drawing.Size(21, 13);
            this.lblDiaPressureMax.TabIndex = 29;
            this.lblDiaPressureMax.Text = "80";
            // 
            // tbrSysPressureMax
            // 
            this.tbrSysPressureMax.Location = new System.Drawing.Point(4, 89);
            this.tbrSysPressureMax.Maximum = 190;
            this.tbrSysPressureMax.Minimum = 70;
            this.tbrSysPressureMax.Name = "tbrSysPressureMax";
            this.tbrSysPressureMax.Size = new System.Drawing.Size(184, 45);
            this.tbrSysPressureMax.TabIndex = 20;
            this.tbrSysPressureMax.TickFrequency = 10;
            this.tbrSysPressureMax.Value = 150;
            this.tbrSysPressureMax.ValueChanged += new System.EventHandler(this.tbrSysPressureMax_OnValueChanged);
            // 
            // lblSysPressureMax
            // 
            this.lblSysPressureMax.AutoSize = true;
            this.lblSysPressureMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysPressureMax.Location = new System.Drawing.Point(191, 89);
            this.lblSysPressureMax.Name = "lblSysPressureMax";
            this.lblSysPressureMax.Size = new System.Drawing.Size(28, 13);
            this.lblSysPressureMax.TabIndex = 28;
            this.lblSysPressureMax.Text = "150";
            // 
            // tbrTempMax
            // 
            this.tbrTempMax.Location = new System.Drawing.Point(153, 31);
            this.tbrTempMax.Maximum = 45;
            this.tbrTempMax.Minimum = 25;
            this.tbrTempMax.Name = "tbrTempMax";
            this.tbrTempMax.Size = new System.Drawing.Size(104, 45);
            this.tbrTempMax.TabIndex = 21;
            this.tbrTempMax.Value = 40;
            this.tbrTempMax.ValueChanged += new System.EventHandler(this.tbrTempMax_OnValueChanged);
            // 
            // lblHRMax
            // 
            this.lblHRMax.AutoSize = true;
            this.lblHRMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHRMax.Location = new System.Drawing.Point(115, 32);
            this.lblHRMax.Name = "lblHRMax";
            this.lblHRMax.Size = new System.Drawing.Size(28, 13);
            this.lblHRMax.TabIndex = 27;
            this.lblHRMax.Text = "140";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(311, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Breathing Rate";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(47, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Systolic Pressure";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(283, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Diastolic Pressure";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Pulse Rate";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(172, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Temperature";
            // 
            // tbrHRMax
            // 
            this.tbrHRMax.Location = new System.Drawing.Point(4, 32);
            this.tbrHRMax.Maximum = 180;
            this.tbrHRMax.Minimum = 30;
            this.tbrHRMax.Name = "tbrHRMax";
            this.tbrHRMax.Size = new System.Drawing.Size(105, 45);
            this.tbrHRMax.TabIndex = 18;
            this.tbrHRMax.TickFrequency = 10;
            this.tbrHRMax.Value = 140;
            this.tbrHRMax.ValueChanged += new System.EventHandler(this.tbrHRMax_OnValueChanged);
            // 
            // tbrBRMax
            // 
            this.tbrBRMax.Location = new System.Drawing.Point(296, 32);
            this.tbrBRMax.Maximum = 60;
            this.tbrBRMax.Minimum = 10;
            this.tbrBRMax.Name = "tbrBRMax";
            this.tbrBRMax.Size = new System.Drawing.Size(104, 45);
            this.tbrBRMax.TabIndex = 17;
            this.tbrBRMax.TickFrequency = 5;
            this.tbrBRMax.Value = 30;
            this.tbrBRMax.ValueChanged += new System.EventHandler(this.tbrBRMax_OnValueChanged);
            // 
            // gbxMonitor
            // 
            this.gbxMonitor.Controls.Add(this.lblDiaPressure);
            this.gbxMonitor.Controls.Add(this.label5);
            this.gbxMonitor.Controls.Add(this.label3);
            this.gbxMonitor.Controls.Add(this.label1);
            this.gbxMonitor.Controls.Add(this.heartRate);
            this.gbxMonitor.Controls.Add(this.breathingRate);
            this.gbxMonitor.Controls.Add(this.bloodPressure);
            this.gbxMonitor.Controls.Add(this.temperature);
            this.gbxMonitor.Controls.Add(this.label2);
            this.gbxMonitor.Controls.Add(this.label4);
            this.gbxMonitor.Location = new System.Drawing.Point(10, 45);
            this.gbxMonitor.Name = "gbxMonitor";
            this.gbxMonitor.Size = new System.Drawing.Size(463, 199);
            this.gbxMonitor.TabIndex = 6;
            this.gbxMonitor.TabStop = false;
            this.gbxMonitor.Text = "Current Patient Vitals";
            // 
            // lblDiaPressure
            // 
            this.lblDiaPressure.AutoSize = true;
            this.lblDiaPressure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaPressure.Location = new System.Drawing.Point(303, 153);
            this.lblDiaPressure.Name = "lblDiaPressure";
            this.lblDiaPressure.Size = new System.Drawing.Size(23, 18);
            this.lblDiaPressure.TabIndex = 3;
            this.lblDiaPressure.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(243, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Diastolic Pressure";
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Location = new System.Drawing.Point(17, 15);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(29, 13);
            this.lblBed.TabIndex = 7;
            this.lblBed.Text = "Bed:";
            // 
            // btnOptions
            // 
            this.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptions.Location = new System.Drawing.Point(10, 472);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 23);
            this.btnOptions.TabIndex = 8;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // lblNurse
            // 
            this.lblNurse.AutoSize = true;
            this.lblNurse.Location = new System.Drawing.Point(334, 20);
            this.lblNurse.Name = "lblNurse";
            this.lblNurse.Size = new System.Drawing.Size(75, 13);
            this.lblNurse.TabIndex = 9;
            this.lblNurse.Text = "Current Nurse:";
            // 
            // lblNurseName
            // 
            this.lblNurseName.AutoSize = true;
            this.lblNurseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNurseName.Location = new System.Drawing.Point(412, 20);
            this.lblNurseName.Name = "lblNurseName";
            this.lblNurseName.Size = new System.Drawing.Size(42, 13);
            this.lblNurseName.TabIndex = 10;
            this.lblNurseName.Text = "NAME";
            // 
            // btnStation
            // 
            this.btnStation.Location = new System.Drawing.Point(193, 10);
            this.btnStation.Name = "btnStation";
            this.btnStation.Size = new System.Drawing.Size(103, 23);
            this.btnStation.TabIndex = 11;
            this.btnStation.Text = "Central Station";
            this.btnStation.UseVisualStyleBackColor = true;
            this.btnStation.Click += new System.EventHandler(this.btnStation_Click);
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 503);
            this.Controls.Add(this.btnStation);
            this.Controls.Add(this.lblNurseName);
            this.Controls.Add(this.lblNurse);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lblBed);
            this.Controls.Add(this.gbxMonitor);
            this.Controls.Add(this.gbxThresholds);
            this.Controls.Add(this.cbxBed);
            this.Controls.Add(this.Btn_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Monitor";
            this.Text = "Monitor Beds";
            this.Click += new System.EventHandler(this.btnSet_Click);
            this.gbxThresholds.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrDiaPressureMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrTempMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSysPressureMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHRMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBRMin)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrDiaPressureMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSysPressureMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrTempMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHRMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBRMax)).EndInit();
            this.gbxMonitor.ResumeLayout(false);
            this.gbxMonitor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label heartRate;
        private System.Windows.Forms.Label breathingRate;
        private System.Windows.Forms.Label bloodPressure;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.ComboBox cbxBed;
        private System.Windows.Forms.Button Btn_close;
        private System.Windows.Forms.GroupBox gbxThresholds;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblSystolic;
        private System.Windows.Forms.Label lblHeart;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblDiastolic;
        private System.Windows.Forms.Label lblBreath;
        private System.Windows.Forms.TrackBar tbrTempMin;
        private System.Windows.Forms.TrackBar tbrSysPressureMin;
        private System.Windows.Forms.TrackBar tbrHRMin;
        private System.Windows.Forms.TrackBar tbrBRMin;
        private System.Windows.Forms.TrackBar tbrDiaPressureMin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbxMonitor;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.ToolTip tipThresholds;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Label lblBRMin;
        private System.Windows.Forms.Label lblTempMin;
        private System.Windows.Forms.Label lblDiaPressureMin;
        private System.Windows.Forms.Label lblSysPressureMin;
        private System.Windows.Forms.Label lblHRMin;
        private System.Windows.Forms.Label lblBRMax;
        private System.Windows.Forms.TrackBar tbrDiaPressureMax;
        private System.Windows.Forms.Label lblTempMax;
        private System.Windows.Forms.Label lblDiaPressureMax;
        private System.Windows.Forms.TrackBar tbrSysPressureMax;
        private System.Windows.Forms.Label lblSysPressureMax;
        private System.Windows.Forms.TrackBar tbrTempMax;
        private System.Windows.Forms.Label lblHRMax;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar tbrHRMax;
        private System.Windows.Forms.TrackBar tbrBRMax;
        private System.Windows.Forms.Label lblDiaPressure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label lblNurse;
        private System.Windows.Forms.Label lblNurseName;
        private System.Windows.Forms.Button btnStation;
    }
}