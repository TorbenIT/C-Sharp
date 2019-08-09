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
    public partial class Form5 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;

        public Form5()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = Zeiterfassung.accdb";
            cmd.Connection = con;
            cmd.CommandText = "SELECT ID, Benutzer, ErsterTag, LetzterTag, Art FROM Freitage";

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                listBoxFreitage.Items.Clear();
                while (reader.Read())
                {
                    listBoxFreitage.Items.Add(
                        reader["ID"] + "/" +
                        reader["Benutzer"] + "/" +
                        reader["ErsterTag"] + "/" +
                        reader["LetzterTag"] + "/" +
                        reader["Art"]);
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
            textBoxErst.Text = "";
            textBoxLetzt.Text = "";
            textBoxArt.Text = "";
        }

        private void listBoxFreitage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] teil;
            string eingabe;

            if (listBoxFreitage.SelectedIndex != -1)
            {
                eingabe = listBoxFreitage.SelectedItem.ToString();
                teil = eingabe.Split('/');

                textBoxID.Text = teil[0];
                textBoxBenutzer.Text = teil[1];
                textBoxErst.Text = teil[2];
                textBoxLetzt.Text = teil[3];
                textBoxArt.Text = teil[4];
            }
        }

        private void buttonAndern_Click(object sender, EventArgs e)
        {
            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=Zeiterfassung.accdb";
            cmd.Connection = con;

            int x = listBoxFreitage.SelectedIndex;
            if (x != -1)
                listBoxFreitage.Items.RemoveAt(x);

            String dsneu;
            dsneu = textBoxID.Text + '/' + textBoxBenutzer.Text + '/' + textBoxErst.Text + '/' + textBoxLetzt.Text + '/' + textBoxArt.Text;
            listBoxFreitage.Items.Add(dsneu);

            cmd.CommandText = "UPDATE Freitage SET Benutzer = '" +
                textBoxBenutzer.Text + "', ErsterTag = '" +
                textBoxErst.Text + "', LetzterTag = '" +
                textBoxLetzt.Text + "', Art = '" +
                textBoxArt.Text + "' WHERE ID = " +
                textBoxID.Text + "";
        }

        private void buttonLoschen_Click(object sender, EventArgs e)
        {
            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=Zeiterfassung.accdb";
            cmd.Connection = con;

            int x = listBoxFreitage.SelectedIndex;
            if (x != -1)
                listBoxFreitage.Items.RemoveAt(x);

            textBoxID.Text = "";
            textBoxBenutzer.Text = "";
            textBoxErst.Text = "";
            textBoxLetzt.Text = "";
            textBoxArt.Text = "";

            cmd.CommandText = "DELETE * FROM Freitage WHERE ID = " +
                textBoxID.Text + "";
        }
    }
}

