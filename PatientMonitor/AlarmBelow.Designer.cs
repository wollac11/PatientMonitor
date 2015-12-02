﻿namespace PatientMonitor
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
            this.lblCounterBelow.Location = new System.Drawing.Point(12, 9);
            this.lblCounterBelow.Name = "lblCounterBelow";
            this.lblCounterBelow.Size = new System.Drawing.Size(31, 33);
            this.lblCounterBelow.TabIndex = 0;
            this.lblCounterBelow.Text = "0";
            // 
            // btnDisableBelow
            // 
            this.btnDisableBelow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableBelow.Location = new System.Drawing.Point(197, 9);
            this.btnDisableBelow.Name = "btnDisableBelow";
            this.btnDisableBelow.Size = new System.Drawing.Size(75, 33);
            this.btnDisableBelow.TabIndex = 1;
            this.btnDisableBelow.Text = "Disable";
            this.btnDisableBelow.UseVisualStyleBackColor = true;
            this.btnDisableBelow.Click += new System.EventHandler(this.btnDisableBelow_Click);
            // 
            // AlarmBelow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 51);
            this.Controls.Add(this.btnDisableBelow);
            this.Controls.Add(this.lblCounterBelow);
            this.Name = "AlarmBelow";
            this.Text = "Patient Below Limit!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrBelowLimit;
        private System.Windows.Forms.Label lblCounterBelow;
        private System.Windows.Forms.Button btnDisableBelow;
    }
}