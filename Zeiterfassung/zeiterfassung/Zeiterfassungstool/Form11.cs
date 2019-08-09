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

namespace Zeiterfassungstool
{
    public partial class Form11 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;

        public Form11()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxArt.Text = "";
        }

        private void buttonLoschen_Click(object sender, EventArgs e)
        {
            int x = listBoxFreitagearten.SelectedIndex;
            if (x != -1)
                listBoxFreitagearten.Items.RemoveAt(x);

            
            textBoxArt.Text = "";

            cmd.CommandText = "DELETE * FROM FreiArt WHERE Bezeichnung = " +
                textBoxArt.Text + "";
        }

        private void buttonAnlegen_Click(object sender, EventArgs e)
        {
            String dsneu;
            dsneu = textBoxArt.Text;
            listBoxFreitagearten.Items.Add(dsneu);


            int anzahl;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=Zeiterfassung.accdb";
            cmd.Connection = con;

            con.Open();
            cmd.CommandText =
                "INSERT INTO FreiArt " +
                "(Bezeichnung) VALUES('" +
                textBoxArt.Text + "')";
            //MessageBox.Show(cmd.CommandText);
            anzahl = cmd.ExecuteNonQuery();
        }

        private void listBoxFreitagearten_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] teil;
            string eingabe;

            if (listBoxFreitagearten.SelectedIndex != -1)
            {
                eingabe = listBoxFreitagearten.SelectedItem.ToString();
                teil = eingabe.Split('/');

                textBoxArt.Text = teil[0];
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = Zeiterfassung.accdb";
            cmd.Connection = con;
            cmd.CommandText = "SELECT Bezeichnung FROM FreiArt";

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                listBoxFreitagearten.Items.Clear();
                while (reader.Read())
                {
                    listBoxFreitagearten.Items.Add(
                        reader["Bezeichnung"]);
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
