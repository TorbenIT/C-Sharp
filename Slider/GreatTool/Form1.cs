using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreatTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelRegister.Height = buttonUp.Height;
            panelRegister.Top = buttonUp.Top;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            panelRegister.Height = buttonUp.Height;
            panelRegister.Top = buttonUp.Top;
        }

        private void buttonMid_Click(object sender, EventArgs e)
        {
            panelRegister.Top = buttonMid.Top;
            panelRegister.Height = buttonMid.Height;
        }


        private void buttonDown_Click_1(object sender, EventArgs e)
        {
            panelRegister.Height = buttonDown.Height;
            panelRegister.Top = buttonDown.Top;
        }
    }
}
