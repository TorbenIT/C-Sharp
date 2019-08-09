namespace Eisbären
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonunloadme = new System.Windows.Forms.Button();
            this.buttonaddtoaccess = new System.Windows.Forms.Button();
            this.textBoxprice = new System.Windows.Forms.TextBox();
            this.textBoxdescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonunloadme);
            this.groupBox1.Controls.Add(this.buttonaddtoaccess);
            this.groupBox1.Controls.Add(this.textBoxprice);
            this.groupBox1.Controls.Add(this.textBoxdescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 116);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eigene Artikel zur Verfügung stellen";
            // 
            // buttonunloadme
            // 
            this.buttonunloadme.Location = new System.Drawing.Point(6, 87);
            this.buttonunloadme.Name = "buttonunloadme";
            this.buttonunloadme.Size = new System.Drawing.Size(75, 23);
            this.buttonunloadme.TabIndex = 5;
            this.buttonunloadme.Text = "Abbrechen";
            this.buttonunloadme.UseVisualStyleBackColor = true;
            this.buttonunloadme.Click += new System.EventHandler(this.buttonunloadme_Click);
            // 
            // buttonaddtoaccess
            // 
            this.buttonaddtoaccess.Location = new System.Drawing.Point(108, 87);
            this.buttonaddtoaccess.Name = "buttonaddtoaccess";
            this.buttonaddtoaccess.Size = new System.Drawing.Size(75, 23);
            this.buttonaddtoaccess.TabIndex = 4;
            this.buttonaddtoaccess.Text = "Hinzufügen";
            this.buttonaddtoaccess.UseVisualStyleBackColor = true;
            this.buttonaddtoaccess.Click += new System.EventHandler(this.buttonaddtoaccess_Click);
            // 
            // textBoxprice
            // 
            this.textBoxprice.Location = new System.Drawing.Point(83, 57);
            this.textBoxprice.Name = "textBoxprice";
            this.textBoxprice.Size = new System.Drawing.Size(100, 20);
            this.textBoxprice.TabIndex = 3;
 
            // 
            // textBoxdescription
            // 
            this.textBoxdescription.Location = new System.Drawing.Point(83, 31);
            this.textBoxdescription.Name = "textBoxdescription";
            this.textBoxdescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxdescription.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bezeichnung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 115);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 326);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form13";
            this.Text = "Verkaufe deine eigenen Artikel im Eisbärshop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonunloadme;
        private System.Windows.Forms.Button buttonaddtoaccess;
        private System.Windows.Forms.TextBox textBoxprice;
        private System.Windows.Forms.TextBox textBoxdescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}