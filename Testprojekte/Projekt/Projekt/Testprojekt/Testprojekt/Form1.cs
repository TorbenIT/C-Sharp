using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testprojekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected int currentColorIndex;
        protected String[] colors = { "Red", "Blue", "Green", "Yellow" };

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                if (IsPostBack)
                {
                    currentColorIndex =
                        Int16.Parse(ViewState["currentColorIndex"].ToString());
                }
                else
                {
                    currentColorIndex = 0;
                    DisplayColor();
                }
            }
        }

        protected void DisplayColor()
        {
            textColor.Text = colors[currentColorIndex];
            ViewState["currentColorIndex"] = currentColorIndex.ToString();
        }

        protected void buttonUp_Click(object sender, EventArgs e)
        {
            if (currentColorIndex == 0)
            {
                currentColorIndex = colors.Length - 1;
            }
            else
            {
                currentColorIndex -= 1;
            }
            DisplayColor();
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            if (currentColorIndex == (colors.Length - 1))
            {
                currentColorIndex = 0;
            }
            else
            {
                currentColorIndex += 1;
            }
            DisplayColor();
        }
    }
}
