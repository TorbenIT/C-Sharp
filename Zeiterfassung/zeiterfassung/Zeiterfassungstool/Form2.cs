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
    public partial class Form2 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormVerwaltung frm1 = new FormVerwaltung();
            frm1.Show();
            this.Hide();
        }

        private void buttonLesen_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = Zeiterfassung.accdb";
            cmd.Connection = con;
            cmd.CommandText = "SELECT u.ID, u.Benutzer, u.ErsterTag, u.LetzterTag, u.Art, f.ID, f.ErsterTag, f.LetzterTag FROM Freitage AS u, Feiertage AS f";

            listBoxFreitage.Items.Clear();
            listBoxFeiertage.Items.Clear();

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listBoxFreitage.Items.Add(
                        reader["u.ID"] + "/" +
                        reader["Benutzer"] + "/" +
                        reader["u.ErsterTag"] + "/" +
                        reader["u.LetzterTag"] + "/" +
                        reader["Art"]);

                    listBoxFeiertage.Items.Add(
                        reader["f.ID"] + "/" +
                        reader["f.ErsterTag"] + "/" +
                        reader["f.LetzterTag"]);
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
