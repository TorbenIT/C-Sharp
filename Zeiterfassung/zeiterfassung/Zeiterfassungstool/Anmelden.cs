using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Zeiterfassungstool2
{
    public partial class Anmelden : Form
    {
        public Anmelden()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Anzahl = 0;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;

            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source = Zeiterfassung.accdb";
            cmd.Connection = con;
            cmd.CommandText = "Select Anmeldename, Passwort from Benutzer";


            con.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if ((Convert.ToString(reader["Anmeldename"]) == TBAnmelden.Text) && (Convert.ToString(reader["Passwort"]) == TBPasswort.Text))
                {
                    this.Hide();
                    Form Frm3 = new Zeiterfassungstool.Form3();
                    Frm3.Show();
                    this.Hide();
                    Anzahl++;
                }



            }

            if (Anzahl == 0)
            {
                string message = "Die von Ihnen eingegebenen Daten sind leider ungültig";
                string caption = "Falscheingabe";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }

            con.Close();
        }
          
    }
}
