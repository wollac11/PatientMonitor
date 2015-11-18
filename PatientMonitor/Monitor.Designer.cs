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
            this.btn_Set = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pulseRate_Min = new System.Windows.Forms.TextBox();
            this.pulseRate_Max = new System.Windows.Forms.TextBox();
            this.breathingRate_Min = new System.Windows.Forms.TextBox();
            this.breathingRate_Max = new System.Windows.Forms.TextBox();
            this.bloodPressure_Min = new System.Windows.Forms.TextBox();
            this.bloodPressure_Max = new System.Windows.Forms.TextBox();
            this.temperature_Min = new System.Windows.Forms.TextBox();
            this.temperature_Max = new System.Windows.Forms.TextBox();
            this.pulseRate = new System.Windows.Forms.Label();
            this.breathingRate = new System.Windows.Forms.Label();
            this.bloodPressure = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Set
            // 
            this.btn_Set.Location = new System.Drawing.Point(406, 161);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(75, 23);
            this.btn_Set.TabIndex = 0;
            this.btn_Set.Text = "Apply";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pulse Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Breathing Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Blood Pressure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Temperature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Max";
            // 
            // pulseRate_Min
            // 
            this.pulseRate_Min.Location = new System.Drawing.Point(239, 53);
            this.pulseRate_Min.Name = "pulseRate_Min";
            this.pulseRate_Min.Size = new System.Drawing.Size(60, 20);
            this.pulseRate_Min.TabIndex = 3;
            this.pulseRate_Min.Text = "0";
            this.pulseRate_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pulseRate_Max
            // 
            this.pulseRate_Max.Location = new System.Drawing.Point(320, 53);
            this.pulseRate_Max.Name = "pulseRate_Max";
            this.pulseRate_Max.Size = new System.Drawing.Size(60, 20);
            this.pulseRate_Max.TabIndex = 3;
            this.pulseRate_Max.Text = "0";
            this.pulseRate_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // breathingRate_Min
            // 
            this.breathingRate_Min.Location = new System.Drawing.Point(239, 98);
            this.breathingRate_Min.Name = "breathingRate_Min";
            this.breathingRate_Min.Size = new System.Drawing.Size(60, 20);
            this.breathingRate_Min.TabIndex = 3;
            this.breathingRate_Min.Text = "0";
            this.breathingRate_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // breathingRate_Max
            // 
            this.breathingRate_Max.Location = new System.Drawing.Point(320, 98);
            this.breathingRate_Max.Name = "breathingRate_Max";
            this.breathingRate_Max.Size = new System.Drawing.Size(60, 20);
            this.breathingRate_Max.TabIndex = 3;
            this.breathingRate_Max.Text = "0";
            this.breathingRate_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bloodPressure_Min
            // 
            this.bloodPressure_Min.Location = new System.Drawing.Point(239, 145);
            this.bloodPressure_Min.Name = "bloodPressure_Min";
            this.bloodPressure_Min.Size = new System.Drawing.Size(60, 20);
            this.bloodPressure_Min.TabIndex = 3;
            this.bloodPressure_Min.Text = "0";
            this.bloodPressure_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bloodPressure_Max
            // 
            this.bloodPressure_Max.Location = new System.Drawing.Point(320, 145);
            this.bloodPressure_Max.Name = "bloodPressure_Max";
            this.bloodPressure_Max.Size = new System.Drawing.Size(60, 20);
            this.bloodPressure_Max.TabIndex = 3;
            this.bloodPressure_Max.Text = "0";
            this.bloodPressure_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // temperature_Min
            // 
            this.temperature_Min.Location = new System.Drawing.Point(239, 194);
            this.temperature_Min.Name = "temperature_Min";
            this.temperature_Min.Size = new System.Drawing.Size(60, 20);
            this.temperature_Min.TabIndex = 3;
            this.temperature_Min.Text = "0";
            this.temperature_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // temperature_Max
            // 
            this.temperature_Max.Location = new System.Drawing.Point(320, 194);
            this.temperature_Max.Name = "temperature_Max";
            this.temperature_Max.Size = new System.Drawing.Size(60, 20);
            this.temperature_Max.TabIndex = 3;
            this.temperature_Max.Text = "0";
            this.temperature_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pulseRate
            // 
            this.pulseRate.AutoSize = true;
            this.pulseRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseRate.Location = new System.Drawing.Point(149, 53);
            this.pulseRate.Name = "pulseRate";
            this.pulseRate.Size = new System.Drawing.Size(35, 18);
            this.pulseRate.TabIndex = 1;
            this.pulseRate.Text = "100";
            // 
            // breathingRate
            // 
            this.breathingRate.AutoSize = true;
            this.breathingRate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breathingRate.Location = new System.Drawing.Point(149, 97);
            this.breathingRate.Name = "breathingRate";
            this.breathingRate.Size = new System.Drawing.Size(35, 18);
            this.breathingRate.TabIndex = 1;
            this.breathingRate.Text = "100";
            // 
            // bloodPressure
            // 
            this.bloodPressure.AutoSize = true;
            this.bloodPressure.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodPressure.Location = new System.Drawing.Point(149, 144);
            this.bloodPressure.Name = "bloodPressure";
            this.bloodPressure.Size = new System.Drawing.Size(35, 18);
            this.bloodPressure.TabIndex = 1;
            this.bloodPressure.Text = "100";
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature.Location = new System.Drawing.Point(149, 191);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(35, 18);
            this.temperature.TabIndex = 1;
            this.temperature.Text = "100";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bed 2",
            "Bed 3",
            "Bed 4",
            "Bed 5",
            "Bed 6",
            "Bed 7",
            "Bed 8",
            "Bed 9"});
            this.comboBox1.Location = new System.Drawing.Point(13, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Bed 1";
            // 
            // Btn_close
            // 
            this.Btn_close.Location = new System.Drawing.Point(406, 190);
            this.Btn_close.Name = "Btn_close";
            this.Btn_close.Size = new System.Drawing.Size(75, 23);
            this.Btn_close.TabIndex = 0;
            this.Btn_close.Text = "Close";
            this.Btn_close.UseVisualStyleBackColor = true;
            this.Btn_close.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 227);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.temperature_Max);
            this.Controls.Add(this.bloodPressure_Max);
            this.Controls.Add(this.breathingRate_Max);
            this.Controls.Add(this.temperature_Min);
            this.Controls.Add(this.bloodPressure_Min);
            this.Controls.Add(this.breathingRate_Min);
            this.Controls.Add(this.pulseRate_Max);
            this.Controls.Add(this.pulseRate_Min);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.bloodPressure);
            this.Controls.Add(this.breathingRate);
            this.Controls.Add(this.pulseRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_close);
            this.Controls.Add(this.btn_Set);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Monitor";
            this.Text = "PatientMonitor";
            this.Click += new System.EventHandler(this.btn_Set_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pulseRate_Min;
        private System.Windows.Forms.TextBox pulseRate_Max;
        private System.Windows.Forms.TextBox breathingRate_Min;
        private System.Windows.Forms.TextBox breathingRate_Max;
        private System.Windows.Forms.TextBox bloodPressure_Min;
        private System.Windows.Forms.TextBox bloodPressure_Max;
        private System.Windows.Forms.TextBox temperature_Min;
        private System.Windows.Forms.TextBox temperature_Max;
        private System.Windows.Forms.Label pulseRate;
        private System.Windows.Forms.Label breathingRate;
        private System.Windows.Forms.Label bloodPressure;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btn_close;
    }
}