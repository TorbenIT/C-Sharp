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
    public partial class Form6 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;

        public Form6()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void listBoxFreitage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] teil;
            string eingabe;

            if (listBoxBenutzer.SelectedIndex != -1)
            {
                eingabe = listBoxBenutzer.SelectedItem.ToString();
                teil = eingabe.Split('/');

                textBoxID.Text = teil[0];
                textBoxBenutzer.Text = teil[1];
                textBoxGruppe.Text = teil[2];
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = Zeiterfassung.accdb";
            cmd.Connection = con;
            cmd.CommandText = "SELECT ID, Anmeldename, Gruppe FROM Benutzer";

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                listBoxBenutzer.Items.Clear();
                while (reader.Read())
                {
                    listBoxBenutzer.Items.Add(
                        reader["ID"] + "/" +
                        reader["Anmeldename"] + "/" +
                        reader["Gruppe"]);
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
            textBoxID.Text = "";
            textBoxBenutzer.Text = "";
            textBoxGruppe.Text = "";
        }

        private void buttonLoschen_Click(object sender, EventArgs e)
        {
            int x = listBoxBenutzer.SelectedIndex;
            if (x != -1)
                listBoxBenutzer.Items.RemoveAt(x);

            textBoxID.Text = "";
            textBoxBenutzer.Text = "";
            textBoxGruppe.Text = "";

            cmd.CommandText = "DELETE * FROM Benutzer WHERE ID = " +
                textBoxID.Text + "";
        }

        private void buttonAndern_Click(object sender, EventArgs e)
        {
            int x = listBoxBenutzer.SelectedIndex;
            if (x != -1)
                listBoxBenutzer.Items.RemoveAt(x);

            String dsneu;
            dsneu = textBoxID.Text + '/' + textBoxBenutzer.Text + '/' + textBoxGruppe.Text;
            listBoxBenutzer.Items.Add(dsneu);

            cmd.CommandText = "UPDATE Benutzer SET Anmeldename = '" +
                textBoxBenutzer.Text + "', Gruppe = '" +
                textBoxGruppe.Text + "' WHERE ID = " +
                textBoxID.Text + "";
        }
    }
}
