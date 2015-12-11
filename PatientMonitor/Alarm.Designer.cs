namespace PatientMonitor
{
    partial class Alarm
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
            this.tmrAboveLimit = new System.Windows.Forms.Timer(this.components);
            this.lblCounterAbove = new System.Windows.Forms.Label();
            this.btnDisableAbove = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnMute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrAboveLimit
            // 
            this.tmrAboveLimit.Enabled = true;
            this.tmrAboveLimit.Interval = 1000;
            this.tmrAboveLimit.Tick += new System.EventHandler(this.tmrAboveLimit_Tick);
            // 
            // lblCounterAbove
            // 
            this.lblCounterAbove.AutoSize = true;
            this.lblCounterAbove.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounterAbove.Location = new System.Drawing.Point(89, 9);
            this.lblCounterAbove.Name = "lblCounterAbove";
            this.lblCounterAbove.Size = new System.Drawing.Size(31, 33);
            this.lblCounterAbove.TabIndex = 0;
            this.lblCounterAbove.Text = "0";
            // 
            // btnDisableAbove
            // 
            this.btnDisableAbove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableAbove.Location = new System.Drawing.Point(185, 50);
            this.btnDisableAbove.Name = "btnDisableAbove";
            this.btnDisableAbove.Size = new System.Drawing.Size(122, 33);
            this.btnDisableAbove.TabIndex = 1;
            this.btnDisableAbove.Text = "Response Given";
            this.btnDisableAbove.UseVisualStyleBackColor = true;
            this.btnDisableAbove.Click += new System.EventHandler(this.btnDisableAbove_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PatientMonitor.Properties.Resources.Warning;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Patient Is Above Thresholds!";
            this.notifyIcon1.BalloonTipTitle = "Warning!";
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnMute
            // 
            this.btnMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMute.Location = new System.Drawing.Point(55, 50);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(110, 33);
            this.btnMute.TabIndex = 3;
            this.btnMute.Text = "Mute Alarm";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // Alarm
            // 
            this.AcceptButton = this.btnDisableAbove;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 95);
            this.ControlBox = false;
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDisableAbove);
            this.Controls.Add(this.lblCounterAbove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alarm";
            this.Text = "Patient Above Limit!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrAboveLimit;
        private System.Windows.Forms.Label lblCounterAbove;
        private System.Windows.Forms.Button btnDisableAbove;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnMute;
    }
}