namespace PatientMonitor
{
    partial class AlarmBelow
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
            this.tmrBelowLimit = new System.Windows.Forms.Timer(this.components);
            this.lblCounterBelow = new System.Windows.Forms.Label();
            this.btnDisableBelow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrBelowLimit
            // 
            this.tmrBelowLimit.Enabled = true;
            this.tmrBelowLimit.Interval = 1000;
            this.tmrBelowLimit.Tick += new System.EventHandler(this.tmrBelowLimit_Tick);
            // 
            // lblCounterBelow
            // 
            this.lblCounterBelow.AutoSize = true;
            this.lblCounterBelow.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounterBelow.Location = new System.Drawing.Point(52, 9);
            this.lblCounterBelow.Name = "lblCounterBelow";
            this.lblCounterBelow.Size = new System.Drawing.Size(31, 33);
            this.lblCounterBelow.TabIndex = 0;
            this.lblCounterBelow.Text = "0";
            // 
            // btnDisableBelow
            // 
            this.btnDisableBelow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableBelow.Location = new System.Drawing.Point(242, 9);
            this.btnDisableBelow.Name = "btnDisableBelow";
            this.btnDisableBelow.Size = new System.Drawing.Size(75, 33);
            this.btnDisableBelow.TabIndex = 1;
            this.btnDisableBelow.Text = "Disable";
            this.btnDisableBelow.UseVisualStyleBackColor = true;
            this.btnDisableBelow.Click += new System.EventHandler(this.btnDisableBelow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PatientMonitor.Properties.Resources.Warning;
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Patient Is Below Thresholds!";
            this.notifyIcon1.BalloonTipTitle = "Warning!";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // AlarmBelow
            // 
            this.AcceptButton = this.btnDisableBelow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 51);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDisableBelow);
            this.Controls.Add(this.lblCounterBelow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlarmBelow";
            this.Text = "Patient Below Limit!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrBelowLimit;
        private System.Windows.Forms.Label lblCounterBelow;
        private System.Windows.Forms.Button btnDisableBelow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}