namespace Eisbären
{
    partial class Form14
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLi = new System.Windows.Forms.Button();
            this.buttonDr = new System.Windows.Forms.Button();
            this.buttonRe = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(182, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 27);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(66, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 28);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(115, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(46, 14);
            this.panel3.TabIndex = 0;
            // 
            // buttonLi
            // 
            this.buttonLi.Location = new System.Drawing.Point(28, 31);
            this.buttonLi.Name = "buttonLi";
            this.buttonLi.Size = new System.Drawing.Size(48, 29);
            this.buttonLi.TabIndex = 2;
            this.buttonLi.Text = "Li";
            this.buttonLi.UseVisualStyleBackColor = true;
            this.buttonLi.Click += new System.EventHandler(this.buttonLi_Click);
            // 
            // buttonDr
            // 
            this.buttonDr.Location = new System.Drawing.Point(82, 57);
            this.buttonDr.Name = "buttonDr";
            this.buttonDr.Size = new System.Drawing.Size(48, 29);
            this.buttonDr.TabIndex = 3;
            this.buttonDr.Text = "Dr";
            this.buttonDr.UseVisualStyleBackColor = true;
            this.buttonDr.Click += new System.EventHandler(this.buttonDr_Click);
            // 
            // buttonRe
            // 
            this.buttonRe.Location = new System.Drawing.Point(136, 31);
            this.buttonRe.Name = "buttonRe";
            this.buttonRe.Size = new System.Drawing.Size(48, 29);
            this.buttonRe.TabIndex = 4;
            this.buttonRe.Text = "Re";
            this.buttonRe.UseVisualStyleBackColor = true;
            this.buttonRe.Click += new System.EventHandler(this.buttonRe_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(197, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(149, 286);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPause.TabIndex = 6;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 316);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonRe);
            this.Controls.Add(this.buttonDr);
            this.Controls.Add(this.buttonLi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonLi;
        private System.Windows.Forms.Button buttonDr;
        private System.Windows.Forms.Button buttonRe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonPause;
    }
}