namespace _2forms
{
    partial class Formlogin
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxbenutzer = new System.Windows.Forms.TextBox();
            this.textBoxpasswort = new System.Windows.Forms.TextBox();
            this.buttongo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benutzer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwort";
            // 
            // textBoxbenutzer
            // 
            this.textBoxbenutzer.Location = new System.Drawing.Point(205, 64);
            this.textBoxbenutzer.Name = "textBoxbenutzer";
            this.textBoxbenutzer.Size = new System.Drawing.Size(155, 20);
            this.textBoxbenutzer.TabIndex = 2;
            // 
            // textBoxpasswort
            // 
            this.textBoxpasswort.Location = new System.Drawing.Point(205, 169);
            this.textBoxpasswort.Name = "textBoxpasswort";
            this.textBoxpasswort.Size = new System.Drawing.Size(155, 20);
            this.textBoxpasswort.TabIndex = 3;
            // 
            // buttongo
            // 
            this.buttongo.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttongo.Location = new System.Drawing.Point(185, 276);
            this.buttongo.Name = "buttongo";
            this.buttongo.Size = new System.Drawing.Size(175, 36);
            this.buttongo.TabIndex = 4;
            this.buttongo.Text = "Anmelden";
            this.buttongo.UseVisualStyleBackColor = true;
            this.buttongo.Click += new System.EventHandler(this.buttongo_Click);
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 502);
            this.Controls.Add(this.buttongo);
            this.Controls.Add(this.textBoxpasswort);
            this.Controls.Add(this.textBoxbenutzer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formlogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxbenutzer;
        private System.Windows.Forms.TextBox textBoxpasswort;
        private System.Windows.Forms.Button buttongo;
    }
}

