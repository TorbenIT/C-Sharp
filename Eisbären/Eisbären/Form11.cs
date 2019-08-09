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
    public partial class Form11 : Form
    {
        private Form1 fh;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;
        List<int> spnummer = new List<int>();

        public Form11(Form1 aufrufer)
        {
            fh = aufrufer;
            InitializeComponent();
        }



        private void cmdsuchen_Click(object sender, EventArgs e)
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Logindaten.accdb";
            cmd.Connection = con;

            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM Person Where " +
                    "Nachname LIKE '%" + Nachname.Text + "%'";

                MessageBox.Show(cmd.CommandText);

                AusgabeListBox2();

                // spnummer.Clear();
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }


            con.Close();

        }

        private void AusgabeListBox2()
        {
            reader = cmd.ExecuteReader();
            listBox2.Items.Clear();
            spnummer.Clear();

            while (reader.Read())
            {
                listBox2.Items.Add(reader["ID"] + ", " +
                    reader["Nachname"] + ", " +
                    reader["Vorname"] + ", " +
                    reader["Ort"] + ", " +
                    reader["Spendenbetrag"]);
                spnummer.Add((int)reader["ID"]);
            }
            reader.Close();


        }

        private void cmddelete_Click(object sender, EventArgs e)
        {
            if (this.listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte einen Datensatz aus der Listbox auswählen");
                return;
            }

            if (MessageBox.Show("Wollen Sie den ausgewählten Datensatz wirklich löschen?", "Löschen", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
  
                
                con.Open();
                cmd.CommandText = "DELETE FROM Person WHERE " +
                    "ID = " + spnummer[listBox2.SelectedIndex];
                cmd.ExecuteNonQuery();

                MessageBox.Show(cmd.CommandText);

                MessageBox.Show("Spende gelöscht.");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void cmdupdate_Click(object sender, EventArgs e)
        {
            if (this.listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte einen Datensatz aus der Listbox auswählen");
                return;
            }

            if (MessageBox.Show("Wollen Sie den ausgewählten Datensatz wirklich löschen?", "Löschen", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                con.Open();

                cmd.CommandText = "UPDATE Person SET Spendenbetrag = '" + textBoxSpende.Text +
                    "' WHERE " + "ID = " + spnummer[listBox2.SelectedIndex];

                MessageBox.Show(cmd.CommandText);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Spendenbetrag geändert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                MessageBox.Show("Bitte einen Datensatz aus der Listbox auswählen, sofern keiner vorhanden ist, bitte zunächst einen neuen" +
                    "Spendenaccount anlegen");
            }
            con.Close();

        }

        private void cmdhilfe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zunächst suchen Sie Ihren Spendenaccount, indem Sie Ihren Nachname in die Textbox auf der linken " +
                "Bildschirmseite eingeben und auf Suchen drücken, sofern Ihr Account in der Datenbank hinterlegt ist, wird " +
                "dieser in der darunterliegenden Listbox angezeigt. Nun klicken (markieren) Sie auf Ihrem Datensatz in der " +
                "Listbox und geben einen neuen Spendenbetrag auf der rechten Bildschirmseite in die Textbox Spendenbetrag ein " +
                "und klicken auf ändern.");
        }
    }
}
