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
using System.IO;

namespace Spanisch
{
    public partial class Form1 : Form
    {
        /* Liste der Fragen */
        private List<string> frage = new List<string>();

        /* Liste der Fragen */
        private List<string> antwort = new List<string>();

        /* Zufallszahl für ein Element der beiden Listen */
        private int zufallszahl;

        /* Richtung der Vokabel-Frage */
        private int richtung;

        /* Erzeugen und initialisieren des Zufallsgenerator */
        private Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Startrichtung Spanisch - Deutsch */
            richtung = 2;
        }

        private void cmdstart_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();

            OleDbCommand cmd = new OleDbCommand();

            OleDbDataReader reader;

            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=Spanisch.accdb";

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Vokabeln";

            frage.Clear();
            antwort.Clear();

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();

                /* Speicherung in den Listen gemäß der ausgewählten Richtung */

                while (reader.Read())
                {
                    if (richtung == 1 || richtung == 3)
                        frage.Add((string)reader["Deutsch"]);
                    else if (richtung == 2)
                        frage.Add((string)reader["Spanisch"]);

                    if (richtung == 2 || richtung == 4)
                        antwort.Add((string)reader["Deutsch"]);
                    else if (richtung == 1)
                        antwort.Add((string)reader["Spanisch"]);
                }

                reader.Close();
                con.Close();

                /* Buttons und Menü (de)aktivieren */

                cmdstart.Enabled = false;
                cmdprüfen.Enabled = true;
                richtungToolStripMenuItem.Enabled = false;

                TextBoxantworten.Enabled = true;

                /* Erste Vokabel erscheint */
                Naechste_Vokabel();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Naechste_Vokabel()
        {
            /* Falls keine Vokabel mehr in der Liste ist: Ende */
            if (frage.Count < 1)
            {
                MessageBox.Show("Gratuliere! Alles geschafft");
                Test_Unit();
            }

            /* Falls noch Vokabeln in der Liste: Nächste */
            else
            {
                zufallszahl = r.Next(0, frage.Count);
                labelFrage.Text = "" + frage[zufallszahl];
                labelAusgabe.Text = "";
            }
        }

        private void Test_Unit()
        {
            /* Buttons und Menü (de)aktivieren */
            cmdprüfen.Enabled = false;
            cmdstart.Enabled = true;
            richtungToolStripMenuItem.Enabled = true;
            TextBoxantworten.Enabled = false;

            /* Felder leeren */
            labelFrage.Text = "";
            TextBoxantworten.Text = "";
        }

        private void cmdprüfen_Click(object sender, EventArgs e)
        {
            /* Falls richtig beantwortet: Vokabel aus Liste nehmen */
            if (TextBoxantworten.Text == (string)antwort[zufallszahl])
            {
                MessageBox.Show("Richtig", "Vokabel");
                frage.RemoveAt(zufallszahl);
                antwort.RemoveAt(zufallszahl);
            }
            /* Falls falsch beantwortet: richtige Antwort nennen */
            else
            {
                MessageBox.Show("Falsch, richtige Antwort" +
                    "ist\n'" + antwort[zufallszahl] +
                    "'", "Vokabel");

                /*Nächste Vokabel erscheint */
                Naechste_Vokabel();
            }
        }

        private void testBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Abbrucxh mit Rückfrage */
            if (MessageBox.Show("Test wirklich abbrechen?", "Vokabel",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                Test_Unit();

            
        }

        private void programmBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Beenden mit Rückfrage */
            if (MessageBox.Show("Programm wirklich beenden?", "Vokabel",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void deutschEnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Richgtung wird geändert */
            richtung = 1;
            Check_False();
            deutschEnglishToolStripMenuItem.Checked = true;

        }

        private void englishDeutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richtung = 2;
            Check_False();
            deutschEnglishToolStripMenuItem.Checked = true;
        }

        private void Check_False()
        {
            deutschEnglishToolStripMenuItem.Checked = false;
            englishDeutschToolStripMenuItem.Checked = false;

        }

        private void ableitungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr;
            string dateiname = "hilfe.txt";
            string ausgabe;

            if (!File.Exists(dateiname))
            {
                MessageBox.Show("Die Datei " + dateiname +
                    " existiert nicht");
                return;
            }

            fs = new FileStream(dateiname, FileMode.Open);
            sr = new StreamReader(fs);

            ausgabe = "";

            while (sr.Peek() != -1)
            {
                ausgabe += sr.ReadLine() + "\n";

            }
            sr.Close();

            MessageBox.Show(ausgabe);
        }
    }
}
