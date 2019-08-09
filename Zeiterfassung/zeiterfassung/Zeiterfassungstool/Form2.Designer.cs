namespace Zeiterfassungstool
{
    partial class Form2
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
            this.listBoxFreitage = new System.Windows.Forms.ListBox();
            this.listBoxFeiertage = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLesen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Verwaltung - Anzeigen";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Red;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(500, 510);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(426, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Zurück";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listBoxFreitage
            // 
            this.listBoxFreitage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFreitage.FormattingEnabled = true;
            this.listBoxFreitage.ItemHeight = 20;
            this.listBoxFreitage.Location = new System.Drawing.Point(41, 132);
            this.listBoxFreitage.Name = "listBoxFreitage";
            this.listBoxFreitage.Size = new System.Drawing.Size(426, 344);
            this.listBoxFreitage.TabIndex = 6;
            // 
            // listBoxFeiertage
            // 
            this.listBoxFeiertage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFeiertage.FormattingEnabled = true;
            this.listBoxFeiertage.ItemHeight = 20;
            this.listBoxFeiertage.Location = new System.Drawing.Point(500, 132);
            this.listBoxFeiertage.Name = "listBoxFeiertage";
            this.listBoxFeiertage.Size = new System.Drawing.Size(426, 344);
            this.listBoxFeiertage.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Freitage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Feiertage";
            // 
            // buttonLesen
            // 
            this.buttonLesen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonLesen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLesen.Location = new System.Drawing.Point(41, 510);
            this.buttonLesen.Name = "buttonLesen";
            this.buttonLesen.Size = new System.Drawing.Size(426, 23);
            this.buttonLesen.TabIndex = 11;
            this.buttonLesen.Text = "Daten lesen";
            this.buttonLesen.UseVisualStyleBackColor = true;
            this.buttonLesen.Click += new System.EventHandler(this.buttonLesen_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 619);
            this.Controls.Add(this.buttonLesen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxFeiertage);
            this.Controls.Add(this.listBoxFreitage);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anzeigen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListBox listBoxFreitage;
        private System.Windows.Forms.Button buttonLesen;
        private System.Windows.Forms.ListBox listBoxFeiertage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}