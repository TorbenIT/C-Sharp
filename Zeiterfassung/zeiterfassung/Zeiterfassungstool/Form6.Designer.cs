namespace Zeiterfassungstool
{
    partial class Form6
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
            this.listBoxBenutzer = new System.Windows.Forms.ListBox();
            this.textBoxGruppe = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAndern = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLoschen = new System.Windows.Forms.Button();
            this.textBoxBenutzer = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Arbeitsgruppe";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Red;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(861, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(111, 21);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Zurück";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listBoxBenutzer
            // 
            this.listBoxBenutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBenutzer.FormattingEnabled = true;
            this.listBoxBenutzer.ItemHeight = 20;
            this.listBoxBenutzer.Location = new System.Drawing.Point(56, 109);
            this.listBoxBenutzer.Name = "listBoxBenutzer";
            this.listBoxBenutzer.Size = new System.Drawing.Size(426, 344);
            this.listBoxBenutzer.TabIndex = 15;
            this.listBoxBenutzer.SelectedIndexChanged += new System.EventHandler(this.listBoxFreitage_SelectedIndexChanged);
            // 
            // textBoxGruppe
            // 
            this.textBoxGruppe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGruppe.Location = new System.Drawing.Point(529, 283);
            this.textBoxGruppe.Multiline = true;
            this.textBoxGruppe.Name = "textBoxGruppe";
            this.textBoxGruppe.Size = new System.Drawing.Size(160, 22);
            this.textBoxGruppe.TabIndex = 16;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Yellow;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(529, 389);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(111, 21);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAndern
            // 
            this.buttonAndern.BackColor = System.Drawing.Color.Yellow;
            this.buttonAndern.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAndern.Location = new System.Drawing.Point(652, 389);
            this.buttonAndern.Name = "buttonAndern";
            this.buttonAndern.Size = new System.Drawing.Size(111, 21);
            this.buttonAndern.TabIndex = 18;
            this.buttonAndern.Text = "Ändern";
            this.buttonAndern.UseVisualStyleBackColor = true;
            this.buttonAndern.Click += new System.EventHandler(this.buttonAndern_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(695, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Gruppe";
            // 
            // buttonLoschen
            // 
            this.buttonLoschen.BackColor = System.Drawing.Color.Yellow;
            this.buttonLoschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoschen.Location = new System.Drawing.Point(529, 416);
            this.buttonLoschen.Name = "buttonLoschen";
            this.buttonLoschen.Size = new System.Drawing.Size(234, 21);
            this.buttonLoschen.TabIndex = 24;
            this.buttonLoschen.Text = "Löschen";
            this.buttonLoschen.UseVisualStyleBackColor = true;
            this.buttonLoschen.Click += new System.EventHandler(this.buttonLoschen_Click);
            // 
            // textBoxBenutzer
            // 
            this.textBoxBenutzer.Enabled = false;
            this.textBoxBenutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBenutzer.Location = new System.Drawing.Point(529, 247);
            this.textBoxBenutzer.Multiline = true;
            this.textBoxBenutzer.Name = "textBoxBenutzer";
            this.textBoxBenutzer.Size = new System.Drawing.Size(160, 22);
            this.textBoxBenutzer.TabIndex = 25;
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(529, 211);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(160, 22);
            this.textBoxID.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(695, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Benutzer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(695, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "ID";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxBenutzer);
            this.Controls.Add(this.buttonLoschen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAndern);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxGruppe);
            this.Controls.Add(this.listBoxBenutzer);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbeitsgruppe";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListBox listBoxBenutzer;
        private System.Windows.Forms.TextBox textBoxGruppe;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAndern;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonLoschen;
        private System.Windows.Forms.TextBox textBoxBenutzer;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}