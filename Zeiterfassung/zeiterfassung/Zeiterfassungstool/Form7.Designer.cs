namespace Zeiterfassungstool
{
    partial class Form7
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.listBoxFreitagearten = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLoschen = new System.Windows.Forms.Button();
            this.buttonAndern = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxArt = new System.Windows.Forms.TextBox();
            this.textBoxLetzt = new System.Windows.Forms.TextBox();
            this.textBoxErst = new System.Windows.Forms.TextBox();
            this.textBoxBenutzer = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "Freitagearten";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Red;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(861, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(111, 21);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Zurück";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listBoxFreitagearten
            // 
            this.listBoxFreitagearten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFreitagearten.FormattingEnabled = true;
            this.listBoxFreitagearten.ItemHeight = 20;
            this.listBoxFreitagearten.Location = new System.Drawing.Point(56, 109);
            this.listBoxFreitagearten.Name = "listBoxFreitagearten";
            this.listBoxFreitagearten.Size = new System.Drawing.Size(426, 344);
            this.listBoxFreitagearten.TabIndex = 16;
            this.listBoxFreitagearten.SelectedIndexChanged += new System.EventHandler(this.listBoxFreitagearten_SelectedIndexChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(529, 389);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(111, 21);
            this.buttonClear.TabIndex = 29;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLoschen
            // 
            this.buttonLoschen.BackColor = System.Drawing.Color.Yellow;
            this.buttonLoschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoschen.Location = new System.Drawing.Point(529, 416);
            this.buttonLoschen.Name = "buttonLoschen";
            this.buttonLoschen.Size = new System.Drawing.Size(234, 21);
            this.buttonLoschen.TabIndex = 30;
            this.buttonLoschen.Text = "Löschen";
            this.buttonLoschen.UseVisualStyleBackColor = true;
            this.buttonLoschen.Click += new System.EventHandler(this.buttonLoschen_Click);
            // 
            // buttonAndern
            // 
            this.buttonAndern.BackColor = System.Drawing.Color.Yellow;
            this.buttonAndern.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAndern.Location = new System.Drawing.Point(652, 389);
            this.buttonAndern.Name = "buttonAndern";
            this.buttonAndern.Size = new System.Drawing.Size(111, 21);
            this.buttonAndern.TabIndex = 31;
            this.buttonAndern.Text = "Ändern";
            this.buttonAndern.UseVisualStyleBackColor = true;
            this.buttonAndern.Click += new System.EventHandler(this.buttonAndern_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(695, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Art";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(695, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Letzter Tag";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(695, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Erster Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(695, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Benutzer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(695, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "ID";
            // 
            // textBoxArt
            // 
            this.textBoxArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArt.Location = new System.Drawing.Point(529, 316);
            this.textBoxArt.Multiline = true;
            this.textBoxArt.Name = "textBoxArt";
            this.textBoxArt.Size = new System.Drawing.Size(160, 21);
            this.textBoxArt.TabIndex = 36;
            // 
            // textBoxLetzt
            // 
            this.textBoxLetzt.Enabled = false;
            this.textBoxLetzt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLetzt.Location = new System.Drawing.Point(529, 280);
            this.textBoxLetzt.Multiline = true;
            this.textBoxLetzt.Name = "textBoxLetzt";
            this.textBoxLetzt.Size = new System.Drawing.Size(160, 21);
            this.textBoxLetzt.TabIndex = 35;
            // 
            // textBoxErst
            // 
            this.textBoxErst.Enabled = false;
            this.textBoxErst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxErst.Location = new System.Drawing.Point(529, 244);
            this.textBoxErst.Multiline = true;
            this.textBoxErst.Name = "textBoxErst";
            this.textBoxErst.Size = new System.Drawing.Size(160, 21);
            this.textBoxErst.TabIndex = 34;
            // 
            // textBoxBenutzer
            // 
            this.textBoxBenutzer.Enabled = false;
            this.textBoxBenutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBenutzer.Location = new System.Drawing.Point(529, 208);
            this.textBoxBenutzer.Multiline = true;
            this.textBoxBenutzer.Name = "textBoxBenutzer";
            this.textBoxBenutzer.Size = new System.Drawing.Size(160, 21);
            this.textBoxBenutzer.TabIndex = 33;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(529, 172);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(160, 21);
            this.textBoxID.TabIndex = 32;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxArt);
            this.Controls.Add(this.textBoxLetzt);
            this.Controls.Add(this.textBoxErst);
            this.Controls.Add(this.textBoxBenutzer);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonAndern);
            this.Controls.Add(this.buttonLoschen);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listBoxFreitagearten);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freitagearten";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListBox listBoxFreitagearten;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLoschen;
        private System.Windows.Forms.Button buttonAndern;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxArt;
        private System.Windows.Forms.TextBox textBoxLetzt;
        private System.Windows.Forms.TextBox textBoxErst;
        private System.Windows.Forms.TextBox textBoxBenutzer;
        private System.Windows.Forms.TextBox textBoxID;
    }
}