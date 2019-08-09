namespace Spanisch
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allgemeinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testBeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmBeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richtungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschEnglishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishDeutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ableitungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdstart = new System.Windows.Forms.Button();
            this.cmdprüfen = new System.Windows.Forms.Button();
            this.TextBoxantworten = new System.Windows.Forms.TextBox();
            this.labelAusgabe = new System.Windows.Forms.Label();
            this.labelFrage = new System.Windows.Forms.Label();
            this.labelrichtung = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allgemeinToolStripMenuItem,
            this.richtungToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // allgemeinToolStripMenuItem
            // 
            this.allgemeinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testBeendenToolStripMenuItem,
            this.programmBeendenToolStripMenuItem});
            this.allgemeinToolStripMenuItem.Name = "allgemeinToolStripMenuItem";
            this.allgemeinToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.allgemeinToolStripMenuItem.Text = "Allgemein";
            // 
            // testBeendenToolStripMenuItem
            // 
            this.testBeendenToolStripMenuItem.Name = "testBeendenToolStripMenuItem";
            this.testBeendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testBeendenToolStripMenuItem.Text = "Test beenden";
            this.testBeendenToolStripMenuItem.Click += new System.EventHandler(this.testBeendenToolStripMenuItem_Click);
            // 
            // programmBeendenToolStripMenuItem
            // 
            this.programmBeendenToolStripMenuItem.Name = "programmBeendenToolStripMenuItem";
            this.programmBeendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programmBeendenToolStripMenuItem.Text = "Programm beenden";
            this.programmBeendenToolStripMenuItem.Click += new System.EventHandler(this.programmBeendenToolStripMenuItem_Click);
            // 
            // richtungToolStripMenuItem
            // 
            this.richtungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deutschEnglishToolStripMenuItem,
            this.englishDeutschToolStripMenuItem});
            this.richtungToolStripMenuItem.Name = "richtungToolStripMenuItem";
            this.richtungToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.richtungToolStripMenuItem.Text = "Richtung";
            // 
            // deutschEnglishToolStripMenuItem
            // 
            this.deutschEnglishToolStripMenuItem.Name = "deutschEnglishToolStripMenuItem";
            this.deutschEnglishToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.deutschEnglishToolStripMenuItem.Text = "Deutsch - Spanish";
            this.deutschEnglishToolStripMenuItem.Click += new System.EventHandler(this.deutschEnglishToolStripMenuItem_Click);
            // 
            // englishDeutschToolStripMenuItem
            // 
            this.englishDeutschToolStripMenuItem.Name = "englishDeutschToolStripMenuItem";
            this.englishDeutschToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.englishDeutschToolStripMenuItem.Text = "Spanish - Deutsch";
            this.englishDeutschToolStripMenuItem.Click += new System.EventHandler(this.englishDeutschToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ableitungToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // ableitungToolStripMenuItem
            // 
            this.ableitungToolStripMenuItem.Name = "ableitungToolStripMenuItem";
            this.ableitungToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ableitungToolStripMenuItem.Text = "Anleitung";
            this.ableitungToolStripMenuItem.Click += new System.EventHandler(this.ableitungToolStripMenuItem_Click);
            // 
            // cmdstart
            // 
            this.cmdstart.Location = new System.Drawing.Point(12, 292);
            this.cmdstart.Name = "cmdstart";
            this.cmdstart.Size = new System.Drawing.Size(75, 25);
            this.cmdstart.TabIndex = 1;
            this.cmdstart.Text = "Test starten";
            this.cmdstart.UseVisualStyleBackColor = true;
            this.cmdstart.Click += new System.EventHandler(this.cmdstart_Click);
            // 
            // cmdprüfen
            // 
            this.cmdprüfen.Location = new System.Drawing.Point(12, 337);
            this.cmdprüfen.Name = "cmdprüfen";
            this.cmdprüfen.Size = new System.Drawing.Size(75, 36);
            this.cmdprüfen.TabIndex = 2;
            this.cmdprüfen.Text = "Prüfen / Nächster";
            this.cmdprüfen.UseVisualStyleBackColor = true;
            this.cmdprüfen.Click += new System.EventHandler(this.cmdprüfen_Click);
            // 
            // TextBoxantworten
            // 
            this.TextBoxantworten.Location = new System.Drawing.Point(133, 340);
            this.TextBoxantworten.Name = "TextBoxantworten";
            this.TextBoxantworten.Size = new System.Drawing.Size(100, 20);
            this.TextBoxantworten.TabIndex = 3;
            // 
            // labelAusgabe
            // 
            this.labelAusgabe.AutoSize = true;
            this.labelAusgabe.Location = new System.Drawing.Point(153, 298);
            this.labelAusgabe.Name = "labelAusgabe";
            this.labelAusgabe.Size = new System.Drawing.Size(35, 13);
            this.labelAusgabe.TabIndex = 4;
            this.labelAusgabe.Text = "label1";
            // 
            // labelFrage
            // 
            this.labelFrage.AutoSize = true;
            this.labelFrage.Location = new System.Drawing.Point(21, 258);
            this.labelFrage.Name = "labelFrage";
            this.labelFrage.Size = new System.Drawing.Size(35, 13);
            this.labelFrage.TabIndex = 5;
            this.labelFrage.Text = "label1";
            // 
            // labelrichtung
            // 
            this.labelrichtung.AutoSize = true;
            this.labelrichtung.Location = new System.Drawing.Point(134, 207);
            this.labelrichtung.Name = "labelrichtung";
            this.labelrichtung.Size = new System.Drawing.Size(35, 13);
            this.labelrichtung.TabIndex = 6;
            this.labelrichtung.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 411);
            this.Controls.Add(this.labelrichtung);
            this.Controls.Add(this.labelFrage);
            this.Controls.Add(this.labelAusgabe);
            this.Controls.Add(this.TextBoxantworten);
            this.Controls.Add(this.cmdprüfen);
            this.Controls.Add(this.cmdstart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Spanisch Vokabeln lernen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allgemeinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testBeendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmBeendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem richtungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutschEnglishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishDeutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ableitungToolStripMenuItem;
        private System.Windows.Forms.Button cmdstart;
        private System.Windows.Forms.Button cmdprüfen;
        private System.Windows.Forms.TextBox TextBoxantworten;
        private System.Windows.Forms.Label labelAusgabe;
        private System.Windows.Forms.Label labelFrage;
        private System.Windows.Forms.Label labelrichtung;
    }
}

