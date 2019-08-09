using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2forms
{
    public partial class Formcontinue : Form
    {
        Formlogin fl;
        public Formcontinue(Formlogin aufrufer)
        {
            fl = aufrufer;
            InitializeComponent();

        }

        private void Formcontinue_Load(object sender, EventArgs e)
        {
            textBoxuser.Text = fl.Controls["textBoxbenutzer"].Text;
        }

        private void buttonred_Click(object sender, EventArgs e)
        {
            FormRed fr = new FormRed(this);
            fr.ShowDialog();
        }

        private void buttonorange_Click(object sender, EventArgs e)
        {
            FormOrange fo = new FormOrange(this);
            fo.ShowDialog();
        }

        private void buttongreen_Click(object sender, EventArgs e)
        {
            FormGreen fg = new FormGreen(this);
            fg.ShowDialog();
        }
    }
}
