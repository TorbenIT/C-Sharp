﻿namespace _2forms
{
    partial class FormRed
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
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxuser
            // 
            this.textBoxuser.Location = new System.Drawing.Point(321, 124);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(155, 20);
            this.textBoxuser.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Benutzer";
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(514, 22);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(89, 27);
            this.buttonback.TabIndex = 8;
            this.buttonback.Text = "zurück";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // FormRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(641, 262);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.textBoxuser);
            this.Controls.Add(this.label1);
            this.Name = "FormRed";
            this.Text = "FormRed";
            this.Load += new System.EventHandler(this.FormRed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonback;
    }
}