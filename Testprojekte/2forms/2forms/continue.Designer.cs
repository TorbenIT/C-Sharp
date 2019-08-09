namespace _2forms
{
    partial class Formcontinue
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
            this.buttonred = new System.Windows.Forms.Button();
            this.buttonorange = new System.Windows.Forms.Button();
            this.buttongreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxuser
            // 
            this.textBoxuser.Location = new System.Drawing.Point(197, 28);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(155, 20);
            this.textBoxuser.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Benutzer";
            // 
            // buttonred
            // 
            this.buttonred.Location = new System.Drawing.Point(45, 125);
            this.buttonred.Name = "buttonred";
            this.buttonred.Size = new System.Drawing.Size(107, 29);
            this.buttonred.TabIndex = 5;
            this.buttonred.Text = "Go Red";
            this.buttonred.UseVisualStyleBackColor = true;
            this.buttonred.Click += new System.EventHandler(this.buttonred_Click);
            // 
            // buttonorange
            // 
            this.buttonorange.Location = new System.Drawing.Point(230, 125);
            this.buttonorange.Name = "buttonorange";
            this.buttonorange.Size = new System.Drawing.Size(107, 29);
            this.buttonorange.TabIndex = 6;
            this.buttonorange.Text = "Go Orange";
            this.buttonorange.UseVisualStyleBackColor = true;
            this.buttonorange.Click += new System.EventHandler(this.buttonorange_Click);
            // 
            // buttongreen
            // 
            this.buttongreen.Location = new System.Drawing.Point(404, 125);
            this.buttongreen.Name = "buttongreen";
            this.buttongreen.Size = new System.Drawing.Size(107, 29);
            this.buttongreen.TabIndex = 7;
            this.buttongreen.Text = "Go Green";
            this.buttongreen.UseVisualStyleBackColor = true;
            this.buttongreen.Click += new System.EventHandler(this.buttongreen_Click);
            // 
            // Formcontinue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 262);
            this.Controls.Add(this.buttongreen);
            this.Controls.Add(this.buttonorange);
            this.Controls.Add(this.buttonred);
            this.Controls.Add(this.textBoxuser);
            this.Controls.Add(this.label1);
            this.Name = "Formcontinue";
            this.Text = "@continue";
            this.Load += new System.EventHandler(this.Formcontinue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonred;
        private System.Windows.Forms.Button buttonorange;
        private System.Windows.Forms.Button buttongreen;
    }
}