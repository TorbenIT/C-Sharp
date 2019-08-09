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
    public partial class FormGreen : Form
    {
        Formcontinue fc;
        public FormGreen(Formcontinue aufrufer)
        {
            fc = aufrufer;
            InitializeComponent();
        }

        private void FormGreen_Load(object sender, EventArgs e)
        {
            textBoxuser.Text = fc.Controls["textBoxuser"].Text;
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
