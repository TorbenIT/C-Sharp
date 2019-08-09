namespace Hotel
{
    partial class FormHotel
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
            this.listBoxausgabe = new System.Windows.Forms.ListBox();
            this.buttoneinlesen = new System.Windows.Forms.Button();
            this.buttonzurückschreiben = new System.Windows.Forms.Button();
            this.buttonlöschenzeile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxankunft = new System.Windows.Forms.TextBox();
            this.textBoxabfahrt = new System.Windows.Forms.TextBox();
            this.textBoxzimmernummer = new System.Windows.Forms.TextBox();
            this.buttonneu = new System.Windows.Forms.Button();
            this.buttonzulistbox = new System.Windows.Forms.Button();
            this.buttonprüfen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxausgabe
            // 
            this.listBoxausgabe.FormattingEnabled = true;
            this.listBoxausgabe.Location = new System.Drawing.Point(32, 64);
            this.listBoxausgabe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxausgabe.Name = "listBoxausgabe";
            this.listBoxausgabe.Size = new System.Drawing.Size(451, 290);
            this.listBoxausgabe.TabIndex = 0;
            this.listBoxausgabe.SelectedIndexChanged += new System.EventHandler(this.listBoxausgabe_SelectedIndexChanged);
            // 
            // buttoneinlesen
            // 
            this.buttoneinlesen.Location = new System.Drawing.Point(40, 15);
            this.buttoneinlesen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttoneinlesen.Name = "buttoneinlesen";
            this.buttoneinlesen.Size = new System.Drawing.Size(165, 34);
            this.buttoneinlesen.TabIndex = 1;
            this.buttoneinlesen.Text = "Textdatei in Listbox";
            this.buttoneinlesen.UseVisualStyleBackColor = true;
            this.buttoneinlesen.Click += new System.EventHandler(this.buttoneinlesen_Click);
            // 
            // buttonzurückschreiben
            // 
            this.buttonzurückschreiben.Location = new System.Drawing.Point(240, 18);
            this.buttonzurückschreiben.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonzurückschreiben.Name = "buttonzurückschreiben";
            this.buttonzurückschreiben.Size = new System.Drawing.Size(204, 31);
            this.buttonzurückschreiben.TabIndex = 2;
            this.buttonzurückschreiben.Text = "alles zurück in Textdatei schreiben";
            this.buttonzurückschreiben.UseVisualStyleBackColor = true;
            this.buttonzurückschreiben.Click += new System.EventHandler(this.buttonzurückschreiben_Click);
            // 
            // buttonlöschenzeile
            // 
            this.buttonlöschenzeile.Location = new System.Drawing.Point(522, 21);
            this.buttonlöschenzeile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonlöschenzeile.Name = "buttonlöschenzeile";
            this.buttonlöschenzeile.Size = new System.Drawing.Size(246, 28);
            this.buttonlöschenzeile.TabIndex = 3;
            this.buttonlöschenzeile.Text = "Löschen einer Zeile";
            this.buttonlöschenzeile.UseVisualStyleBackColor = true;
            this.buttonlöschenzeile.Click += new System.EventHandler(this.buttonlöschenzeile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BuchungsID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ankunft";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Abfahrt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Zimmernummer";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(674, 70);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(78, 20);
            this.textBoxID.TabIndex = 9;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(673, 110);
            this.textBoxname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(79, 20);
            this.textBoxname.TabIndex = 10;
            // 
            // textBoxankunft
            // 
            this.textBoxankunft.Location = new System.Drawing.Point(673, 150);
            this.textBoxankunft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxankunft.Name = "textBoxankunft";
            this.textBoxankunft.Size = new System.Drawing.Size(78, 20);
            this.textBoxankunft.TabIndex = 11;
            // 
            // textBoxabfahrt
            // 
            this.textBoxabfahrt.Location = new System.Drawing.Point(674, 188);
            this.textBoxabfahrt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxabfahrt.Name = "textBoxabfahrt";
            this.textBoxabfahrt.Size = new System.Drawing.Size(77, 20);
            this.textBoxabfahrt.TabIndex = 12;
            // 
            // textBoxzimmernummer
            // 
            this.textBoxzimmernummer.Location = new System.Drawing.Point(671, 233);
            this.textBoxzimmernummer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxzimmernummer.Name = "textBoxzimmernummer";
            this.textBoxzimmernummer.Size = new System.Drawing.Size(80, 20);
            this.textBoxzimmernummer.TabIndex = 13;
            // 
            // buttonneu
            // 
            this.buttonneu.Location = new System.Drawing.Point(505, 296);
            this.buttonneu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonneu.Name = "buttonneu";
            this.buttonneu.Size = new System.Drawing.Size(104, 28);
            this.buttonneu.TabIndex = 14;
            this.buttonneu.Text = "neue Buchung";
            this.buttonneu.UseVisualStyleBackColor = true;
            this.buttonneu.Click += new System.EventHandler(this.buttonneu_Click);
            // 
            // buttonzulistbox
            // 
            this.buttonzulistbox.Location = new System.Drawing.Point(505, 353);
            this.buttonzulistbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonzulistbox.Name = "buttonzulistbox";
            this.buttonzulistbox.Size = new System.Drawing.Size(263, 28);
            this.buttonzulistbox.TabIndex = 15;
            this.buttonzulistbox.Text = "neue Buchung in Listbox speichern";
            this.buttonzulistbox.UseVisualStyleBackColor = true;
            this.buttonzulistbox.Click += new System.EventHandler(this.buttonzuTextbox_Click);
            // 
            // buttonprüfen
            // 
            this.buttonprüfen.Location = new System.Drawing.Point(630, 297);
            this.buttonprüfen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonprüfen.Name = "buttonprüfen";
            this.buttonprüfen.Size = new System.Drawing.Size(137, 26);
            this.buttonprüfen.TabIndex = 16;
            this.buttonprüfen.Text = "neue Buchung prüfen";
            this.buttonprüfen.UseVisualStyleBackColor = true;
            this.buttonprüfen.Click += new System.EventHandler(this.buttonprüfen_Click);
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 422);
            this.Controls.Add(this.buttonprüfen);
            this.Controls.Add(this.buttonzulistbox);
            this.Controls.Add(this.buttonneu);
            this.Controls.Add(this.textBoxzimmernummer);
            this.Controls.Add(this.textBoxabfahrt);
            this.Controls.Add(this.textBoxankunft);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonlöschenzeile);
            this.Controls.Add(this.buttonzurückschreiben);
            this.Controls.Add(this.buttoneinlesen);
            this.Controls.Add(this.listBoxausgabe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormHotel";
            this.Text = "Hotelverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxausgabe;
        private System.Windows.Forms.Button buttoneinlesen;
        private System.Windows.Forms.Button buttonzurückschreiben;
        private System.Windows.Forms.Button buttonlöschenzeile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxankunft;
        private System.Windows.Forms.TextBox textBoxabfahrt;
        private System.Windows.Forms.TextBox textBoxzimmernummer;
        private System.Windows.Forms.Button buttonneu;
        private System.Windows.Forms.Button buttonzulistbox;
        private System.Windows.Forms.Button buttonprüfen;
    }
}

