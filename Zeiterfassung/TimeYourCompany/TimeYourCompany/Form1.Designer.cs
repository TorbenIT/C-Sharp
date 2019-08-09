namespace TimeYourCompany
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
            this.btnWorkstart = new System.Windows.Forms.Button();
            this.btnWorkEnds = new System.Windows.Forms.Button();
            this.btnBreaks = new System.Windows.Forms.Button();
            this.btnBreakEnds = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWorkstart
            // 
            this.btnWorkstart.Location = new System.Drawing.Point(41, 67);
            this.btnWorkstart.Name = "btnWorkstart";
            this.btnWorkstart.Size = new System.Drawing.Size(138, 29);
            this.btnWorkstart.TabIndex = 0;
            this.btnWorkstart.Text = "Beginn Arbeit";
            this.btnWorkstart.UseVisualStyleBackColor = true;
            this.btnWorkstart.Click += new System.EventHandler(this.btnWorkstart_Click);
            // 
            // btnWorkEnds
            // 
            this.btnWorkEnds.Location = new System.Drawing.Point(185, 66);
            this.btnWorkEnds.Name = "btnWorkEnds";
            this.btnWorkEnds.Size = new System.Drawing.Size(136, 30);
            this.btnWorkEnds.TabIndex = 1;
            this.btnWorkEnds.Text = "Ende Arbeit";
            this.btnWorkEnds.UseVisualStyleBackColor = true;
            this.btnWorkEnds.Click += new System.EventHandler(this.btnWorkEnds_Click);
            // 
            // btnBreaks
            // 
            this.btnBreaks.Location = new System.Drawing.Point(334, 66);
            this.btnBreaks.Name = "btnBreaks";
            this.btnBreaks.Size = new System.Drawing.Size(136, 30);
            this.btnBreaks.TabIndex = 2;
            this.btnBreaks.Text = "Drücke um deine Pausen festzulegen";
            this.btnBreaks.UseVisualStyleBackColor = true;
            this.btnBreaks.Click += new System.EventHandler(this.btnBreaks_Click);
            // 
            // btnBreakEnds
            // 
            this.btnBreakEnds.Location = new System.Drawing.Point(476, 66);
            this.btnBreakEnds.Name = "btnBreakEnds";
            this.btnBreakEnds.Size = new System.Drawing.Size(136, 30);
            this.btnBreakEnds.TabIndex = 3;
            this.btnBreakEnds.Text = "Drück, um deine Pause zu beenden";
            this.btnBreakEnds.UseVisualStyleBackColor = true;
            this.btnBreakEnds.Click += new System.EventHandler(this.btnBreakEnds_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(110, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 347);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(0, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(239, 118);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(177, 36);
            this.textBoxOutput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(142, 26);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(0, 13);
            this.labelOutput.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(660, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.37965F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.62035F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(156, 513);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 121);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBreakEnds);
            this.Controls.Add(this.btnBreaks);
            this.Controls.Add(this.btnWorkEnds);
            this.Controls.Add(this.btnWorkstart);
            this.Name = "Form1";
            this.Text = "Arbeitszeit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWorkstart;
        private System.Windows.Forms.Button btnWorkEnds;
        private System.Windows.Forms.Button btnBreaks;
        private System.Windows.Forms.Button btnBreakEnds;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

