namespace Gamilendo
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
            this.btKunde = new System.Windows.Forms.Button();
            this.btKonsole = new System.Windows.Forms.Button();
            this.btSpiele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptmenüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verwaltenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spieleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vermietungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btMiete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btKunde
            // 
            this.btKunde.Location = new System.Drawing.Point(168, 95);
            this.btKunde.Name = "btKunde";
            this.btKunde.Size = new System.Drawing.Size(262, 38);
            this.btKunde.TabIndex = 0;
            this.btKunde.Text = "Kunden";
            this.btKunde.UseVisualStyleBackColor = true;
            this.btKunde.Click += new System.EventHandler(this.button1_Click);
            // 
            // btKonsole
            // 
            this.btKonsole.Location = new System.Drawing.Point(166, 146);
            this.btKonsole.Name = "btKonsole";
            this.btKonsole.Size = new System.Drawing.Size(263, 36);
            this.btKonsole.TabIndex = 1;
            this.btKonsole.Text = "Konsole";
            this.btKonsole.UseVisualStyleBackColor = true;
            this.btKonsole.Click += new System.EventHandler(this.button2_Click);
            // 
            // btSpiele
            // 
            this.btSpiele.Location = new System.Drawing.Point(168, 194);
            this.btSpiele.Name = "btSpiele";
            this.btSpiele.Size = new System.Drawing.Size(261, 32);
            this.btSpiele.TabIndex = 2;
            this.btSpiele.Text = "Spiele";
            this.btSpiele.UseVisualStyleBackColor = true;
            this.btSpiele.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Was wollen Sie heute zuerst verwalten?";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hauptmenüToolStripMenuItem,
            this.verwaltenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // hauptmenüToolStripMenuItem
            // 
            this.hauptmenüToolStripMenuItem.Name = "hauptmenüToolStripMenuItem";
            this.hauptmenüToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.hauptmenüToolStripMenuItem.Text = "Hauptmenü";
            // 
            // verwaltenToolStripMenuItem
            // 
            this.verwaltenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kundeToolStripMenuItem,
            this.konsoleToolStripMenuItem,
            this.spieleToolStripMenuItem,
            this.vermietungenToolStripMenuItem});
            this.verwaltenToolStripMenuItem.Name = "verwaltenToolStripMenuItem";
            this.verwaltenToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.verwaltenToolStripMenuItem.Text = "Verwalten";
            // 
            // kundeToolStripMenuItem
            // 
            this.kundeToolStripMenuItem.Name = "kundeToolStripMenuItem";
            this.kundeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.kundeToolStripMenuItem.Text = "Kunde";
            this.kundeToolStripMenuItem.Click += new System.EventHandler(this.kundeToolStripMenuItem_Click);
            // 
            // konsoleToolStripMenuItem
            // 
            this.konsoleToolStripMenuItem.Name = "konsoleToolStripMenuItem";
            this.konsoleToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.konsoleToolStripMenuItem.Text = "Konsole";
            this.konsoleToolStripMenuItem.Click += new System.EventHandler(this.konsoleToolStripMenuItem_Click);
            // 
            // spieleToolStripMenuItem
            // 
            this.spieleToolStripMenuItem.Name = "spieleToolStripMenuItem";
            this.spieleToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.spieleToolStripMenuItem.Text = "Spiele";
            this.spieleToolStripMenuItem.Click += new System.EventHandler(this.spieleToolStripMenuItem_Click);
            // 
            // vermietungenToolStripMenuItem
            // 
            this.vermietungenToolStripMenuItem.Name = "vermietungenToolStripMenuItem";
            this.vermietungenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.vermietungenToolStripMenuItem.Text = "Vermietungen";
            this.vermietungenToolStripMenuItem.Click += new System.EventHandler(this.vermietungenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // btMiete
            // 
            this.btMiete.Location = new System.Drawing.Point(166, 233);
            this.btMiete.Name = "btMiete";
            this.btMiete.Size = new System.Drawing.Size(263, 43);
            this.btMiete.TabIndex = 5;
            this.btMiete.Text = "Vermietungen";
            this.btMiete.UseVisualStyleBackColor = true;
            this.btMiete.Click += new System.EventHandler(this.btMiete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Willkommen beim Gamilendo Manger !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 349);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btMiete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSpiele);
            this.Controls.Add(this.btKonsole);
            this.Controls.Add(this.btKunde);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Startseite";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btKunde;
        private System.Windows.Forms.Button btKonsole;
        private System.Windows.Forms.Button btSpiele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hauptmenüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verwaltenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spieleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Button btMiete;
        private System.Windows.Forms.ToolStripMenuItem vermietungenToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

