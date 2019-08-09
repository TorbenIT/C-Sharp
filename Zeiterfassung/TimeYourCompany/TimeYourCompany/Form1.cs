/* Autor: Tobias Schneider
   Erstellt: 0711:2018
   */

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


namespace TimeYourCompany
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand sql = new OleDbCommand();
        OleDbDataReader reader;

        private Login fh;
        public Form1(Login aufrufer, string vorname, string nachname)
        {
            fh = aufrufer;
            InitializeComponent();
            label1.Text = "Hallo, " + vorname;
            labelOutput.Text = "" + nachname;
        }

        /* Anwesendheitskontrolle
            zum Beispiel könnte man eine Zeit vorprogrammieren 9:00, wenn der Mitarbeiter zu dieser Zeit 
            anwesend ist, wird eine Messagebox ausgegeben.
            Arbeitszeitanfang wird mit 9:00 verglichen
         */
        public string TheValue
        {
            get { return labelOutput.Text;  }
        }


        public void btnWorkstart_Click(object sender, EventArgs e)
        {
            DateTime startedWork = DateTime.Now;
            textBoxOutput.Text = startedWork.ToString();
            
            String connect = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=Employees.accdb";
            con = new OleDbConnection(connect);
            con.Open();
            sql = con.CreateCommand();
            sql.CommandText = "insert into Zeitmanager(Beginn)" +
                " values('" + DateTime.Now + "') where Nachname Like '" + labelOutput.Text + "'";
            sql.ExecuteNonQuery();
            con.Close();
        }

        private void btnWorkEnds_Click(object sender, EventArgs e)
        {
            String connect = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=Employees.accdb";
            con = new OleDbConnection(connect);
            con.Open();
            sql = con.CreateCommand(); /* datapicker[1].format = time*/
            sql.CommandText = "insert into Zeitmanager(Ende)" +
                " values('" + DateTime.Now + "');";
            sql.ExecuteNonQuery();
            con.Close();
        }

        private void btnBreaks_Click(object sender, EventArgs e)
        {
            String connect = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=Employees.accdb";
            con = new OleDbConnection(connect);
            con.Open();
            sql = con.CreateCommand();
            sql.CommandText = "insert into Stammdaten(Pauseanfang)" +
                " values('" + DateTime.Now + "');";
            sql.ExecuteNonQuery();
            con.Close();
        }

        private void btnBreakEnds_Click(object sender, EventArgs e)
        {
            String connect = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=Employees.accdb";
            con = new OleDbConnection(connect);
            con.Open();
            sql = con.CreateCommand();
            sql.CommandText = "insert into Stammdaten(Pauseende)" +
                " values('" + DateTime.Now + "');";
            sql.ExecuteNonQuery();
            con.Close();
        }

        //private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        //{
        //    String connect = "Provider=Microsoft.ACE.OLEDB.12.0;" +
        //    "Data Source=Employees.accdb";
        //    con = new OleDbConnection(connect);
        //    con.Open();
        //    sql = con.CreateCommand();
        //    sql.CommandText = "insert into Stammdaten(Arbeitszeitbeginn)" +
        //        " values('" + DateTime.Now + "');";
        //    sql.ExecuteNonQuery();
        //    con.Close();
        //}

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            var date = sender as MonthCalendar;
            textBoxOutput.Text = date.SelectionStart.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelOutput.Text = (string)Session["name"];
        }
    }
}
