﻿namespace NoAFK
{
    partial class frmMain
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txtbxTimer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 61);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(260, 64);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(41, 28);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(85, 13);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "Next Movement:";
            // 
            // txtbxTimer
            // 
            this.txtbxTimer.Location = new System.Drawing.Point(132, 25);
            this.txtbxTimer.Name = "txtbxTimer";
            this.txtbxTimer.ReadOnly = true;
            this.txtbxTimer.Size = new System.Drawing.Size(100, 20);
            this.txtbxTimer.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.txtbxTimer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Suck it Queue Times!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txtbxTimer;
    }
}

