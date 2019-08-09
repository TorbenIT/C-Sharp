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
using Microsoft.VisualBasic;

namespace Eisbären
{
  
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand sql = new OleDbCommand();
        OleDbDataReader reader;

        public Form1()
        { 
            InitializeComponent();

            //string myTime = System.DateTime.Now.ToShortDateString();

            //  DateTime zeit = DateTime.Today;

            String connect = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                                "Data Source=Logindaten.accdb";
            con = new OleDbConnection(connect);
            con.Open();
            sql = con.CreateCommand();
            sql.CommandText = "insert into logdatei(programmstart, datum)" +
                " values('ja', '" + DateTime.Now + "');";
            sql.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WissenEinstieg fr = new WissenEinstieg(this);
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3(this);
            fr.ShowDialog();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4(this);
            fr.ShowDialog();
        }



        private void buttoneinlesen_Click(object sender, EventArgs e)
        {
            Form7 fr = new Form7(this);
            fr.ShowDialog();
        }

        private void tabPage4_DoubleClick(object sender, EventArgs e)
        {
            Form5 fr = new Form5(this);
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 fr = new Form6(this);
            fr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 fr = new Form8(this);
            fr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 fr = new Form9(this);
            fr.ShowDialog();
        }

        private void buttonsuchen_Click(object sender, EventArgs e)
        {

            Form11 fr = new Form11(this);
            fr.ShowDialog();
          // // string eingabe;

          ////  eingabe = Interaction.InputBox("Bitte einen Nachnamen eingeben:", "Interaktion mit der Spenderkartei", "Nachname");

          //  //try
          //  //{
          //      con.Open();
          //      sql.CommandText = "SELECT * FROM Person Where " +
          //          "Nachname LIKE '%" + eingabe + "%'";

          //      MessageBox.Show(sql.CommandText);

          //      reader = sql.ExecuteReader();

          //      // spnummer.Clear();

          //      while (reader.Read())
          //      {
          //          label1.Text.Select(reader["Nachname"] + "          " +
          //              reader["Vorname"]);
          //      }
          //      reader.Close();
          //  }
          //  catch (Exception)
          //  {

          //      throw;
          //  }

          //  String strSql = "SELECT * FROM Person WHERE Nachname LIKE '" + eingabe + "%'";
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            Form11 fr = new Form11(this);
            fr.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form13 fr = new Form13(this);
            fr.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SpieleLogin fr = new SpieleLogin(this);
            fr.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form12 fr = new Form12(this);
            fr.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DateTime geburt;
            DateTime heute = DateTime.Today;

            con.Open();
            sql.CommandText = "SELECT * FROM Person";
            reader = sql.ExecuteReader();
            reader.Read();

            int prüfung;

            geburt = Convert.ToDateTime(reader["Geburtsdatum"]);

            prüfung = DateTime.Compare(heute, geburt);
            if (prüfung > 18 )
            {
                MessageBox.Show("Der Kunde ist zu jung und wird aus der Datenbank gelöscht");

                try
                {
                    con.Open();
                    sql.CommandText = "DELETE FROM vermietung WHERE Geburtsdatum =< " + "'01.01.2000'";
                    MessageBox.Show(sql.CommandText);

                    int anzahl = sql.ExecuteNonQuery();
                    if (anzahl > 0)
                        MessageBox.Show("Datensatz gelöscht");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close();
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            String connect = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=Logindaten.accdb";
            con = new OleDbConnection(connect);
            con.Open();
            sql = con.CreateCommand();
            sql.CommandText = "insert into logdatei(programmstart, datum)" +
                " values('Arbeitsbeginn', '" + DateTime.Now + "');";
            sql.ExecuteNonQuery();
            con.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String connect = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=Logindaten.accdb";
            con = new OleDbConnection(connect);
            con.Open();
            sql = con.CreateCommand();
            sql.CommandText = "insert into logdatei(programmstart, datum)" +
                " values('Arbeitsende', '" + DateTime.Now + "');";
            sql.ExecuteNonQuery();
            con.Close();
        }
    }
}
