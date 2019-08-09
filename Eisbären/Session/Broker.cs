using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Domain;
using System.Data;

namespace Session
{
    public class Broker
    {
        OleDbConnection connection;
        OleDbCommand command;

        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
                                "Data Source=Logindaten.accdb");
            command = connection.CreateCommand();
        }

        public Broker()
        {
            ConnectTo();
        }

        //public void Kaufen(Artikel a)
        //{
        //    try
        //    {
        //        command.CommandText = "INSERT INTO Artikel Where Bezeichnung='" + listbo(Rechnung) VALUES('" + a.Pay + "')";
        //        command.CommandType = CommandType.Text;
        //        connection.Open();

        //        command.ExecuteNonQuery();
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    finally
        //    {
        //        if (connection != null)
        //        {
        //            connection.Close();
        //        }
        //    }
        //}


        public void Insert(Artikel a)
        {
            try
            {
                command.CommandText = "INSERT INTO Artikel (Bezeichnung, Preis) VALUES('" + a.Bezeichnung + "', '" + a.Price + "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Artikel> FillComboBox()
        {
            List<Artikel> artikelList = new List<Artikel>();
            try
            {
                command.CommandText = "SELECT * FROM Artikel";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Artikel a = new Artikel();

                    a.Bezeichnung = reader["Bezeichnung"].ToString();

                    artikelList.Add(a);
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return artikelList;
        }

        public List<Artikel> FillListBox()
        {
            List<Artikel> artikelList = new List<Artikel>();
            try
            {
                command.CommandText = "SELECT * FROM Artikel";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Artikel a = new Artikel();

                    a.Art_nr = Convert.ToInt32(reader["art_nr"].ToString());
                    a.Bezeichnung = reader["Bezeichnung"].ToString();
                    a.Price = Convert.ToInt32(reader["Preis"].ToString());

                    artikelList.Add(a);
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return artikelList;
        }
    }
}
