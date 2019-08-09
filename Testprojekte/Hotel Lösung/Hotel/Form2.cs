using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Formrechnung : Form
    {
        FormHotel fh;
        public Formrechnung(FormHotel aufrufer)
        {
            fh = aufrufer;
            InitializeComponent();
        }

        private void Formrechnung_Load(object sender, EventArgs e)
        {
            labelname.Text = fh.Controls["textBoxname"].Text;
            labelID.Text = fh.Controls["textBoxID"].Text;
            labelzimmer.Text = fh.Controls["textBoxzimmernummer"].Text;
            labelankunft.Text = fh.Controls["textBoxankunft"].Text;
            labelabfahrt.Text = fh.Controls["textBoxabfahrt"].Text;

            DateTime d1 = Convert.ToDateTime(labelankunft.Text);
            DateTime d2 = Convert.ToDateTime(labelabfahrt.Text);

            int tage;
            double betrag;

            System.TimeSpan DiffTage = d2 - d1;
            tage = DiffTage.Days ;
            labelnächte.Text = Convert.ToString(tage);
            betrag = tage * 44 * 1.19;
            labelbetrag.Text = String.Format("Ihr Rechnungsbetrag beträgt {0} Euro.", betrag);

        }
    }
}
