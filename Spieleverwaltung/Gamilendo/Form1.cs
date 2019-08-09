using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamilendo
{
   
    public partial class Form1 : Form
    {
        public Form1( )
        {
            InitializeComponent();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kunde ku = new Kunde(); //Ein neues Objekt der Userform Kunde wird erzeugt
            ku.ShowDialog();//Die Userform wird aufgerufen
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Konsole ko = new Konsole();
            ko.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Spiele sp = new Spiele();
            sp.ShowDialog();
        }

        private void kundeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kunde ku = new Kunde();
            ku.ShowDialog();
        }

        private void konsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Konsole ko = new Konsole();
            ko.ShowDialog();
        }

        private void spieleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spiele sp = new Spiele();
            sp.ShowDialog();
        }

        private void btMiete_Click(object sender, EventArgs e)
        {
            Vermietung vm = new Vermietung();
            vm.ShowDialog();
        }

        private void vermietungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Vermietung vm = new Vermietung();
            vm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
