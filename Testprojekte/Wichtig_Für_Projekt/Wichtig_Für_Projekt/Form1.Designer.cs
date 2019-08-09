namespace Wichtig_Für_Projekt
{
    partial class Form1
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
            this.buttoneinlesen = new System.Windows.Forms.Button();
            this.listBoxausgabe = new System.Windows.Forms.ListBox();
            this.buttonzurückschreiben = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxankunft = new System.Windows.Forms.TextBox();
            this.textBoxabfahrt = new System.Windows.Forms.TextBox();
            this.textBoxzimmernummer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttoneinlesen
            // 
            this.buttoneinlesen.Location = new System.Drawing.Point(521, 65);
            this.buttoneinlesen.Name = "buttoneinlesen";
            this.buttoneinlesen.Size = new System.Drawing.Size(75, 23);
            this.buttoneinlesen.TabIndex = 0;
            this.buttoneinlesen.Text = "Einlesen";
            this.buttoneinlesen.UseVisualStyleBackColor = true;
            this.buttoneinlesen.Click += new System.EventHandler(this.buttoneinlesen_Click);
            // 
            // listBoxausgabe
            // 
            this.listBoxausgabe.FormattingEnabled = true;
            this.listBoxausgabe.Location = new System.Drawing.Point(12, 72);
            this.listBoxausgabe.Name = "listBoxausgabe";
            this.listBoxausgabe.Size = new System.Drawing.Size(284, 160);
            this.listBoxausgabe.TabIndex = 1;
            // 
            // buttonzurückschreiben
            // 
            this.buttonzurückschreiben.Location = new System.Drawing.Point(521, 94);
            this.buttonzurückschreiben.Name = "buttonzurückschreiben";
            this.buttonzurückschreiben.Size = new System.Drawing.Size(75, 23);
            this.buttonzurückschreiben.TabIndex = 2;
            this.buttonzurückschreiben.Text = "Zurück";
            this.buttonzurückschreiben.UseVisualStyleBackColor = true;
            this.buttonzurückschreiben.Click += new System.EventHandler(this.buttonzurückschreiben_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(302, 71);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 3;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(302, 106);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(100, 20);
            this.textBoxname.TabIndex = 4;
            // 
            // textBoxankunft
            // 
            this.textBoxankunft.Location = new System.Drawing.Point(302, 140);
            this.textBoxankunft.Name = "textBoxankunft";
            this.textBoxankunft.Size = new System.Drawing.Size(100, 20);
            this.textBoxankunft.TabIndex = 5;
            // 
            // textBoxabfahrt
            // 
            this.textBoxabfahrt.Location = new System.Drawing.Point(302, 175);
            this.textBoxabfahrt.Name = "textBoxabfahrt";
            this.textBoxabfahrt.Size = new System.Drawing.Size(100, 20);
            this.textBoxabfahrt.TabIndex = 6;
            // 
            // textBoxzimmernummer
            // 
            this.textBoxzimmernummer.Location = new System.Drawing.Point(302, 212);
            this.textBoxzimmernummer.Name = "textBoxzimmernummer";
            this.textBoxzimmernummer.Size = new System.Drawing.Size(100, 20);
            this.textBoxzimmernummer.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 478);
            this.Controls.Add(this.textBoxzimmernummer);
            this.Controls.Add(this.textBoxabfahrt);
            this.Controls.Add(this.textBoxankunft);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonzurückschreiben);
            this.Controls.Add(this.listBoxausgabe);
            this.Controls.Add(this.buttoneinlesen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoneinlesen;
        private System.Windows.Forms.ListBox listBoxausgabe;
        private System.Windows.Forms.Button buttonzurückschreiben;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxankunft;
        private System.Windows.Forms.TextBox textBoxabfahrt;
        private System.Windows.Forms.TextBox textBoxzimmernummer;
    }
}

