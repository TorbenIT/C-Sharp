using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Start
{
    public partial class Form2 : Form
    {
        private Form1 fh;

        public Form2(Form1 aufrufer)
        {
            fh = aufrufer;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"E:\Informatikausbildung\C Sharp\Wissenswertes.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string zeile;

            tabPage1.Text = "";
            while(sr.Peek() != -1)
            {
                zeile = sr.ReadLine();
                tabPage1.Text += zeile + "\n";
            }
            sr.Close();
        }
    }
}
