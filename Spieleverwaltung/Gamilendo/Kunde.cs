using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //Diese Klassen sind erforderlich, um auf die Datenbank zugreifen zu können

namespace Gamilendo
{
    public partial class Kunde : Form
    {
        //Erforderliche Datenbank-Variablen werden erstellt
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader reader;
        private List<int> KdNR = new List<int>();
        public Kunde()
        {           
            InitializeComponent();
        }

        private void Kunde_Load(object sender, EventArgs e)
        {
            // C# wird mitgeteilt, wo man die Datenbank findet und um welche Art von Datenbank es sich handelt.
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Gamilendo.accdb";
            cmd.Connection = con;
        }
        private void kundeToolStripMenuItem_Click(object sender, EventArgs e) //Dies wird ausgeführt, wenn in der Menü-Leiste "Kunde" angeklickt wird
        {
            Close(); //Das aktuelle Fenster wird geschlossen
            Kunde ku = new Kunde(); // Ein neues Objekt der Userform "Kunde" wird erstellt
            ku.ShowDialog(); //Das Objekt wird aufgerufen
        }

        private void konsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Konsole ko = new Konsole(); 
            ko.ShowDialog();
        }
        private void spieleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Spiele sp = new Spiele();
           sp.ShowDialog();
        }

        private void btAlleSehen_Click(object sender, EventArgs e)
        {
            AlleSehen(); //Sobald man auf "AlleSehen" klickt, wird die Funktion "AlleSehen" azfgerufen, welche dafür sorft, dass die Datensätze in der ListBox angezeigt werden
        }

        private void AlleSehen()
        {
            try //Es wird versucht eine Verbindung zur DB herzustellen
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM kunde";
                Ausgabe();

            }
            catch (Exception ex) // Wenn ein Fehler auftritt wird die Fehlermeldung ausgegeben
            {
                MessageBox.Show(ex.Message);
            }
            con.Close(); //Verbindung zur DB wird beendet

            //Alle Felder werden geleert
            txtVorname.Text = "";
            txtNachname.Text = "";
            txtNotizen.Text = "";
            txtGeburtstag.Text = "";
            txtStr.Text = "";
            txtOrt.Text = "";
            txtPLZ.Text = "";
        }

        private void Ausgabe()
        {
            DateTime geburtsdatum;
            reader = cmd.ExecuteReader();
            lstAnzeige.Items.Clear(); //List-Box wird geleert
            KdNR.Clear();
            while (reader.Read())
            {
                geburtsdatum = Convert.ToDateTime(reader["geburtsdatum"]); //Das Geburtsdatum aus der DB wird in ein Datum umgewandelt

                //Alle Daten werden getrennt durch eine Raute ausgegeben
                lstAnzeige.Items.Add(reader["vorname"] + " # " +
                    reader["nachname"] + " # " +
                    reader["strasse"] + " # " +
                    reader["plz"] + " # " +
                    reader["ort"] + " # " +
                reader["notizen"] + " # " +
                    geburtsdatum.ToShortDateString());
                KdNR.Add((int)reader["KdNR"]);
            }
            reader.Close();

        }

        private void btEinfuegen_Click(object sender, EventArgs e)
        {
            int anzahl;
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO kunde (vorname,nachname,strasse,plz,ort,geburtsdatum,notizen) VALUES ('" + txtVorname.Text + "','" + txtNachname.Text + "','" + txtStr.Text + "','" + txtPLZ.Text + "','" + txtOrt.Text + "','" + txtGeburtstag.Text+ "','" + txtNotizen.Text + "')";
                MessageBox.Show(cmd.CommandText);//SQL-Befehl wird ausgegeben

                anzahl = cmd.ExecuteNonQuery();//Anzahl entspricht der Anzahl der eingefügten Kunden
                if (anzahl > 0)
                    MessageBox.Show("Ein Datensatz eingefügt");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bitte mindestens einen Namen und ein Geburtsdatum angeben");
            }
            con.Close();
            AlleSehen();//Aktualisierte Tabelle wird ausgegeben
        }

        private void btSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //Die Kundentabelle wird anhand des Namens durchsucht
                cmd.CommandText = "SELECT * FROM kunde WHERE vorname LIKE '%" + txtVorname.Text + "%'";
                MessageBox.Show(cmd.CommandText);
                Ausgabe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLoeschen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie diesen Datensatz wirklich löschen?", "Löschen", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            try
            {
                con.Open();
                //Es wird der ausgewählte Datensatz gelöscht
                cmd.CommandText = "DELETE FROM kunde WHERE ID = " + KdNR[lstAnzeige.SelectedIndex];
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

        private void btAendern_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE kunde SET vorname='" + txtVorname.Text + "', nachname = '" + txtNachname.Text + "',strasse = '" + txtStr.Text + "',plz = '" + txtPLZ.Text + "',ort = '" + txtOrt.Text + "', geburtsdatum = '" + txtGeburtstag.Text + "', notizen ='" + txtNotizen.Text + "' WHERE KdNR = " + KdNR[lstAnzeige.SelectedIndex];
                MessageBox.Show(cmd.CommandText);
                int anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz geändert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bitte einen Datensatz auswählen und mindestens einen Namen und ein gültiges Geburtsdatum eintragen");

            }
            con.Close();
            AlleSehen();
        }

        private void lstAnzeige_SelectedIndexChanged(object sender, EventArgs e) //Wenn man in der Listbox einen Datensatz auswählt, wird dieser Code-Abschnitt ausgeführt
        {
            DateTime geburtstag;
            try
            {
                con.Open(); //Datenbankverbindung wird hergestellt
                cmd.CommandText = "SELECT * FROM kunde WHERE KdNR = " + KdNR[lstAnzeige.SelectedIndex];
                reader = cmd.ExecuteReader();
                reader.Read();//Der Reader liest die DB aus

                txtVorname.Text = "" + reader["vorname"];// in das Textfeld "txtVorname" wird der Vorname aus der DB eingeügt
                txtNachname.Text = "" + reader["nachname"];
                txtStr.Text= "" + reader["strasse"];
                txtPLZ.Text= "" + reader["plz"];
                txtOrt.Text = "" + reader["ort"];
                geburtstag = Convert.ToDateTime(reader["geburtsdatum"]);
                txtGeburtstag.Text = geburtstag.ToShortDateString();
                txtNotizen.Text = "" + reader["notizen"];
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); //Fenster wird geschlossen
        }

        private void hauptmenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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

        private void alleAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btAlleSehen.PerformClick(); //Rin Klick auf den Button "AlleSehen" wird ausgeführt.Dadurch muss der Code nicht kopiert und hier eingefügt werden
        }

        private void einfügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btEinfuegen.PerformClick();
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
    }
}
