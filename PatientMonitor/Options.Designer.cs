namespace PatientMonitor
{
    partial class Options
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
            this.btnAbout = new System.Windows.Forms.Button();
            this.gbxModules = new System.Windows.Forms.GroupBox();
            this.cbxBloodPressure = new System.Windows.Forms.CheckBox();
            this.cbxBreath = new System.Windows.Forms.CheckBox();
            this.ckbHeartRate = new System.Windows.Forms.CheckBox();
            this.cbxTemp = new System.Windows.Forms.CheckBox();
            this.tipModules = new System.Windows.Forms.ToolTip(this.components);
            this.gbxModules.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(255, 109);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Okay";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnAbout.Location = new System.Drawing.Point(12, 109);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // gbxModules
            // 
            this.gbxModules.Controls.Add(this.cbxBloodPressure);
            this.gbxModules.Controls.Add(this.cbxBreath);
            this.gbxModules.Controls.Add(this.ckbHeartRate);
            this.gbxModules.Controls.Add(this.cbxTemp);
            this.gbxModules.Location = new System.Drawing.Point(12, 12);
            this.gbxModules.Name = "gbxModules";
            this.gbxModules.Size = new System.Drawing.Size(318, 91);
            this.gbxModules.TabIndex = 2;
            this.gbxModules.TabStop = false;
            this.gbxModules.Text = "Modules";
            this.tipModules.SetToolTip(this.gbxModules, "Allows you to enable/disable monitor modules");
            // 
            // cbxBloodPressure
            // 
            this.cbxBloodPressure.AutoSize = true;
            this.cbxBloodPressure.Checked = true;
            this.cbxBloodPressure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxBloodPressure.Location = new System.Drawing.Point(153, 31);
            this.cbxBloodPressure.Name = "cbxBloodPressure";
            this.cbxBloodPressure.Size = new System.Drawing.Size(97, 17);
            this.cbxBloodPressure.TabIndex = 3;
            this.cbxBloodPressure.Text = "Blood Pressure";
            this.cbxBloodPressure.UseVisualStyleBackColor = true;
            // 
            // cbxBreath
            // 
            this.cbxBreath.AutoSize = true;
            this.cbxBreath.Checked = true;
            this.cbxBreath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxBreath.Location = new System.Drawing.Point(15, 54);
            this.cbxBreath.Name = "cbxBreath";
            this.cbxBreath.Size = new System.Drawing.Size(97, 17);
            this.cbxBreath.TabIndex = 2;
            this.cbxBreath.Text = "Breathing Rate";
            this.cbxBreath.UseVisualStyleBackColor = true;
            // 
            // ckbHeartRate
            // 
            this.ckbHeartRate.AutoSize = true;
            this.ckbHeartRate.Checked = true;
            this.ckbHeartRate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbHeartRate.Location = new System.Drawing.Point(153, 54);
            this.ckbHeartRate.Name = "ckbHeartRate";
            this.ckbHeartRate.Size = new System.Drawing.Size(78, 17);
            this.ckbHeartRate.TabIndex = 1;
            this.ckbHeartRate.Text = "Heart Rate";
            this.ckbHeartRate.UseVisualStyleBackColor = true;
            // 
            // cbxTemp
            // 
            this.cbxTemp.AutoSize = true;
            this.cbxTemp.Checked = true;
            this.cbxTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTemp.Location = new System.Drawing.Point(15, 31);
            this.cbxTemp.Name = "cbxTemp";
            this.cbxTemp.Size = new System.Drawing.Size(86, 17);
            this.cbxTemp.TabIndex = 0;
            this.cbxTemp.Text = "Temperature";
            this.cbxTemp.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 139);
            this.Controls.Add(this.gbxModules);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.gbxModules.ResumeLayout(false);
            this.gbxModules.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.GroupBox gbxModules;
        private System.Windows.Forms.CheckBox cbxBloodPressure;
        private System.Windows.Forms.CheckBox cbxBreath;
        private System.Windows.Forms.CheckBox ckbHeartRate;
        private System.Windows.Forms.CheckBox cbxTemp;
        private System.Windows.Forms.ToolTip tipModules;
    }
}