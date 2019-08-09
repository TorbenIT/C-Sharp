using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hotel
{
    public partial class FormHotel : Form
    {
        public FormHotel()
        {
            InitializeComponent();
            buttonzulistbox.Visible = false;
        }

        private void buttoneinlesen_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream ("Hotel.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string zeile;

            while (sr.Peek () != -1)
            {
                zeile = sr.ReadLine();
                listBoxausgabe.Items.Add(zeile);
            }
            listBoxausgabe.SelectedIndex = 0;
            sr.Close();
        }

        private void buttonzurückschreiben_Click(object sender, EventArgs e)
        {
            int i;
            FileStream fs = new FileStream("Hotel.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (i = 0; i < listBoxausgabe.Items.Count; i++)
                  sw.WriteLine(listBoxausgabe.Items[i]);
            sw.Close();
              }

        private void buttonlöschenzeile_Click(object sender, EventArgs e)
        {
            int x = listBoxausgabe.SelectedIndex;
            if (x != -1)
                listBoxausgabe.Items.RemoveAt(x);
        }
        

        private void listBoxausgabe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] teil;
            string eingabe;

            if (listBoxausgabe.SelectedIndex != -1)
            { 
            eingabe = listBoxausgabe.SelectedItem.ToString();
            teil = eingabe.Split('#');

            textBoxID.Text = teil[0];
            textBoxname.Text = teil[1];
            textBoxankunft.Text = teil[2];
            textBoxabfahrt.Text = teil[3];
            textBoxzimmernummer.Text = teil[4];
        }
            
        }



        private void buttonneu_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxname.Text = "";
            textBoxankunft.Text = "";
            textBoxabfahrt.Text = "";
            textBoxzimmernummer.Text = "";

        }

        private void buttonzuTextbox_Click(object sender, EventArgs e)
        {
            String dsneu;
            dsneu = textBoxID.Text + '#' + textBoxname.Text + '#' + textBoxankunft.Text + '#' + textBoxabfahrt.Text + '#' + textBoxzimmernummer.Text;
            listBoxausgabe.Items.Add (dsneu);
        }

        private void buttonprüfen_Click(object sender, EventArgs e)
        {
            string[] teil;
            string eingabe;
            int i;
            string zimmer;
            string ankunft;
            string abfahrt;
            

            for (i = 0; i < listBoxausgabe.Items.Count; i++)
            {
                eingabe = listBoxausgabe.Items [i].ToString();
                teil = eingabe.Split('#');
                zimmer = teil[4];
                ankunft = teil[2];
                abfahrt = teil[3];
                

                if (textBoxzimmernummer.Text == zimmer) // = Zuweisung  == Vergleich
                {
                    if ((Convert.ToDateTime(textBoxabfahrt.Text) > Convert.ToDateTime(ankunft)) && (Convert.ToDateTime(textBoxankunft.Text) < Convert.ToDateTime(abfahrt)))
                    {
                        MessageBox.Show("Buchung nicht möglich! Doppelbelegung!");
                        textBoxankunft.Text = "";
                        textBoxabfahrt.Text = "";
                        break;
                    }
                    else
                        buttonzulistbox.Visible = true;
                }
            }
        }
    }
}