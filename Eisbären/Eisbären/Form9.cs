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

namespace Eisbären
{
    public partial class Form9 : Form
    {
        private Form1 fh;
        public Form9(Form1 aufrufer)
        {
            fh = aufrufer;
            InitializeComponent();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr;
            string dateiname = "Impressum.txt";
            string zeile;

            if (!File.Exists(dateiname))
            {
                MessageBox.Show("Datei " + dateiname + "existiert nicht");
                return;
            }

            fs = new FileStream(dateiname, FileMode.Open);
            sr = new StreamReader(fs);

            while (sr.Peek() != -1)
            {
                zeile = sr.ReadLine();

                listBox1.Items.Add(zeile);

            }
            sr.Close();
        }
    }
}
