namespace Zeiterfassungstool
{
    partial class FormVerwaltung
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
            this.buttonAnzeigen = new System.Windows.Forms.Button();
            this.buttonÄndern = new System.Windows.Forms.Button();
            this.buttonAnlegen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAnzeigen
            // 
            this.buttonAnzeigen.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAnzeigen.FlatAppearance.BorderSize = 0;
            this.buttonAnzeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnzeigen.Location = new System.Drawing.Point(194, 106);
            this.buttonAnzeigen.Name = "buttonAnzeigen";
            this.buttonAnzeigen.Size = new System.Drawing.Size(184, 156);
            this.buttonAnzeigen.TabIndex = 0;
            this.buttonAnzeigen.Text = "Anzeigen";
            this.buttonAnzeigen.UseVisualStyleBackColor = true;
            this.buttonAnzeigen.Click += new System.EventHandler(this.buttonAnzeigen_Click);
            // 
            // buttonÄndern
            // 
            this.buttonÄndern.BackColor = System.Drawing.SystemColors.Control;
            this.buttonÄndern.FlatAppearance.BorderSize = 0;
            this.buttonÄndern.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonÄndern.Location = new System.Drawing.Point(414, 106);
            this.buttonÄndern.Name = "buttonÄndern";
            this.buttonÄndern.Size = new System.Drawing.Size(184, 156);
            this.buttonÄndern.TabIndex = 1;
            this.buttonÄndern.Text = "Ändern";
            this.buttonÄndern.UseVisualStyleBackColor = true;
            this.buttonÄndern.Click += new System.EventHandler(this.buttonÄndern_Click);
            // 
            // buttonAnlegen
            // 
            this.buttonAnlegen.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAnlegen.FlatAppearance.BorderSize = 0;
            this.buttonAnlegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnlegen.Location = new System.Drawing.Point(634, 106);
            this.buttonAnlegen.Name = "buttonAnlegen";
            this.buttonAnlegen.Size = new System.Drawing.Size(184, 156);
            this.buttonAnlegen.TabIndex = 2;
            this.buttonAnlegen.Text = "Anlegen";
            this.buttonAnlegen.UseVisualStyleBackColor = true;
            this.buttonAnlegen.Click += new System.EventHandler(this.buttonAnlegen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Verwaltung";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(349, 298);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(318, 36);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Zurück";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // FormVerwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 346);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAnlegen);
            this.Controls.Add(this.buttonÄndern);
            this.Controls.Add(this.buttonAnzeigen);
            this.Name = "FormVerwaltung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnzeigen;
        private System.Windows.Forms.Button buttonÄndern;
        private System.Windows.Forms.Button buttonAnlegen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
    }
}

