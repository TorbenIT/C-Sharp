using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI;
using System.Web.UI.WebCOntrols;

namespace TimeYourCompany
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string lastName = textBoxNN.Text;
            Session["name"] = lastName;

            Form1 fr = new Form1(this, textBoxVN.Text, textBoxNN.Text);
            fr.ShowDialog();
        }

        private void btnOpenChat_Click(object sender, EventArgs e)
        {
            Server fr = new Server(this);
            fr.ShowDialog();
        }
    }
}
