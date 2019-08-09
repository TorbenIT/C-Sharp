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
    public partial class Form10 : Form
    {
        // Neue Daten anlegen mit Insert
        // Mit Hilfe von https://www.youtube.com/watch?v=hSpgOn-Z2iM

        private OleDbConnection con;
        private OleDbCommand sql;
        private Form4 fh;
        public Form10(Form4 aufrufer)
        {
            fh = aufrufer;
            InitializeComponent();
            String connect = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=Logindaten.accdb";
            con = new OleDbConnection(connect);

            //sql.CommandText = "insert into person(name, spende)" +
            //    " values('tmp', 45);";
            //sql.ExecuteNonQuery();
   
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            textBox1.Text = fh.Controls["TxtUser"].Text;
        }

        private void buttonspenden_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                sql = con.CreateCommand();

                //textBoxGeld.Text = String.Format("{0:C}", textBoxGeld);

                sql.CommandText = "INSERT INTO Person (nachname, vorname, straße, ort, Lieblingszahl, spendenbetrag, geburtsdatum) VALUES ('" +
                textBoxNachname.Text + "', '" + textBoxVorname.Text + "', '" +
                textBoxStraße.Text + "', '" + textBoxOrt.Text + "', " +
                textBoxZahl.Text + ", " + textBoxGeld.Text.Replace(',', '.') + ", '" + textBoxGeb.Text + "')";

                sql.ExecuteNonQuery();
                MessageBox.Show(sql.CommandText);
                MessageBox.Show("Sie sind erfolgreich in der Spenderkartei gespeichert. 😊 ");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bitte alle Felder ausfüllen!");
            }

            con.Close();

        }
    }
}
