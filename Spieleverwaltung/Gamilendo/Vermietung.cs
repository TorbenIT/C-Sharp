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
    public partial class Vermietung : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader reader;
        private List<int> konsolID = new List<int>();//Dieses Array enthällt die KonsolenID, welche benötigt werden um die richtigen Konsolendaten in die entsprechenden Textboxen einzufügen
        private List<int> spielID = new List<int>();//Dieses Array wird die SpieleID enthalten,damit auch wirklich die Daten des ausgewählten Datensatzes in die richtigen Textboxen eingetragen werden
        private List<int> kundeID = new List<int>();//Dieses Array enthällt alle Kundennummern
        private List<int> mietlID = new List<int>();//In diesem Array werden alle Vermietungs-ID gespeichert 
        public Vermietung()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void lstAnzeige_SelectedIndexChanged(object sender, EventArgs e)// Dieser Code-Teil wird ausgeführt, wenn in der Konsolen-Listbox ein Datensatz ausgewählt wird
        {
            DateTime startdatum;//Das Startdatum ist das Datum, welches in der Spalte "Startdatum" in der Tabelle "konsole" steht
            DateTime istDatum;//Das Ist-Datum ist das Datum, welches bereits in der TextBox "txtBeginn" wingetragen ist
            Int32 preis;//Der Preis ist der Preis, welcher in der Spalte "preis" aus der Tabelle "konsole" gespeichert ist
            Int32 istpreis;//Als Ist-Preis bezeichne ich den Preis, der bereits in der textbox "txtPreis" eingetragen ist
            int prüfung;//Eine Variable wird deklariert, welches das Ergebnis der Prüfung enthällt
            istpreis= 0;
          
            try
            {
                con.Open();//Verbindung mit DB wird hergestellt
                cmd.CommandText = "SELECT * FROM konsole WHERE ID = " + konsolID[lstKonsole.SelectedIndex];
                reader = cmd.ExecuteReader();
                reader.Read();

                istDatum = Convert.ToDateTime(txtBeginn.Text);//Die Zeichenkette, welche in der Textbox "txtBeginn" steht, wird in ein Datum umgewandelt, damit man es gleich mit dem DAtum aus der DB vergleichen kann
                startdatum = Convert.ToDateTime(reader["Rueckgabe"]);//Das Startdatum wird in ein Datum umgewandelt.
                //Das Startdatum wird mit dem Datum in der textbox verglichen. Wenn ein Kunde nämlich eine Konsole und ein Spiel gleichzeitg ausleihen möchte, können beide Gegenstände nur verliehen werden, wenn wirklich beide Gegenstände zurückgegeben wurden. Desswegen wird verglichen, ob das Datum der Spielerückgabe später als das Datum der Konsolenrückgabe ist 
                prüfung = DateTime.Compare(istDatum, startdatum); //Wenn kleiner 0, dann wird die Konsole als letztes Verfügbar sein.Somit muss das frühestmögliche Vermietungsdatum bzw. Startdatum auf das Rückgabedatum der Konsole gesetzt werden
                if (prüfung < 0)
                    txtBeginn.Text = startdatum.ToShortDateString();


                preis = Convert.ToInt32(reader["preis"]);//Der Preis aus der DB wird in eine Zahl umgewandelt
                istpreis = Convert.ToInt32(txtPreis.Text);//Die bereits eingegebenen Zeichen in das Preisfeld wird in einer Zahl umgewandelt
                preis = preis + istpreis;// Da zuvor beide Preise in Zahlen umgewandelt wurden, kann nun eine Gesamtsumme gebildet werden. Ansonsten würde statt dem Ergebnis 5 bei den Preisen 1 und 4 "14" ausgegeben werden
                txtPreis.Text = preis.ToString(); //Die Summe wird wieder in eine Zeichenkette umgewandelt, damit diese in die Textbox eingetragen werden kann
                txtKname.Text = "" + reader["name"];//Der Konsolenname wird übernommen
                txtNotizen.Text = txtNotizen.Text+" KonsolNotizen:" + reader["Notizen"]; //Die Notizen werden in das Notizenfeld eingetragen, damit man alle Notizen zu den Konsolen,Spielen, Kunden und evtl. Vermietungen in einem Feld hat.
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//Fehlermeldung wird ausgegeben
            }
            con.Close();
        }

        private void Vermietung_Load(object sender, EventArgs e)
        {
            //C# wird mitgeteilt um welcher Art Datenbank es sich handelt
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Gamilendo.accdb";
            cmd.Connection = con;
        }

        private void btAlleSehen_Click(object sender, EventArgs e)
        {
            KonsoleSehen();//Diese Funktion leert alle Felder und verweist auf eine Funktion, die dei Konsolenlistbox füllt.
            SpielSehen();
            KundeSehen();
            MieteSehen();
        }

        private void KonsoleSehen()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM konsole";
                KonsolAusgabe();//Diese Funktion füllt die Konsolen-Listbox

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            txtKname.Text = ""; 
            txtStr.Text = "";
            txtPLZ.Text = "";
            txtOrt.Text = "";
            txtSname.Text = "";
            txtName.Text = "";
            txtNotizen.Text = "";
            txtPreis.Text = "";
            txtBeginn.Text = ""; //Startdatum des Verleihs
            txtRueckgabe.Text = "";
        }

        private void SpielSehen()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM spiele";
                SpielAusgabe();//Dies füllt die Spiele-Listbox

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            txtKname.Text = "";
            txtStr.Text = "";
            txtPLZ.Text = "";
            txtOrt.Text = "";
            txtSname.Text = "";
            txtName.Text = "";
            txtNotizen.Text = "";
            txtPreis.Text = "";
            txtBeginn.Text = ""; //Startdatum des Verleihs
            txtRueckgabe.Text = "";
        }

        private void KundeSehen()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM kunde";
                KundeAusgabe();//Hier wird die Kunden List-Box gefüllt

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            txtKname.Text = "";
            txtStr.Text = "";
            txtPLZ.Text = "";
            txtOrt.Text = "";
            txtSname.Text = "";
            txtName.Text = "";
            txtNotizen.Text = "";
            txtPreis.Text = "";
            txtBeginn.Text = ""; //Startdatum des Verleihs
            txtRueckgabe.Text = "";
        }

        private void MieteSehen()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM vermietung";
                MietAusgabe();//Hier wird schließlich die Vermietungs-Listbox gefüllt

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

            txtKname.Text = "";
            txtStr.Text = "";
            txtPLZ.Text = "";
            txtOrt.Text = "";
            txtSname.Text = "";
            txtName.Text = "";
            txtNotizen.Text = "";
            txtPreis.Text = "0";//Das Feld "Preis" wird mit einem Platzhalter gefüllt, damit es nicht zu einem Fehler kommt, wenn der Preis der DB mit dem Preis des Textfeldes summiert wird.
            txtBeginn.Text = "01.01.1001"; //Das Textfeld wird mit einem Platzhalter gefüllt, damit das Programm nicht abstürzt, wenn das Datum des Textfeldes mit dem Rückgabedatum aus der DB verglcihen wird. Startdatum des Verleihs
            txtRueckgabe.Text = "";
        }

        private void KonsolAusgabe()
        {
            DateTime rueckgabe;
            reader = cmd.ExecuteReader();
            lstKonsole.Items.Clear();
            konsolID.Clear();
            while (reader.Read())
            {
                //Das Rückgabedatum aus der DB wird in ein Datum umgewandelt
                rueckgabe = Convert.ToDateTime(reader["Rueckgabe"]);
                //Konsolendaten werden getrennt durch eine Raute ausgegeben
                lstKonsole.Items.Add(reader["name"] + " # " +
                    reader["marke"] + " # " +
                    reader["preis"] + "€ # " +
                    reader["Verfügbar"] + " # " +
                    reader["Notizen"] + " # " +
                    rueckgabe.ToShortDateString());
                konsolID.Add((int)reader["ID"]);//Die ID wird dem Konsolen-Array hinzugefügt
            }
            reader.Close();//Der Reader hört mit dem einlesen auf

        }

        private void SpielAusgabe()
        {
            DateTime rueckgabe;
            reader = cmd.ExecuteReader();//Der Reader wird gestartet
            lstSpiele.Items.Clear();//Spiele-Listbox wird geleert
            spielID.Clear();//Spiele-Array wird geleert
            while (reader.Read())
            {
                rueckgabe = Convert.ToDateTime(reader["rueckgabe"]);
                //Alle Spieledaten werden der Spiele-Listbox hinzugefpgt
                lstSpiele.Items.Add(reader["name"] + " # " +
                    reader["marke"] + " # " +
                    reader["preis"] + "€ # " +
                    reader["verfuegbar"] + " # " +
                    reader["plattform"] + " # " +
                    reader["rueckgabe"] + " # " +
                    reader["notizen"] + " # " +
                    rueckgabe.ToShortDateString());
                spielID.Add((int)reader["ID"]);
            }
            reader.Close();

        }

        private void KundeAusgabe()
        {
            DateTime geburtsdatum;
            reader = cmd.ExecuteReader();
            lstKunde.Items.Clear();
            kundeID.Clear();
            while (reader.Read())
            {
                geburtsdatum = Convert.ToDateTime(reader["geburtsdatum"]);

                lstKunde.Items.Add(reader["vorname"] + " # " +
                    reader["nachname"] + " # " +
                    reader["strasse"] + " # " +
                    reader["plz"] + " # " +
                    reader["ort"] + " # " +
                    reader["notizen"] + " # " +
                    geburtsdatum.ToShortDateString());
                kundeID.Add((int)reader["KdNR"]);
            }
            reader.Close();
        }

        private void MietAusgabe()
        {
            DateTime rueckgabe;
            DateTime startdatum;
            reader = cmd.ExecuteReader();
            lstVermietung.Items.Clear();
            mietlID.Clear();
            while (reader.Read())
            {
                rueckgabe = Convert.ToDateTime(reader["enddatum"]);
                startdatum = Convert.ToDateTime(reader["startdatum"]);
                lstVermietung.Items.Add(reader["kdName"] + " # " +
                    reader["konName"] + " # " +
                    reader["spName"] + " # " +
                    reader["preis"] + "€ # " +
                    reader["notizen"] + " # " +
                    rueckgabe.ToShortDateString());
                    startdatum.ToShortDateString();
                mietlID.Add((int)reader["ID"]);
            }
            reader.Close();

        }

        private void lstSpiele_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime startdatum;
            DateTime istDatum;
            Int32 preis;
            Int32 istpreis;
            istpreis = 0;
            int prüfung;

            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM spiele WHERE ID = " + spielID[lstSpiele.SelectedIndex];
                reader = cmd.ExecuteReader();
                reader.Read();

                //------------Start des Datum-Vergleichs-----------------------------------
                istDatum = Convert.ToDateTime(txtBeginn.Text);
                startdatum = Convert.ToDateTime(reader["Rueckgabe"]);
                prüfung = DateTime.Compare(istDatum, startdatum); //Wenn kleiner 0, dann ist das bereits eingetragene Datum früher als das ausgewählte Datum.
                if (prüfung < 0)
                    txtBeginn.Text = startdatum.ToShortDateString();
                //------------Ende des Datum-Vergleichs----------------------------

                txtSname.Text = "" + reader["name"];

                //--------------Gesamtsumme wird gebildet---------------------
                preis = Convert.ToInt32(reader["preis"]);
                istpreis = Convert.ToInt32(txtPreis.Text);
                preis = preis + istpreis;
                txtPreis.Text = preis.ToString();
                //------------Ende der Summenbildung--------------------


                txtNotizen.Text = txtNotizen.Text + " SpielNotizen: " + reader["Notizen"]; //Spielenotizen werden dem Notizenfeld hinzugefügt
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void lstKunde_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM kunde WHERE KdNR = " + kundeID[lstKunde.SelectedIndex];
                reader = cmd.ExecuteReader();
                reader.Read();

                txtName.Text = "" + reader["vorname"] + " " + reader["nachname"];
                txtStr.Text = "" + reader["strasse"];
                txtPLZ.Text = "" + reader["plz"];
                txtOrt.Text = "" + reader["ort"];
                 
                txtNotizen.Text = txtNotizen.Text + " KundeNotizen: " + reader["Notizen"];
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void lstVermietung_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime enddatum;
            DateTime heute = DateTime.Today;
            Int32 preis;
            int prüfung;
            
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM vermietung WHERE ID = " + mietlID[lstVermietung.SelectedIndex];
                reader = cmd.ExecuteReader();
                reader.Read();

                enddatum = Convert.ToDateTime(reader["enddatum"]);

                //Es wird geprüft ob das Rückgabedatum überschritten wurde
                prüfung = DateTime.Compare(heute, enddatum); //Wenn kleiner 0, dann ist das bereits eingetragene Datum früher als das ausgewählte Datum.
                if (prüfung > 0)
                {
                    MessageBox.Show("Der Kunde hat das Rückgabedatum überschritten! Es wurden automatisch 2€ Überziehungsgebühren zum Preis hinzugefügt");
                    preis = Convert.ToInt32(reader["preis"]); //Der Preis wird in eine Zahl umgewandelt, damit man mit ihr Rechnen kann
                    preis = preis + 2;
                    txtPreis.Text = preis.ToString();
                }
                    
                txtRueckgabe.Text = enddatum.ToShortDateString();
                txtNotizen.Text = txtNotizen.Text + " Vermietungsnotizen: " + reader["Notizen"];

            

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void toolStripContainer2_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        //Ein neuer Datensatz wird in die Vermietungstabelle eingefügt
        private void btEinfuegen_Click(object sender, EventArgs e)
        {
            
            int anzahl;
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO vermietung (kdName,konName, spName, preis,startdatum,enddatum,notizen) VALUES ('" + txtName.Text + "','" + txtKname.Text + "','" + txtSname.Text + "','" + txtPreis.Text.Replace(',', '.') + "','" + txtBeginn.Text + "','" + txtRueckgabe.Text + "','" + txtNotizen.Text + "')";
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
            MieteSehen();
        }
        
        //Ausgewählte Vermietungsdaten werden geändert
        private void btAendern_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE vermietung SET kdname='" + txtName.Text + "', konName = '" + txtKname.Text + "',spName = '" + txtSname.Text + "', preis = '" + txtPreis.Text.Replace(',', '.') + "', startdatum = '" + txtBeginn.Text + "', enddatum = '" + txtRueckgabe.Text + "', notizen ='" + txtNotizen.Text + "' WHERE ID = " + mietlID[lstVermietung.SelectedIndex];
                MessageBox.Show(cmd.CommandText);
                int anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz geändert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bitte einen Datensatz auswählen und mindestens einen Namen , ein gültiges Startdatum und ein gültiges Rückgabedatum eintragen. Wählen Sie bitte mindestens ein Spiel oder eine Konsole aus.");

            }
            con.Close();
            MieteSehen();
        }

        //Vermietungsdaten werden anhand des Kundennamens durchsucht
        private void btSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM vermietung WHERE kdName LIKE '%" + txtName.Text + "%'";
                MessageBox.Show(cmd.CommandText);
                MietAusgabe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Der ausgewählte Vermietungs-Datensatz wird gelsöcht
        private void btLoeschen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie diesen Datensatz wirklich löschen?", "Löschen", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            try
            {
                con.Open();
                cmd.CommandText = "DELETE FROM vermietung WHERE ID = " + mietlID[lstVermietung.SelectedIndex];
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
            MieteSehen();
        }

        private void hauptmenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kundeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Kunde ku = new Kunde();
            ku.ShowDialog();
        }

        private void konsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Konsole ko = new Konsole();
            ko.ShowDialog();
        }

        private void spieleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Spiele sp = new Spiele();
            sp.ShowDialog();
        }

        private void alleSehenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btAlleSehen.PerformClick();
        }

        private void einfügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btEinfuegen.PerformClick();
        }

        private void vermietungBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btAendern.PerformClick();
        }

        private void vermietungLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btLoeschen.PerformClick();
       
        }

        private void vermietungNachKdNamenDurchsuchenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btSuchen.PerformClick();
        }
    }
}
