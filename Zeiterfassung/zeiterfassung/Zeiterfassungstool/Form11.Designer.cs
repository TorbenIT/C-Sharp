namespace Zeiterfassungstool
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.listBoxFreitagearten = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxArt = new System.Windows.Forms.TextBox();
            this.buttonLoschen = new System.Windows.Forms.Button();
            this.buttonAnlegen = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "Freitagearten";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(861, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(111, 21);
            this.buttonBack.TabIndex = 12;
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
            this.listBoxFreitagearten.TabIndex = 17;
            this.listBoxFreitagearten.SelectedIndexChanged += new System.EventHandler(this.listBoxFreitagearten_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(695, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Art";
            // 
            // textBoxArt
            // 
            this.textBoxArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArt.Location = new System.Drawing.Point(529, 228);
            this.textBoxArt.Multiline = true;
            this.textBoxArt.Name = "textBoxArt";
            this.textBoxArt.Size = new System.Drawing.Size(160, 22);
            this.textBoxArt.TabIndex = 49;
            // 
            // buttonLoschen
            // 
            this.buttonLoschen.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLoschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoschen.Location = new System.Drawing.Point(529, 416);
            this.buttonLoschen.Name = "buttonLoschen";
            this.buttonLoschen.Size = new System.Drawing.Size(234, 21);
            this.buttonLoschen.TabIndex = 57;
            this.buttonLoschen.Text = "Löschen";
            this.buttonLoschen.UseVisualStyleBackColor = true;
            this.buttonLoschen.Click += new System.EventHandler(this.buttonLoschen_Click);
            // 
            // buttonAnlegen
            // 
            this.buttonAnlegen.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAnlegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnlegen.Location = new System.Drawing.Point(652, 389);
            this.buttonAnlegen.Name = "buttonAnlegen";
            this.buttonAnlegen.Size = new System.Drawing.Size(111, 21);
            this.buttonAnlegen.TabIndex = 56;
            this.buttonAnlegen.Text = "Anlegen";
            this.buttonAnlegen.UseVisualStyleBackColor = true;
            this.buttonAnlegen.Click += new System.EventHandler(this.buttonAnlegen_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(529, 389);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(111, 21);
            this.buttonClear.TabIndex = 55;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonLoschen);
            this.Controls.Add(this.buttonAnlegen);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxArt);
            this.Controls.Add(this.listBoxFreitagearten);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Freitagearten";
            this.Load += new System.EventHandler(this.Form11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListBox listBoxFreitagearten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxArt;
        private System.Windows.Forms.Button buttonLoschen;
        private System.Windows.Forms.Button buttonAnlegen;
        private System.Windows.Forms.Button buttonClear;
    }
}