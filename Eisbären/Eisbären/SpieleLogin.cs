using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eisbären
{
    public partial class SpieleLogin : Form
    {
        Form1 fh;
        public SpieleLogin(Form1 aufrufer)
        {
            fh = aufrufer;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Snake fr = new Snake(this);
            fr.ShowDialog();
        }
    }
}
