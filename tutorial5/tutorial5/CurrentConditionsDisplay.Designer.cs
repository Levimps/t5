﻿namespace tutorial5
{
    partial class CurrentConditionsDisplay
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbltemp = new System.Windows.Forms.Label();
            this.lblhumidity = new System.Windows.Forms.Label();
            this.lblpressure = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUnsubscribe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CurrentConditions";
            // 
            // lbltemp
            // 
            this.lbltemp.AutoSize = true;
            this.lbltemp.Location = new System.Drawing.Point(185, 135);
            this.lbltemp.Name = "lbltemp";
            this.lbltemp.Size = new System.Drawing.Size(44, 18);
            this.lbltemp.TabIndex = 1;
            this.lbltemp.Text = "Temp";
            // 
            // lblhumidity
            // 
            this.lblhumidity.AutoSize = true;
            this.lblhumidity.Location = new System.Drawing.Point(185, 199);
            this.lblhumidity.Name = "lblhumidity";
            this.lblhumidity.Size = new System.Drawing.Size(80, 18);
            this.lblhumidity.TabIndex = 2;
            this.lblhumidity.Text = "Humidity";
            // 
            // lblpressure
            // 
            this.lblpressure.AutoSize = true;
            this.lblpressure.Location = new System.Drawing.Point(185, 265);
            this.lblpressure.Name = "lblpressure";
            this.lblpressure.Size = new System.Drawing.Size(80, 18);
            this.lblpressure.TabIndex = 3;
            this.lblpressure.Text = "Pressure";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(324, 339);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(84, 37);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUnsubscribe
            // 
            this.btnUnsubscribe.Location = new System.Drawing.Point(303, 397);
            this.btnUnsubscribe.Name = "btnUnsubscribe";
            this.btnUnsubscribe.Size = new System.Drawing.Size(139, 41);
            this.btnUnsubscribe.TabIndex = 5;
            this.btnUnsubscribe.Text = "DeRegister";
            this.btnUnsubscribe.UseVisualStyleBackColor = true;
            this.btnUnsubscribe.Click += new System.EventHandler(this.btnUnsubscribe_Click);
            // 
            // CurrentConditionsDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUnsubscribe);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblpressure);
            this.Controls.Add(this.lblhumidity);
            this.Controls.Add(this.lbltemp);
            this.Controls.Add(this.label1);
            this.Name = "CurrentConditionsDisplay";
            this.Text = "CurrentConditionsDisplay";
            this.Load += new System.EventHandler(this.CurrentConditionsDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltemp;
        private System.Windows.Forms.Label lblhumidity;
        private System.Windows.Forms.Label lblpressure;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUnsubscribe;
    }
}