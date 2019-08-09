namespace Eisbären
{
    partial class Form12
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonreset = new System.Windows.Forms.Button();
            this.buttonbuy = new System.Windows.Forms.Button();
            this.textBoxpassw = new System.Windows.Forms.TextBox();
            this.textBoxuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxshop = new System.Windows.Forms.ComboBox();
            this.buttonaddtolstbox = new System.Windows.Forms.Button();
            this.listBoxshop = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonaddtocombo = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonreset);
            this.groupBox2.Controls.Add(this.buttonbuy);
            this.groupBox2.Controls.Add(this.textBoxpassw);
            this.groupBox2.Controls.Add(this.textBoxuser);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(50, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 116);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kasse";
            // 
            // buttonreset
            // 
            this.buttonreset.Location = new System.Drawing.Point(6, 69);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(75, 23);
            this.buttonreset.TabIndex = 5;
            this.buttonreset.Text = "Löschen";
            this.buttonreset.UseVisualStyleBackColor = true;
            // 
            // buttonbuy
            // 
            this.buttonbuy.Location = new System.Drawing.Point(108, 69);
            this.buttonbuy.Name = "buttonbuy";
            this.buttonbuy.Size = new System.Drawing.Size(75, 23);
            this.buttonbuy.TabIndex = 4;
            this.buttonbuy.Text = "Kaufen";
            this.buttonbuy.UseVisualStyleBackColor = true;
            this.buttonbuy.Click += new System.EventHandler(this.buttonbuy_Click);
            // 
            // textBoxpassw
            // 
            this.textBoxpassw.Location = new System.Drawing.Point(83, 43);
            this.textBoxpassw.Name = "textBoxpassw";
            this.textBoxpassw.Size = new System.Drawing.Size(100, 20);
            this.textBoxpassw.TabIndex = 3;
            // 
            // textBoxuser
            // 
            this.textBoxuser.Location = new System.Drawing.Point(83, 17);
            this.textBoxuser.Name = "textBoxuser";
            this.textBoxuser.Size = new System.Drawing.Size(100, 20);
            this.textBoxuser.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Passwort:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Benutzername:";
            // 
            // comboBoxshop
            // 
            this.comboBoxshop.FormattingEnabled = true;
            this.comboBoxshop.Location = new System.Drawing.Point(35, 35);
            this.comboBoxshop.Name = "comboBoxshop";
            this.comboBoxshop.Size = new System.Drawing.Size(121, 21);
            this.comboBoxshop.TabIndex = 2;
            // 
            // buttonaddtolstbox
            // 
            this.buttonaddtolstbox.Location = new System.Drawing.Point(9, 70);
            this.buttonaddtolstbox.Name = "buttonaddtolstbox";
            this.buttonaddtolstbox.Size = new System.Drawing.Size(75, 23);
            this.buttonaddtolstbox.TabIndex = 3;
            this.buttonaddtolstbox.Text = "Hinzufügen";
            this.buttonaddtolstbox.UseVisualStyleBackColor = true;
            this.buttonaddtolstbox.Click += new System.EventHandler(this.buttonaddtolstbox_Click);
            // 
            // listBoxshop
            // 
            this.listBoxshop.FormattingEnabled = true;
            this.listBoxshop.Location = new System.Drawing.Point(9, 99);
            this.listBoxshop.Name = "listBoxshop";
            this.listBoxshop.Size = new System.Drawing.Size(242, 121);
            this.listBoxshop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wählen Sie einen Artikel aus";
            // 
            // buttonaddtocombo
            // 
            this.buttonaddtocombo.Location = new System.Drawing.Point(162, 33);
            this.buttonaddtocombo.Name = "buttonaddtocombo";
            this.buttonaddtocombo.Size = new System.Drawing.Size(75, 23);
            this.buttonaddtocombo.TabIndex = 6;
            this.buttonaddtocombo.Text = "Aktualisieren";
            this.buttonaddtocombo.UseVisualStyleBackColor = true;
            this.buttonaddtocombo.Click += new System.EventHandler(this.buttonaddtocombo_Click);
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 465);
            this.Controls.Add(this.buttonaddtocombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxshop);
            this.Controls.Add(this.buttonaddtolstbox);
            this.Controls.Add(this.comboBoxshop);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form12";
            this.Text = "Eisbär Shop";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonbuy;
        private System.Windows.Forms.TextBox textBoxpassw;
        private System.Windows.Forms.TextBox textBoxuser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxshop;
        private System.Windows.Forms.Button buttonaddtolstbox;
        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxshop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonaddtocombo;
    }
}