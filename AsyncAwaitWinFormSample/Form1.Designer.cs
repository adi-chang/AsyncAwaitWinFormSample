﻿namespace AsyncAwaitWinFormSample
{
    partial class Form1
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
            this.btnClickMe = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickMe.Location = new System.Drawing.Point(12, 12);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(100, 30);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Click Me !!!";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 62);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(90, 31);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "{ info }";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 119);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnClickMe);
            this.Name = "Form1";
            this.Text = "Async Await Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label lblInfo;
    }
}
