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

namespace Zeiterfassungstool2
{
    public partial class Benutzerverwaltung : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;

        public Benutzerverwaltung()
        {
            InitializeComponent();
        }
        //Radiobutton check
        public bool Checked
        {
            get;
            set;
        }
        
        //Suchen
        private void button1_Click(object sender, EventArgs e)
        {
            listBoxAnzeigen.Items.Clear();

            DateTime rueckgabe;
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source = Zeiterfassung.accdb";
            cmd.Connection = con;
            cmd.CommandText = "SELECT COUNT(column_name) FROM table_name WHERE condition; ";
            cmd.CommandText = "Select ID, Anmeldename, Passwort, Gruppe, Geburtsdatum from Benutzer";

            con.Open();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if ((Convert.ToString(reader["ID"]) == TBID.Text) || (Convert.ToString(reader["Anmeldename"]) == TBAN.Text) || (Convert.ToString(reader["Gruppe"]) == CBG.Text))/* || (Convert.ToDateTime(reader["Geburtsdatum"])==TBGD.Text))*/
                {
                    rueckgabe = Convert.ToDateTime(reader["Geburtsdatum"]);
                    listBoxAnzeigen.Items.Add(reader["ID"] + "," + reader["Anmeldename"] + "," +
                     reader["Passwort"] + "," +
                     rueckgabe.ToShortDateString() + "," +
                     reader["Gruppe"] + ';');
                }

            }
            con.Close();

        }

        //Anlegen
        private void button2_Click(object sender, EventArgs e)
        {

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Zeiterfassung.accdb";
            cmd.Connection = con;
            int anzahl;
            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Benutzer (Anmeldename, Passwort, Gruppe, Geburtsdatum) VALUES ('" + TBAN.Text + "','" + TBPW.Text + "','" + CBG.Text + "','" + DTP.Value + "')";
                //MessageBox.Show(cmd.CommandText);

                anzahl = cmd.ExecuteNonQuery();//Die Anzahl der verfügbaren Benutzer
                if (anzahl > 0)
                    MessageBox.Show("Ein Datensatz wurde eingefügt");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//Es wird die C#-Fehlermeldung ausgegeben
                MessageBox.Show("Bitte mindestens einen Namen und ein Datum angeben");//Es wird eine eigene Fehlermeldung ausgegeben, damit der Benutzer die Fehlerursache besser nachvolziehen kann
            }
            con.Close();
        }

        //Zurück zu Form3
        private void buttonZurück_Click(object sender, EventArgs e)
        {
            Form frm1 = new Zeiterfassungstool.Form3();
            frm1.Show();
            this.Hide();
        }

        //löschen
        private void button4_Click(object sender, EventArgs e)
        {
            int anzahl;
            //Eine Bestätigungsfrage wird ausgegeben, da das löschen nicht mehr rückgängig gemacht werden kann
            if (MessageBox.Show("Wollen Sie diesen Datensatz wirklich löschen?", "Löschen", MessageBoxButtons.YesNo) == DialogResult.No)
                return;//Falls der Nutzer "Nein" anklickt, passiert nichts
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Zeiterfassung.accdb";
            cmd.Connection = con;
            try
            {

                con.Open();

                //löschen von referenzierenden Datensätzen
                cmd.CommandText = "DELETE FROM  Arbeitszeit WHERE Benutzer = " + Convert.ToInt16(TBID.Text);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM  Freitage WHERE Benutzer = " + Convert.ToInt16(TBID.Text);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM  Schichtplan WHERE Benutzer = " + Convert.ToInt16(TBID.Text);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DELETE FROM Benutzer WHERE ID = " + Convert.ToInt16(TBID.Text);
                //MessageBox.Show(cmd.CommandText);

                anzahl = cmd.ExecuteNonQuery();//Die Anzahl der verfügbaren Benutzer
                if (anzahl > 0)
                    MessageBox.Show("Datensatz gelöscht");//Message für jeden gelöschten Benutzer
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

        }

        //ändern
        private void button3_Click(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Zeiterfassung.accdb";
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.CommandText = "UPDATE Benutzer SET Anmeldename='" + TBAN.Text + "', Passwort = '" + TBPW.Text + "', Gruppe = '" + CBG.Text + "', Geburtsdatum = '" + DTP.Value.Date + "'WHERE ID = " + Convert.ToInt16(TBID.Text);
                MessageBox.Show(cmd.CommandText);
                int anzahl = cmd.ExecuteNonQuery();
                if (anzahl > 0)
                    MessageBox.Show("Datensatz geändert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Bitte Felder korrekt ausfüllen");

            }
            con.Close();
        }

        //sortieren
        private void button6_Click(object sender, EventArgs e)
        {
            RadioButton radioBtn = this.Controls.OfType<RadioButton>()
                                       .Where(x => x.Checked).FirstOrDefault();
            //Switch case für radiobuttons
            if (radioBtn != null)
            {           
                switch (radioBtn.Name)
                {
                    case "RBID":

                        listBoxAnzeigen.Items.Clear();//Der Inhalt der Listbox wird gelöscht

                        DateTime rueckgabe;
                        con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source = Zeiterfassung.accdb";
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT COUNT(column_name) FROM table_name WHERE condition; ";
                        cmd.CommandText = "Select ID, Anmeldename, Passwort, Gruppe, Geburtsdatum from Benutzer ORDER BY ID"; //Access-Datenbank wird nach ID sortiert

                        con.Open();
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            if ((Convert.ToString(reader["ID"]) == TBID.Text) || (Convert.ToString(reader["Anmeldename"]) == TBAN.Text) || (Convert.ToString(reader["Gruppe"]) == CBG.Text))
                            {
                                rueckgabe = Convert.ToDateTime(reader["Geburtsdatum"]);
                                listBoxAnzeigen.Items.Add(reader["ID"] + "," + reader["Anmeldename"] + "," + //Datensätze werden in Listbox geschrieben
                                 reader["Passwort"] + "," +
                                 rueckgabe.ToShortDateString() + "," +
                                 reader["Gruppe"] + ';');
                            }

                        }
                        con.Close();                     
                        break;
                    case "RBAN":

                        listBoxAnzeigen.Items.Clear();

                        DateTime rueckgabeAN;
                        con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source = Zeiterfassung.accdb";
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT COUNT(column_name) FROM table_name WHERE condition; ";
                        cmd.CommandText = "Select ID, Anmeldename, Passwort, Gruppe, Geburtsdatum from Benutzer ORDER BY Anmeldename";

                        con.Open();
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            if ((Convert.ToString(reader["ID"]) == TBID.Text) || (Convert.ToString(reader["Anmeldename"]) == TBAN.Text) || (Convert.ToString(reader["Gruppe"]) == CBG.Text))
                            {
                                rueckgabeAN = Convert.ToDateTime(reader["Geburtsdatum"]);
                                listBoxAnzeigen.Items.Add(reader["ID"] + "," + reader["Anmeldename"] + "," +
                                 reader["Passwort"] + "," +
                                 rueckgabeAN.ToShortDateString() + "," +
                                 reader["Gruppe"] + ';');
                            }

                        }
                        con.Close();                      
                        break;

                    case "RBPW":

                        listBoxAnzeigen.Items.Clear();

                        DateTime rueckgabePW;
                        con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source = Zeiterfassung.accdb";
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT COUNT(column_name) FROM table_name WHERE condition; ";
                        cmd.CommandText = "Select ID, Anmeldename, Passwort, Gruppe, Geburtsdatum from Benutzer ORDER BY Passwort";

                        con.Open();
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            if ((Convert.ToString(reader["ID"]) == TBID.Text) || (Convert.ToString(reader["Anmeldename"]) == TBAN.Text) || (Convert.ToString(reader["Gruppe"]) == CBG.Text))
                            {
                                rueckgabePW = Convert.ToDateTime(reader["Geburtsdatum"]);
                                listBoxAnzeigen.Items.Add(reader["ID"] + "," + reader["Anmeldename"] + "," +
                                 reader["Passwort"] + "," +
                                 rueckgabePW.ToShortDateString() + "," +
                                 reader["Gruppe"] + ';');
                            }

                        }
                        con.Close();                       
                        break;
                       
                    case "RBGD":

                        listBoxAnzeigen.Items.Clear();

                        DateTime rueckgabeGD;
                        con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source = Zeiterfassung.accdb";
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT COUNT(column_name) FROM table_name WHERE condition; ";
                        cmd.CommandText = "Select ID, Anmeldename, Passwort, Gruppe, Geburtsdatum from Benutzer ORDER BY Geburtsdatum";

                        con.Open();
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            if ((Convert.ToString(reader["ID"]) == TBID.Text) || (Convert.ToString(reader["Anmeldename"]) == TBAN.Text) || (Convert.ToString(reader["Gruppe"]) == CBG.Text))
                            {
                                rueckgabeGD = Convert.ToDateTime(reader["Geburtsdatum"]);
                                listBoxAnzeigen.Items.Add(reader["ID"] + "," + reader["Anmeldename"] + "," +
                                 reader["Passwort"] + "," +
                                 rueckgabeGD.ToShortDateString() + "," +
                                 reader["Gruppe"] + ';');
                            }

                        }
                        con.Close();                       
                        break;
                    case "RBG":

                        listBoxAnzeigen.Items.Clear();

                        DateTime rueckgabeG;
                        con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source = Zeiterfassung.accdb";
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT COUNT(column_name) FROM table_name WHERE condition; ";
                        cmd.CommandText = "Select ID, Anmeldename, Passwort, Gruppe, Geburtsdatum from Benutzer ORDER BY Gruppe";

                        con.Open();
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            if ((Convert.ToString(reader["ID"]) == TBID.Text) || (Convert.ToString(reader["Anmeldename"]) == TBAN.Text) || (Convert.ToString(reader["Gruppe"]) == CBG.Text))
                            {
                                rueckgabeG = Convert.ToDateTime(reader["Geburtsdatum"]);
                                listBoxAnzeigen.Items.Add(reader["ID"] + "," + reader["Anmeldename"] + "," +
                                 reader["Passwort"] + "," +
                                 rueckgabeG.ToShortDateString() + "," +
                                 reader["Gruppe"] + ';');
                            }

                        }
                        con.Close();  
                        break;

                }
                
                
               // https://stackoverflow.com/questions/3309188/how-to-sort-a-listt-by-a-property-in-the-object
            }         
        }

        private void listBoxAnzeigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
