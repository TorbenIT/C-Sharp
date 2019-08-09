using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeiterfassungstool
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form FrmAnmelden = new Zeiterfassungstool2.Anmelden();
            FrmAnmelden.Show();
            this.Hide();
           /* FormVerwaltung frm1 = new FormVerwaltung();
            frm1.Show();
            this.Hide();*/
        }

        private void buttonFreitage_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void buttonGruppe_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();
        }

        private void buttonFreiart_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Hide();
        }

        private void buttonFeiertage_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }

        private void TBBV_Click(object sender, EventArgs e)
        {
            Form frm = new Zeiterfassungstool2.Benutzerverwaltung();
            frm.Show();
            this.Hide();
        }
    }
}
