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
    public partial class Form12 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;

        public Form12()
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
            textBoxID.Text = "";
            textBoxErst.Text = "";
            textBoxLetzt.Text = "";
        }

        private void buttonLoschen_Click(object sender, EventArgs e)
        {
            int x = listBoxFeiertage.SelectedIndex;
            if (x != -1)
                listBoxFeiertage.Items.RemoveAt(x);

            textBoxID.Text = "";
            textBoxErst.Text = "";
            textBoxLetzt.Text = "";

            cmd.CommandText = "DELETE * FROM Feiertage WHERE ID = " +
                textBoxID.Text + "";
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = Zeiterfassung.accdb";
            cmd.Connection = con;
            cmd.CommandText = "SELECT ID, ErsterTag, LetzterTag FROM Feiertage";

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                listBoxFeiertage.Items.Clear();
                while (reader.Read())
                {
                    listBoxFeiertage.Items.Add(
                        reader["ID"] + "/" +
                        reader["ErsterTag"] + "/" +
                        reader["LetzterTag"]);
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxFeiertage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] teil;
            string eingabe;

            if (listBoxFeiertage.SelectedIndex != -1)
            {
                eingabe = listBoxFeiertage.SelectedItem.ToString();
                teil = eingabe.Split('/');

                textBoxID.Text = teil[0];
                textBoxErst.Text = teil[1];
                textBoxLetzt.Text = teil[2];
            }
        }

        private void buttonAnlegen_Click(object sender, EventArgs e)
        {
            String dsneu;
            dsneu = textBoxID.Text + '/' + textBoxErst.Text + '/' + textBoxLetzt.Text;
            listBoxFeiertage.Items.Add(dsneu);


            int anzahl;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=Zeiterfassung.accdb";
            cmd.Connection = con;

            con.Open();
            cmd.CommandText =
                "INSERT INTO Feiertage " +
                "(ID, ErsterTag, LetzterTag) VALUES('" +
                textBoxID.Text + "' , '" +
                textBoxErst.Text + "' , '" +
                textBoxLetzt.Text + "')";
            //MessageBox.Show(cmd.CommandText);
            anzahl = cmd.ExecuteNonQuery();
        }
    }
}
