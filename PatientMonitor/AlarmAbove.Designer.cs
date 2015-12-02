﻿namespace PatientMonitor
{
    partial class AlarmAbove
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
            this.lblCounterAbove.Location = new System.Drawing.Point(12, 9);
            this.lblCounterAbove.Name = "lblCounterAbove";
            this.lblCounterAbove.Size = new System.Drawing.Size(31, 33);
            this.lblCounterAbove.TabIndex = 0;
            this.lblCounterAbove.Text = "0";
            // 
            // btnDisableAbove
            // 
            this.btnDisableAbove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableAbove.Location = new System.Drawing.Point(197, 9);
            this.btnDisableAbove.Name = "btnDisableAbove";
            this.btnDisableAbove.Size = new System.Drawing.Size(75, 33);
            this.btnDisableAbove.TabIndex = 1;
            this.btnDisableAbove.Text = "Disable";
            this.btnDisableAbove.UseVisualStyleBackColor = true;
            this.btnDisableAbove.Click += new System.EventHandler(this.btnDisableAbove_Click);
            // 
            // AlarmAbove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 51);
            this.Controls.Add(this.btnDisableAbove);
            this.Controls.Add(this.lblCounterAbove);
            this.Name = "AlarmAbove";
            this.Text = "Patient Above Limit!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrAboveLimit;
        private System.Windows.Forms.Label lblCounterAbove;
        private System.Windows.Forms.Button btnDisableAbove;
    }
}