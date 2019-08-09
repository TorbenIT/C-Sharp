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

namespace Eisbären
{
    public partial class Form4 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();

        private Form1 fh;
        public Form4(Form1 aufrufer)
        {
            fh = aufrufer;
            InitializeComponent();
        }

        public Form4()
        {

        }


        private void button2_Click(object sender, EventArgs e)
          {
            // mit Hilfe von stackoverflow.com , nachdem das allgegenwärtige vom Lehrer gekaufte C# Handbuch 
            // nichts nutzte und der Lehrer mit seinen unglaublichen Fähigkeiten mir nicht helfen konnte

            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Logindaten.accdb";

            String Username = TxtUser.Text;
            String Password = TxtPw.Text;



            OleDbCommand cmd = new OleDbCommand("INSERT into Benutzer (Nick, Passwort) Values(@Username, @Password)");
            cmd.Connection = conn;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.Add("@Username", OleDbType.VarChar).Value = Username;
                cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = Password;
   
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Benutzer angelegt");

                    Form10 fr = new Form10(this);
                    fr.Show();

                   // using (Form10 transfer = new Form10())
                    //{
                      //  if (transfer.ShowDialog() == DialogResult.OK)
                       // {
                         //   TxtUser.Text = transfer.TheValue;
                        //}
                    //}



                    conn.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Source);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}



 
