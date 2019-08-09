using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Eisbären
{
    public partial class Form14 : Form
    {
        private int PX;         //Index des aktuellen Panels
        private int[,] F =
            new int[66, 182];    //Spielfeld inkl. Randfelder
        private int PZ, PS;     //Zeile und Spalte des aktuellen Panels
        private int Stufe;      //Schwierigkeitsstufe

        /* Liste für die Spielpanels */
        private List<Panel> PL = new List<Panel>();

        /* weitere Liste nur, um Panels farbig zu gestalten */
        private Color[] FarbenFeld = {Color.Red, Color.Yellow,
            Color.Green, Color.Blue, Color.Cyan, Color.Magenta,
            Color.Black, Color.White};

        /* Jedes Feld im Spielfeld hat einen Status, für den Status lege ich Konstanten an */
        private const int Leer = -1;
        private const int Rand = -2;

        /* Zufallsgenerator für ein optimiertes Tetris Spiel */
        private Random r = new Random();

        private void Form14_Load(object sender, EventArgs e)
        {
            /* Erezuge Spielfeld bzw Feld besetzen */
            for (int Z = 1; Z < 14; Z++)
            {
                F[Z, 0] = Rand;
                for (int S = 1; S < 9; S++)
                    F[Z, S] = Leer;
                F[Z, 9] = Rand;
            }

            for (int S = 0; S < 10; S++)
                F[14, S] = Rand;

            /*Inistialisierung*/
            Stufe = 1;
            NaechstesPanel();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Application.DoEvents();
        }

        private Form1 fh;

        public Form14(Form1 aufrufer)
        {
            fh = aufrufer;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /* Falls es nicht mehr weiter geht */
            if (F[PZ + 1, PS] != Leer)
            {
                /*Oberste Zeile erreicht */
                if (PZ == 1)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Das war's");
                    return;
                }

                F[PZ, PS] = PX; //Belegen
                AllePruefen();
                NaechstesPanel();
            }
            else
            {
                /* Falls es noch weiter geht */
                PL[PX].Top = PL[PX].Top + 20;
                PZ = PZ + 1;
            }
        }

        private void AllePruefen()
        {
            bool Neben = false, Ueber = false;

            /* Drei gleiche Panel nebeneinander? */
            for (int Z = 13; Z > 0; Z--)
            {
                for (int S = 1; S < 7; S++)
                {
                    Ueber = NebenPruefen(Z, S);
                    if (Neben) break;
                }
                if (Neben) break;
            }

            /* Drei gleiche Panel übereinander? */
            for (int Z = 13; Z > 2; Z--)
            {
                for (int S = 1; S < 9; S++)
                {
                    Ueber = UeberPruefen(Z, S);
                    if (Ueber) break;
                }
                if (Ueber) break;
            }

            if (Neben || Ueber)
            {
                /* Schneller */
                Stufe = Stufe + 1;
                timer1.Interval = 500 / (Stufe + 9);

                /* Evtl. kann jetzt noch eine Reihe entfernt werden */
                AllePruefen();
            }
        }

        private bool NebenPruefen(int Z, int S)
        {
            bool ergebnis = false;

            if (F[Z, S] != Leer && F[Z, S + 1] != Leer && F[Z, S + 2] != Leer)
            {
                /* Falls drei Farben gleich */
                if (PL[F[Z, S]].BackColor == PL[F[Z, S + 1]].BackColor &&
                        PL[F[Z, S]].BackColor == PL[F[Z, S + 2]].BackColor)
                {
                    for (int SX = S; SX < S; SX++)
                    {
                        /* PL aus dem Formular löschen */
                        Controls.Remove(PL[F[Z, SX]]);

                        /* Feld leeren */
                        F[Z, SX] = Leer;

                        /* Panels oberhalb des entladenen Panels absenken */
                        int ZX = Z - 1;
                        while (F[ZX, SX] != Leer)
                        {
                            PL[F[ZX, SX]].Top = PL[F[ZX, SX]].Top + 20;

                            /*Feld neu besetzen */
                            F[ZX + 1, SX] = F[ZX, SX];
                            F[ZX, SX] = Leer;
                            ZX = ZX - 1;
                        }
                    }
                    ergebnis = true;
                }
            }
            return ergebnis;
        }

        private bool UeberPruefen(int Z, int S)
        {
            bool ergebnis = false;

            if (F[Z, S] != Leer && F[PZ-1, S] != Leer &&
                F[Z-2, S] != Leer)
            {
                /* Falls drei Farben gleich */
                if (PL[F[Z, S]].BackColor == PL[F[Z-1, S]].BackColor &&
                    PL[F[Z, S]].BackColor == PL[F[Z-2, S]].BackColor)
                {
                    /* Panels entladen */
                    for (int ZX = Z; ZX > Z-3 ; ZX--)
                    {
                        /* PL aus Form löschen */
                        Controls.Remove(PL[F[ZX, S]]);

                        /* Feld leeren */
                        F[ZX, S] = Leer;
                    }
                    ergebnis = true;
                }
            }
            return ergebnis;

        }

        private void buttonLi_Click(object sender, EventArgs e)
        {
            if (F[PZ, PS-1] == Leer)
            {
                PL[PX].Left = PL[PX].Left - 20;
                PS = PS - 1;
            }
        }

        private void buttonRe_Click(object sender, EventArgs e)
        {
            if (F[PZ, PS+1] == Leer)
            {
                PL[PX].Left = PL[PX].Left + 20;
                PS = PS + 1;
            }
        }

        private void buttonDr_Click(object sender, EventArgs e)
        {
            while (F[PZ + 1, PS] == Leer)
            {
                PL[PX].Top = PL[PX].Top + 20;
                PZ = PZ + 1;
            }

            F[PZ, PS] = PX; // Belegen
            AllePruefen();
            NaechstesPanel();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void NaechstesPanel()
        {
            int Farbe;

            Panel p = new Panel();

            PL.Add(p); // Der Liste 'PL' wird ein neues Panel p hinzugefügt

            /* Planel platzieren und fixieren */
            p.Location = new Point(100, 80);
            p.Size = new Size(20, 20);

            /*Farbe auswählen für die zu erzeugenden Panels */
            Farbe = r.Next(0, 8);
            p.BackColor = FarbenFeld[Farbe];

            /* in die Form hinzufügen */
            Controls.Add(p);

            /* Index des Panels ermitteln */
            PX = PL.Count - 1; // Die Liste PL wird durchgezählt wie viele Panels es beinhaltet (count)

            /* Aktuelle Zeile, Spalte */
            PZ = 1;
            PS = 5;

        }
    }
}
