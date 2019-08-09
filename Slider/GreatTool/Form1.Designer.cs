namespace GreatTool
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMid = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.buttonDown = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDown);
            this.panel1.Controls.Add(this.panelRegister);
            this.panel1.Controls.Add(this.buttonUp);
            this.panel1.Controls.Add(this.buttonMid);
            this.panel1.Location = new System.Drawing.Point(69, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 285);
            this.panel1.TabIndex = 0;
            // 
            // buttonMid
            // 
            this.buttonMid.Location = new System.Drawing.Point(16, 95);
            this.buttonMid.Name = "buttonMid";
            this.buttonMid.Size = new System.Drawing.Size(75, 67);
            this.buttonMid.TabIndex = 0;
            this.buttonMid.Text = "Mitte";
            this.buttonMid.UseVisualStyleBackColor = true;
            this.buttonMid.Click += new System.EventHandler(this.buttonMid_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(16, 22);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 67);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "Oben";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.Maroon;
            this.panelRegister.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panelRegister.Location = new System.Drawing.Point(87, 22);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(17, 67);
            this.panelRegister.TabIndex = 1;
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(16, 168);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(75, 67);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.Text = "Unten";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonMid;
        private System.Windows.Forms.Button buttonDown;
    }
}

