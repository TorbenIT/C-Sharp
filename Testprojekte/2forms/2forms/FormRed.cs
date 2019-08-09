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
    public partial class FormRed : Form
    {
        Formcontinue fc;
        public FormRed(Formcontinue aufrufer)
        {
            fc = aufrufer;
            InitializeComponent();
        }

        private void FormRed_Load(object sender, EventArgs e)
        {
            textBoxuser.Text = fc.Controls["textBoxuser"].Text;
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
