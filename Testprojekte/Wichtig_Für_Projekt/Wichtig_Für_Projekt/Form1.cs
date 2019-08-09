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


namespace Wichtig_Für_Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoneinlesen_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;

            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source = hotel.accdb";
            cmd.Connection = con;
            cmd.CommandText = "Select * FROM Buchung";

            con.Open();
            reader = cmd.ExecuteReader();
            listBoxausgabe.Items.Clear();

            while (reader.Read())
            {
                listBoxausgabe.Items.Add(reader["BuchungsID"] + "#" +
                               reader["Name"] + "#" +
                               string.Format("{0:d}", reader["Ankunft"]) + "#" +
                               string.Format("{0:d}", reader["Abfahrt"]) + "#" +
                               reader["Zimmernummer"]);
            }
            reader.Close();
            con.Close();
        }

        private void buttonzurückschreiben_Click(object sender, EventArgs e)
        {
            int anzahl;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source = hotel.accdb";
            cmd.Connection = con;

            con.Open();
            cmd.CommandText =
                "INSERT INTO Buchung " +
                "(BuchungsID, Name, Ankunft, Abfahrt, Zimmernummer) VALUES('" +
                textBoxID.Text + "','" +
                textBoxname.Text + "','" +
                textBoxankunft.Text + "','" +
                textBoxabfahrt.Text + "','" +
                textBoxzimmernummer.Text + "')";

            MessageBox.Show(cmd.CommandText);

            anzahl = cmd.ExecuteNonQuery();
        }
    }
}
