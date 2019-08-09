namespace Zeiterfassungstool2
{
    partial class Benutzerverwaltung
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
            this.TBPW = new System.Windows.Forms.TextBox();
            this.TBAN = new System.Windows.Forms.TextBox();
            this.TBID = new System.Windows.Forms.TextBox();
            this.CBG = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxAnzeigen = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonZurück = new System.Windows.Forms.Button();
            this.RBID = new System.Windows.Forms.RadioButton();
            this.RBAN = new System.Windows.Forms.RadioButton();
            this.RBPW = new System.Windows.Forms.RadioButton();
            this.RBGD = new System.Windows.Forms.RadioButton();
            this.RBG = new System.Windows.Forms.RadioButton();
            this.button6 = new System.Windows.Forms.Button();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // TBPW
            // 
            this.TBPW.Location = new System.Drawing.Point(121, 101);
            this.TBPW.Name = "TBPW";
            this.TBPW.Size = new System.Drawing.Size(100, 20);
            this.TBPW.TabIndex = 8;
            // 
            // TBAN
            // 
            this.TBAN.Location = new System.Drawing.Point(121, 75);
            this.TBAN.Name = "TBAN";
            this.TBAN.Size = new System.Drawing.Size(100, 20);
            this.TBAN.TabIndex = 7;
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(121, 49);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(100, 20);
            this.TBID.TabIndex = 6;
            // 
            // CBG
            // 
            this.CBG.FormattingEnabled = true;
            this.CBG.Items.AddRange(new object[] {
            "",
            "Verwaltung",
            "Administration",
            "Arbeiter",
            "Chef"});
            this.CBG.Location = new System.Drawing.Point(121, 153);
            this.CBG.Name = "CBG";
            this.CBG.Size = new System.Drawing.Size(100, 21);
            this.CBG.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Anmeldename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Passwort";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Geburtsdatum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Gruppe";
            // 
            // listBoxAnzeigen
            // 
            this.listBoxAnzeigen.FormattingEnabled = true;
            this.listBoxAnzeigen.Location = new System.Drawing.Point(285, 40);
            this.listBoxAnzeigen.Name = "listBoxAnzeigen";
            this.listBoxAnzeigen.Size = new System.Drawing.Size(474, 147);
            this.listBoxAnzeigen.TabIndex = 18;
            this.listBoxAnzeigen.SelectedIndexChanged += new System.EventHandler(this.listBoxAnzeigen_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 19;
            this.button1.Text = "Suchen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 20;
            this.button2.Text = "Anlegen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 21);
            this.button3.TabIndex = 22;
            this.button3.Text = "Ändern";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(285, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 21);
            this.button4.TabIndex = 21;
            this.button4.Text = "Löschen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ausgewählten Nutzer...";
            // 
            // buttonZurück
            // 
            this.buttonZurück.Location = new System.Drawing.Point(800, 12);
            this.buttonZurück.Name = "buttonZurück";
            this.buttonZurück.Size = new System.Drawing.Size(75, 21);
            this.buttonZurück.TabIndex = 24;
            this.buttonZurück.Text = "Zurück";
            this.buttonZurück.UseVisualStyleBackColor = true;
            this.buttonZurück.Click += new System.EventHandler(this.buttonZurück_Click);
            // 
            // RBID
            // 
            this.RBID.AutoSize = true;
            this.RBID.Location = new System.Drawing.Point(800, 56);
            this.RBID.Name = "RBID";
            this.RBID.Size = new System.Drawing.Size(36, 17);
            this.RBID.TabIndex = 25;
            this.RBID.TabStop = true;
            this.RBID.Text = "ID";
            this.RBID.UseVisualStyleBackColor = true;
            // 
            // RBAN
            // 
            this.RBAN.AutoSize = true;
            this.RBAN.Location = new System.Drawing.Point(800, 82);
            this.RBAN.Name = "RBAN";
            this.RBAN.Size = new System.Drawing.Size(92, 17);
            this.RBAN.TabIndex = 26;
            this.RBAN.TabStop = true;
            this.RBAN.Text = "Anmeldename";
            this.RBAN.UseVisualStyleBackColor = true;
            // 
            // RBPW
            // 
            this.RBPW.AutoSize = true;
            this.RBPW.Location = new System.Drawing.Point(800, 108);
            this.RBPW.Name = "RBPW";
            this.RBPW.Size = new System.Drawing.Size(68, 17);
            this.RBPW.TabIndex = 27;
            this.RBPW.TabStop = true;
            this.RBPW.Text = "Passwort";
            this.RBPW.UseVisualStyleBackColor = true;
            // 
            // RBGD
            // 
            this.RBGD.AutoSize = true;
            this.RBGD.Location = new System.Drawing.Point(800, 130);
            this.RBGD.Name = "RBGD";
            this.RBGD.Size = new System.Drawing.Size(91, 17);
            this.RBGD.TabIndex = 28;
            this.RBGD.TabStop = true;
            this.RBGD.Text = "Geburtsdatum";
            this.RBGD.UseVisualStyleBackColor = true;
            // 
            // RBG
            // 
            this.RBG.AutoSize = true;
            this.RBG.Location = new System.Drawing.Point(800, 157);
            this.RBG.Name = "RBG";
            this.RBG.Size = new System.Drawing.Size(60, 17);
            this.RBG.TabIndex = 29;
            this.RBG.TabStop = true;
            this.RBG.Text = "Gruppe";
            this.RBG.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(800, 188);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 21);
            this.button6.TabIndex = 30;
            this.button6.Text = "Sortieren";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(121, 127);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(100, 20);
            this.DTP.TabIndex = 31;
            this.DTP.Value = new System.DateTime(2018, 11, 22, 0, 0, 0, 0);
            // 
            // Benutzerverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 261);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.RBG);
            this.Controls.Add(this.RBGD);
            this.Controls.Add(this.RBPW);
            this.Controls.Add(this.RBAN);
            this.Controls.Add(this.RBID);
            this.Controls.Add(this.buttonZurück);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxAnzeigen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBPW);
            this.Controls.Add(this.TBAN);
            this.Controls.Add(this.TBID);
            this.Name = "Benutzerverwaltung";
            this.Text = "Benutzerverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBPW;
        private System.Windows.Forms.TextBox TBAN;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.ComboBox CBG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxAnzeigen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonZurück;
        private System.Windows.Forms.RadioButton RBID;
        private System.Windows.Forms.RadioButton RBAN;
        private System.Windows.Forms.RadioButton RBPW;
        private System.Windows.Forms.RadioButton RBGD;
        private System.Windows.Forms.RadioButton RBG;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker DTP;
    }
}