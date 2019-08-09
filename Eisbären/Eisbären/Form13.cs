using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Session;

namespace Eisbären
{
    public partial class Form13 : Form
    {
        Broker b = new Broker();

        

        Form1 fh;
        public Form13(Form1 aufrufer)
        {
            fh = aufrufer;
            InitializeComponent();

            
        }

        private void buttonunloadme_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void buttonaddtoaccess_Click(object sender, EventArgs e)
        {
            double db = Convert.ToDouble(textBoxprice.Text);

            Artikel a = new Artikel();
            a.Bezeichnung = textBoxdescription.Text;
            a.Price = db;

            b.Insert(a);
            MessageBox.Show("Ihr Artikel wurde erfolgreich angelegt.");
        }

        //private void textBoxprice_TextChanged(object sender, EventArgs e)
        //{
        //    /* stackoverflow.com */

        //    //Remove previous formatting, or the decimal check will fail including leading zeros
        //    string value = textBoxprice.Text.Replace(",", "")
        //        .Replace("$", "").Replace(".", "").TrimStart('0');
        //    decimal ul;
        //    //Check we are indeed handling a number
        //    if (decimal.TryParse(value, out ul))
        //    {
        //        ul /= 100;
        //        //Unsub the event so we don't enter a loop
        //        textBoxprice.TextChanged -= textBoxprice_TextChanged;
        //        //Format the text as currency
        //        textBoxprice.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C2}", ul);
        //        textBoxprice.TextChanged += textBoxprice_TextChanged;
        //        textBoxprice.Select(textBoxprice.Text.Length, 0);
        //    }
        //    bool goodToGo = TextisValid(textBoxprice.Text);
        //    buttonaddtoaccess.Enabled = goodToGo;
        //    if (!goodToGo)
        //    {
        //        textBoxprice.Text = "$0.00";
        //        textBoxprice.Select(textBoxprice.Text.Length, 0);
        //    }
        //}

        //private bool TextisValid(string text)
        //{
        //    // stackoverflow.com
        //    Regex money = new Regex(@"^\$(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$");
        //    return money.IsMatch(text);
        //}

    }
}
