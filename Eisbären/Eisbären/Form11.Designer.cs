namespace Eisbären
{
    partial class Form11
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.cmddelete = new System.Windows.Forms.Button();
            this.cmdsuchen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSpende = new System.Windows.Forms.TextBox();
            this.Nachname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdupdate = new System.Windows.Forms.Button();
            this.cmdhilfe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(2, 152);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(288, 95);
            this.listBox2.TabIndex = 19;
            // 
            // cmddelete
            // 
            this.cmddelete.Location = new System.Drawing.Point(127, 79);
            this.cmddelete.Name = "cmddelete";
            this.cmddelete.Size = new System.Drawing.Size(75, 23);
            this.cmddelete.TabIndex = 18;
            this.cmddelete.Text = "Löschen";
            this.cmddelete.UseVisualStyleBackColor = true;
            this.cmddelete.Click += new System.EventHandler(this.cmddelete_Click);
            // 
            // cmdsuchen
            // 
            this.cmdsuchen.Location = new System.Drawing.Point(46, 79);
            this.cmdsuchen.Name = "cmdsuchen";
            this.cmdsuchen.Size = new System.Drawing.Size(75, 23);
            this.cmdsuchen.TabIndex = 17;
            this.cmdsuchen.Text = "Suchen";
            this.cmdsuchen.UseVisualStyleBackColor = true;
            this.cmdsuchen.Click += new System.EventHandler(this.cmdsuchen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Suchen/ Löschen:";
            // 
            // textBoxSpende
            // 
            this.textBoxSpende.Location = new System.Drawing.Point(371, 102);
            this.textBoxSpende.Name = "textBoxSpende";
            this.textBoxSpende.Size = new System.Drawing.Size(112, 20);
            this.textBoxSpende.TabIndex = 20;
            // 
            // Nachname
            // 
            this.Nachname.Location = new System.Drawing.Point(88, 53);
            this.Nachname.Name = "Nachname";
            this.Nachname.Size = new System.Drawing.Size(112, 20);
            this.Nachname.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Spendenbetrag ändern:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nachname:";
            // 
            // cmdupdate
            // 
            this.cmdupdate.Location = new System.Drawing.Point(408, 128);
            this.cmdupdate.Name = "cmdupdate";
            this.cmdupdate.Size = new System.Drawing.Size(75, 23);
            this.cmdupdate.TabIndex = 24;
            this.cmdupdate.Text = "Ändern";
            this.cmdupdate.UseVisualStyleBackColor = true;
            this.cmdupdate.Click += new System.EventHandler(this.cmdupdate_Click);
            // 
            // cmdhilfe
            // 
            this.cmdhilfe.Location = new System.Drawing.Point(408, 12);
            this.cmdhilfe.Name = "cmdhilfe";
            this.cmdhilfe.Size = new System.Drawing.Size(75, 57);
            this.cmdhilfe.TabIndex = 25;
            this.cmdhilfe.Text = "Hilfe zum Ändern (drücken)";
            this.cmdhilfe.UseVisualStyleBackColor = true;
            this.cmdhilfe.Click += new System.EventHandler(this.cmdhilfe_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 349);
            this.Controls.Add(this.cmdhilfe);
            this.Controls.Add(this.cmdupdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nachname);
            this.Controls.Add(this.textBoxSpende);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.cmddelete);
            this.Controls.Add(this.cmdsuchen);
            this.Controls.Add(this.label3);
            this.Name = "Form11";
            this.Text = "Spenderkartei durchsuchen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button cmddelete;
        private System.Windows.Forms.Button cmdsuchen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSpende;
        private System.Windows.Forms.TextBox Nachname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdupdate;
        private System.Windows.Forms.Button cmdhilfe;
    }
}