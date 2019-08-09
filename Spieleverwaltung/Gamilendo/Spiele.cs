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

namespace Gamilendo
{
    //Die Kommentare aus den Userforms "Kunden" und "Konsolen" können auch hier angewandt werden.
    // Es wurden lediglich die SQL-Strings und Textboxen angepasst
    //Quelle: C#-Buch
    public partial class Spiele : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader reader;
        private List<int> id = new List<int>();
        public Spiele()
        {
            InitializeComponent();
        }  
        private void Spiele_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Gamilendo.accdb";
            cmd.Connection = con;
        }
        private void kundeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kunde ku = new Kunde();
            ku.ShowDialog();
        }

        private void konsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Konsole ko = new Konsole();
            ko.ShowDialog();
        }

        private void spieleToolStripMenuItem_Click(object sender, EventArgs e)
        {          
        }
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAlleSehen_Click(object sender, EventArgs e)
        {
            AlleSehen();
        }

        private void AlleSehen()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM spiele";
                Ausgabe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            txtMarke.Text = "";
            txtName.Text = "";
            txtNotizen.Text = "";
            txtPlatform.Text = "";
            txtPreis.Text = "";
            txtRueckgabe.Text = "";
            txtVerfuegbar.Text = "";
        }

        private void Ausgabe()
        {
            DateTime rueckgabe;
            reader = cmd.ExecuteReader();
            lstAnzeige.Items.Clear();
            id.Clear();
            while (reader.Read())
            {
                rueckgabe = Convert.ToDateTime(reader["rueckgabe"]);

                lstAnzeige.Items.Add(reader["name"] + " # " +
                    reader["marke"] + " # " +
                    reader["preis"] + "€ # " +
                    reader["verfuegbar"] + " # " +
                    reader["plattform"] + " # " +
                    reader["rueckgabe"] + " # " +
                    reader["notizen"] + " # " +
                    rueckgabe.ToShortDateString());
                id.Add((int)reader["ID"]);
            }
            reader.Close();

        }

        private void btEinfuegen_Click(object sender, EventArgs e)
        {
            int anzahl;
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO spiele (name,marke,preis,verfuegbar,plattform,rueckgabe,notizen) VALUES ('" + txtName.Text + "','" + txtMarke.Text + "','" + txtPreis.Text.Replace(',', '.') + "','" + txtVerfuegbar.Text + "','" + txtPlatform.Text + "','" + txtRueckgabe.Text + "','" + txtNotizen.Text + "')";
                MessageBox.Show(cmd.CommandText);

                anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Ein Datensatz eingefügt");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bitte mindestens einen Namen und ein Datum angeben");
            }
            con.Close();
            AlleSehen();
        }

        private void lstAnzeige_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime rueckgabe;
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM spiele WHERE ID = " + id[lstAnzeige.SelectedIndex];
                reader = cmd.ExecuteReader();
                reader.Read();

                txtName.Text = "" + reader["name"];
                txtMarke.Text = "" + reader["marke"];
                txtPreis.Text = "" + reader["preis"];
                txtVerfuegbar.Text = "" + reader["verfuegbar"];
                rueckgabe = Convert.ToDateTime(reader["rueckgabe"]);
                txtRueckgabe.Text = rueckgabe.ToShortDateString();
                txtNotizen.Text = "" + reader["notizen"];
                txtPlatform.Text = "" + reader["plattform"];
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btAendern_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE spiele SET name='" + txtName.Text + "', marke = '" + txtMarke.Text + "', preis = '" + txtPreis.Text.Replace(',', '.') + "', verfuegbar = '" + txtVerfuegbar.Text + "', plattform = '" + txtPlatform + "',rueckgabe = '" + txtRueckgabe.Text + "', notizen ='" + txtNotizen.Text + "' WHERE ID = " + id[lstAnzeige.SelectedIndex];
                MessageBox.Show(cmd.CommandText);
                int anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz geändert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bitte einen Datensatz auswählen und mindestens einen Namen und ein gültiges Rückgabedtum eintragen");

            }
            con.Close();
            AlleSehen();
        }

        private void btSuchen_Click(object sender, EventArgs e)
        {
            con.Close();
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM spiele WHERE name LIKE '%" + txtName.Text + "%'";
                MessageBox.Show(cmd.CommandText);
                Ausgabe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btLoeschen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie diesen Datensatz wirklich löschen?", "Löschen", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            try
            {
                con.Open();
                cmd.CommandText = "DELETE FROM spiele WHERE ID = " + id[lstAnzeige.SelectedIndex];
                MessageBox.Show(cmd.CommandText);

                int anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz gelöscht");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
            AlleSehen();
        }

        private void hauptmenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kundeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
            Kunde ku = new Kunde();
            ku.ShowDialog();
        }

        private void konsoleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
            Konsole ko = new Konsole();
            ko.ShowDialog();
        }

        private void spieleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
            Spiele sp = new Spiele();
            sp.ShowDialog();
        }

        private void vermietungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Vermietung vm = new Vermietung();
            vm.ShowDialog();
        }

        private void anzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btAlleSehen.PerformClick();
        }

        private void einfügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btEinfuegen.PerformClick();
        }

        private void ändernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btAendern.PerformClick();
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btLoeschen.PerformClick();
        }

        private void suchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btSuchen.PerformClick();
        }
    }
}
