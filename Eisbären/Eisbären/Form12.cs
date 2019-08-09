using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Session;
using System.Data.OleDb;


namespace Eisbären
{
    public partial class Form12 : Form
    {
        Broker b = new Broker();

        Form1 fh;

        private OleDbConnection con = new OleDbConnection();
        //OleDbDataAdapter da;


        //DataTable dt = new DataTable();
        public Form12(Form1 aufrufer)
        {
            fh = aufrufer;
            InitializeComponent();

            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                                "Data Source=Logindaten.accdb";
        }

        private void buttonaddtocombo_Click(object sender, EventArgs e)
        {
            comboBoxshop.DataSource = b.FillComboBox();
        }

        private void buttonaddtolstbox_Click(object sender, EventArgs e)
        {
            listBoxshop.Items.Add(comboBoxshop.SelectedItem);
        }

        private void buttonbuy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxuser.Text))
            {
                MessageBox.Show("Angaben unvollständig!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBoxuser.Focus();

                return;
            }

            try
            {
                con.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
                command.CommandText = "SELECT * FROM Benutzer WHERE Nick='" + textBoxuser.Text + "' AND Passwort='" + textBoxpassw.Text + "'";

                OleDbDataReader reader = command.ExecuteReader();

                int count = 0;

                while (reader.Read())
                {
                    count = count + 1;
                    //count++;
                    //
                }
                if (count == 1)
                /* stackoverflow.com */

                {
                    string selected = this.listBoxshop.GetItemText(this.listBoxshop.SelectedItem);

                    OleDbConnection conn = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                                    "Data Source=Logindaten.accdb";



                    OleDbCommand cmd = new OleDbCommand("INSERT into Person (gekauft) Values(@bought)");
                    cmd.Connection = conn;

                    conn.Open();

                    if (conn.State == ConnectionState.Open)
                    {
                        cmd.Parameters.Add("@bought", OleDbType.VarChar).Value = selected;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Artikel gekauft");
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Connection Failed");
                    }

                    /* */

                }
                else
                {
                    MessageBox.Show("Benutzername oder Passwort falsch!");
                }


                con.Close();


            }
            catch
            {
                MessageBox.Show("Herr Merchel ist natürlich ein guter Lehrer! 😉");
            }

        }
    }
}

