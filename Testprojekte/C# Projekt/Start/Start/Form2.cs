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
using System.Data.OleDb;
using Microsoft.VisualBasic;

namespace Start
{
    public partial class Form2 : Form
    {
      
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
       
        //private List<int> pnummer = new List<int>();



        public Form2()
        {
            
            InitializeComponent();
        }

        private void buttonEinführung_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr;
            string dateiname = "Wissenswertes.txt";
            string zeile;

            if (!File.Exists(dateiname))
            {
                MessageBox.Show("Datei " + dateiname + "existiert nicht");
                return;
            }

            fs = new FileStream(dateiname, FileMode.Open);
            sr = new StreamReader(fs);

            while (sr.Peek() != -1)
            {
                zeile = sr.ReadLine();

                MessageBox.Show(zeile);
            }
            sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=E:\\Informatikausbildung\\Benutzerdaten.accdb";
            cmd.Connection = con;

        }

        private void buttonAnmeldung_Click(object sender, EventArgs e)
        {
            int i;

            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Benutzerdaten (User, Passwort) VALUES ('" + textBoxName.Text + "', '" + textBoxPasswort.Text + "')";

                MessageBox.Show(cmd.CommandText);

                i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Ein Datensatz eingefügt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Keine Eingaben!");
            }

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string eingabe;

            eingabe = Interaction.InputBox("Ihr Spendenbetrag: ", "Geben Sie den Betrag ein, den Sie spenden möchten!");

            label7.Text = "";

            label7.Text = eingabe;
        }

    }

}
