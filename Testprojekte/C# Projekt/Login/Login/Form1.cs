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

namespace Login
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;
        //private List<int> pnummer = new List<int>();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                   "Data Source=E:\\Informatikausbildung\\C Sharp\\C# Projekt\\Benutzerdaten.accdb";
            cmd.Connection = con;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Auslesen();
        }

        private void Auslesen()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM Benutzerdaten";
                Ausgabe();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

        }

        private void Ausgabe()
        {
            reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                listBox1.Items.Add(reader["User"] + " # " +
                    reader["Passwort"] + " # ");
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;

            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Benutzerdaten (User, Passwort) VALUES ('" + txtName.Text + "' '" +  txtPw.Text + "')";

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
            Auslesen();
        }
    }
}
