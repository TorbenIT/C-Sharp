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
    public partial class Form7 : Form
    {
        private Form1 fh;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader reader;
       // private List<int> spnummer = new List<int>();
        public Form7(Form1 aufrufer)
        {
            fh = aufrufer;
            InitializeComponent();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Logindaten.accdb";
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM Person";
                Ausgabe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            con.Close();
        }

        private void Ausgabe()
        {
            reader = cmd.ExecuteReader();
            listBox1.Items.Clear();
            // spnummer.Clear();

            while (reader.Read())
            {
                listBox1.Items.Add(reader["Nachname"] + "          " +
                    reader["Vorname"] );
            }
            reader.Close();
        }


    }
}
