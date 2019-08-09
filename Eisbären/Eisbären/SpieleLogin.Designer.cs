namespace Eisbären
{
    partial class SpieleLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVornameSpiel = new System.Windows.Forms.TextBox();
            this.textBoxNachnameSpiel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nachname";
            // 
            // textBoxVornameSpiel
            // 
            this.textBoxVornameSpiel.Location = new System.Drawing.Point(93, 31);
            this.textBoxVornameSpiel.Name = "textBoxVornameSpiel";
            this.textBoxVornameSpiel.Size = new System.Drawing.Size(100, 20);
            this.textBoxVornameSpiel.TabIndex = 2;
            // 
            // textBoxNachnameSpiel
            // 
            this.textBoxNachnameSpiel.Location = new System.Drawing.Point(93, 67);
            this.textBoxNachnameSpiel.Name = "textBoxNachnameSpiel";
            this.textBoxNachnameSpiel.Size = new System.Drawing.Size(100, 20);
            this.textBoxNachnameSpiel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpieleLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNachnameSpiel);
            this.Controls.Add(this.textBoxVornameSpiel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SpieleLogin";
            this.Text = "SpieleLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxVornameSpiel;
        private System.Windows.Forms.TextBox textBoxNachnameSpiel;
        private System.Windows.Forms.Button button1;
    }
}