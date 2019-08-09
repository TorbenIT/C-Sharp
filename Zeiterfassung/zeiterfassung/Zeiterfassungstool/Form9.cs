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
    public partial class Form9 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxBenutzer.Text = "";
            textBoxErst.Text = "";
            textBoxLetzt.Text = "";
            textBoxArt.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void buttonAnlegen_Click(object sender, EventArgs e)
        {
            String dsneu;
            dsneu = textBoxID.Text + '/' + textBoxBenutzer.Text + '/' + textBoxErst.Text + '/' + textBoxLetzt.Text + '/' + textBoxArt.Text;
            listBoxFreitage.Items.Add(dsneu);

            
            int anzahl;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=Zeiterfassung.accdb";
            cmd.Connection = con;

            con.Open();
            cmd.CommandText =
                "INSERT INTO Freitage " +
                "(ID, Benutzer, ErsterTag, LetzterTag, Art) VALUES('" +
                textBoxID.Text + "' , '" +
                textBoxBenutzer.Text + "' , '" +
                textBoxErst.Text + "' , '" +
                textBoxLetzt.Text + "' , '" +
                textBoxArt.Text + "')";
            //MessageBox.Show(cmd.CommandText);
            anzahl = cmd.ExecuteNonQuery();
            
        }

        private void buttonLoschen_Click(object sender, EventArgs e)
        {
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
