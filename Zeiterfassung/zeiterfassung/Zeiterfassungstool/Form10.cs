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
    public partial class Form10 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;

        public Form10()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void listBoxBenutzer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] teil;
            string eingabe;

            if (listBoxGruppe.SelectedIndex != -1)
            {
                eingabe = listBoxGruppe.SelectedItem.ToString();
                teil = eingabe.Split('/');

                textBoxGruppe.Text = teil[0];
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = Zeiterfassung.accdb";
            cmd.Connection = con;
            cmd.CommandText = "SELECT Bezeichnung FROM Gruppe";

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                listBoxGruppe.Items.Clear();
                while (reader.Read())
                {
                    listBoxGruppe.Items.Add(
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxGruppe.Text = "";
        }

        private void buttonLoschen_Click(object sender, EventArgs e)
        {
            int x = listBoxGruppe.SelectedIndex;
            if (x != -1)
                listBoxGruppe.Items.RemoveAt(x);

            textBoxGruppe.Text = "";

            cmd.CommandText = "DELETE * FROM Gruppe WHERE Bezeichnung = " +
                textBoxGruppe.Text + "";
        }

        private void buttonAnlegen_Click(object sender, EventArgs e)
        {
            int anzahl;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=Zeiterfassung.accdb";
            cmd.Connection = con;

            con.Open();
            cmd.CommandText =
                "INSERT INTO Gruppe " +
                "(Bezeichnung) VALUES('" +
                textBoxGruppe.Text + "')";
            //MessageBox.Show(cmd.CommandText);
            anzahl = cmd.ExecuteNonQuery();
        }
    }
}
