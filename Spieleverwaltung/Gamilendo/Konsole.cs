using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;//Dies ist erforderlich, um auf die Datenbank zugreifen zu können

namespace Gamilendo
{
    public partial class Konsole : Form
    {
        // Variablen werden erstellt, welche für die Datenbank erforderlich sind
        private OleDbConnection con = new OleDbConnection(); //Diese Vaiable ist erforderlich, da sie später alle Informationen zu der Art der DB enthält 
        private OleDbCommand cmd = new OleDbCommand();//Diese Variable enthält später den SQL-Befehl
        private OleDbDataReader reader; //Der Reader liest die DB aus
        private List<int> pnummer = new List<int>();//Das Array zeichnet die Konsolenid auf, damit man beim auswählen eines Datensatzes in der Listbox den richtigen Datensatz in der DB ändert

        public Konsole()
        {
            InitializeComponent();
        } 
        private void Konsole_Load(object sender, EventArgs e)
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
        }

        private void spieleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spiele sp = new Spiele();
            sp.ShowDialog();
        }

       

        private void AlleSehen()
        {
            try
            {
                con.Open();//Verbindung wird hergestellt
                cmd.CommandText = "SELECT * FROM konsole";
                Ausgabe();

            }
            catch (Exception ex) //Falls ein Fehler auftritt, wird dieser abgefangen und hier ausgegeben. Dadurch stürzt nicht das ganze Programm ab
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            txtMarke.Text = "";
            txtName.Text = "";
            txtNotizen.Text = "";
            txtPreis.Text = "";
            txtVerfuegbar.Text = "";
            txtRueckgabe.Text = "";
        }

        private void Ausgabe()
        {
            DateTime rueckgabe; //Es wird eine Daten-Variable festgelegt
            reader = cmd.ExecuteReader();
            lstAnzeige.Items.Clear();//Listbox wird geleert, um doppelte Einträge zu verhindenr
            pnummer.Clear();//Array wird geleert um falsche Daten zu vermeiden
            while (reader.Read())
            {
                rueckgabe = Convert.ToDateTime(reader["Rueckgabe"]);//Der Inhalt der Spalte "Rückgabe" wird in ein Datum umgewandelt

                //Alle Daten werden ausgegeben
                lstAnzeige.Items.Add(reader["name"] + " # " +
                    reader["marke"] + " # " +
                    reader["preis"] + "€ # " +
                    reader["Verfügbar"] + " # " +
                    reader["Notizen"] + " # " +
                    rueckgabe.ToShortDateString()); //Die Rückgabe wird als ein Datum ohne Zeitangabe ausgegeben
                pnummer.Add((int)reader["ID"]);//Die ID wird in dem Array gespeichert
            }
            reader.Close();//Der Reader beendet das einlesen

        }

        private void btAlleSehen_Click(object sender, EventArgs e)
        {
            AlleSehen();
        }

        private void btEinfuegen_Click(object sender, EventArgs e)
        {
            int anzahl;
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO konsole (name,marke,preis,Verfügbar,Rueckgabe,Notizen) VALUES ('" + txtName.Text + "','" + txtMarke.Text + "','" + txtPreis.Text.Replace(',','.') + "','" + txtVerfuegbar.Text + "','" + txtRueckgabe.Text + "','" + txtNotizen.Text + "')";
                MessageBox.Show(cmd.CommandText);

                anzahl = cmd.ExecuteNonQuery();//Die Anzahl entspricht der Anzahl der eingefügten Konsolen
                if (anzahl > 0)
                    MessageBox.Show("Ein Datensatz wurde eingefügt");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//Es wird die C#-Fehlermeldung ausgegeben
                MessageBox.Show("Bitte mindestens einen Namen und ein Datum angeben");//Es wird eine eigene Fehlermeldung ausgegeben, damit der Benutzer die Fehlerursache besser nachvolziehen kann
            }
            con.Close();
            AlleSehen();//Die Listbox wird aktualiseirt
        }

        private void lstAnzeige_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime rueckgabe;
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM konsole WHERE ID = " + pnummer[lstAnzeige.SelectedIndex];
                reader = cmd.ExecuteReader();
                reader.Read();

                //Die Listbox-Daten des ausgewählten Datensatzes werden in die entsprechenden Textfelder eingetragen
                txtName.Text = "" + reader["name"];
                txtMarke.Text="" + reader["marke"];
                txtPreis.Text = "" + reader["preis"];
                txtVerfuegbar.Text = "" + reader["Verfügbar"];
                rueckgabe = Convert.ToDateTime(reader["Rueckgabe"]);
                txtRueckgabe.Text = rueckgabe.ToShortDateString();
                txtNotizen.Text = "" + reader["Notizen"];
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
                cmd.CommandText = "UPDATE konsole SET name='" + txtName.Text + "', marke = '" + txtMarke.Text + "', preis = '" + txtPreis.Text.Replace(',', '.') + "', Verfügbar = '" + txtVerfuegbar.Text + "', Rueckgabe = '" + txtRueckgabe.Text + "', Notizen ='" + txtNotizen.Text + "' WHERE ID = " + pnummer[lstAnzeige.SelectedIndex];
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

        private void btLoeschen_Click(object sender, EventArgs e)
        {
            //Eine Bestätigungsfrage wird ausgegeben, da das löschen nicht mehr rückgängig gemacht werden kann
            if (MessageBox.Show("Wollen Sie diesen Datensatz wirklich löschen?", "Löschen", MessageBoxButtons.YesNo) == DialogResult.No)
                return;//Falls der Nutzer "Nein" anklickt, passiert nichts
            try
            {
                con.Open();
                cmd.CommandText = "DELETE FROM konsole WHERE ID = " + pnummer[lstAnzeige.SelectedIndex];
                MessageBox.Show(cmd.CommandText);

                int anzahl = cmd.ExecuteNonQuery(); //Falls eine ID mehrmals vorhanden sein sollte, wird für jedem gelöschten Datensatz eine Nachricht ausgegeben
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

        private void btSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();//Verbindung wird geöffnet
                //Konsolentabelle wird anhand des Konsolennamen durchsucht
                cmd.CommandText = "SELECT * FROM konsole WHERE name LIKE '%" + txtName.Text + "%'";
                MessageBox.Show(cmd.CommandText);
                Ausgabe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();//Das Fenster wird geschlossen
        }

        private void hauptmenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();//Das Fenster wird geschlossen, da im Hintergrund das Hauptmenü immer noch geöffnet ist
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

        private void einfügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btEinfuegen.PerformClick();
        }

        private void alleAnzeigenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btAlleSehen.PerformClick();
        }

        private void ändernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btAendern.PerformClick();
        }

        private void suchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btSuchen.PerformClick();
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btLoeschen.PerformClick();
        }

        private void vermietungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Vermietung vm = new Vermietung();
            vm.ShowDialog();
        }
    }
}
