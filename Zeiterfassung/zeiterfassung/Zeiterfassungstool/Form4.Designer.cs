namespace Zeiterfassungstool
{
    partial class Form4
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
            this.buttonFreiart = new System.Windows.Forms.Button();
            this.buttonGruppe = new System.Windows.Forms.Button();
            this.buttonFeiertage = new System.Windows.Forms.Button();
            this.buttonFreitage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Verwaltung - Anlegen";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Red;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(80, 349);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(818, 50);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Zurück";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonFreiart
            // 
            this.buttonFreiart.BackColor = System.Drawing.Color.Aqua;
            this.buttonFreiart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFreiart.Location = new System.Drawing.Point(492, 142);
            this.buttonFreiart.Name = "buttonFreiart";
            this.buttonFreiart.Size = new System.Drawing.Size(200, 180);
            this.buttonFreiart.TabIndex = 14;
            this.buttonFreiart.Text = "Freitagearten";
            this.buttonFreiart.UseVisualStyleBackColor = true;
            this.buttonFreiart.Click += new System.EventHandler(this.buttonFreiart_Click);
            // 
            // buttonGruppe
            // 
            this.buttonGruppe.BackColor = System.Drawing.Color.Aqua;
            this.buttonGruppe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGruppe.Location = new System.Drawing.Point(286, 142);
            this.buttonGruppe.Name = "buttonGruppe";
            this.buttonGruppe.Size = new System.Drawing.Size(200, 180);
            this.buttonGruppe.TabIndex = 13;
            this.buttonGruppe.Text = "Arbeitsgruppe";
            this.buttonGruppe.UseVisualStyleBackColor = true;
            this.buttonGruppe.Click += new System.EventHandler(this.buttonGruppe_Click);
            // 
            // buttonFeiertage
            // 
            this.buttonFeiertage.BackColor = System.Drawing.Color.Aqua;
            this.buttonFeiertage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFeiertage.Location = new System.Drawing.Point(698, 142);
            this.buttonFeiertage.Name = "buttonFeiertage";
            this.buttonFeiertage.Size = new System.Drawing.Size(200, 180);
            this.buttonFeiertage.TabIndex = 12;
            this.buttonFeiertage.Text = "Feiertage";
            this.buttonFeiertage.UseVisualStyleBackColor = true;
            this.buttonFeiertage.Click += new System.EventHandler(this.buttonFeiertage_Click);
            // 
            // buttonFreitage
            // 
            this.buttonFreitage.BackColor = System.Drawing.Color.Aqua;
            this.buttonFreitage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFreitage.Location = new System.Drawing.Point(80, 142);
            this.buttonFreitage.Name = "buttonFreitage";
            this.buttonFreitage.Size = new System.Drawing.Size(200, 180);
            this.buttonFreitage.TabIndex = 11;
            this.buttonFreitage.Text = "Freitage";
            this.buttonFreitage.UseVisualStyleBackColor = true;
            this.buttonFreitage.Click += new System.EventHandler(this.buttonFreitage_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 446);
            this.Controls.Add(this.buttonFreiart);
            this.Controls.Add(this.buttonGruppe);
            this.Controls.Add(this.buttonFeiertage);
            this.Controls.Add(this.buttonFreitage);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anlegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonFreiart;
        private System.Windows.Forms.Button buttonGruppe;
        private System.Windows.Forms.Button buttonFeiertage;
        private System.Windows.Forms.Button buttonFreitage;
    }
}