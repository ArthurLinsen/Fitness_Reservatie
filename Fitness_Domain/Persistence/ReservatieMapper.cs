using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Fitness_Domain.Business;

namespace Fitness_Domain.Persistence
{
    class ReservatieMapper
    {
        //fields
        private string _connectionString;
        //properties
        //constructor
        public ReservatieMapper()
        {
            _connectionString = "server = localhost; user id = root; password=1234;database=fitnessreservatie";
        }
        public ReservatieMapper(string connstring)
        {
            _connectionString = connstring;
        }
        //methods
        public List<Business.Reservatie> getReservatiesFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM fitnessreservatie.reservatie", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<Reservatie> returnlist = new List<Reservatie>();

            while (dataReader.Read())
            {
                int FKLid = 0;
                if (!Convert.IsDBNull(dataReader[3])) FKLid = Convert.ToInt32(dataReader[3]);
                Business.Reservatie item = new Business.Reservatie(
                    Convert.ToInt32(dataReader[0]),
                    Convert.ToDateTime(dataReader[1]),
                    Convert.ToString(dataReader[2]),
                    FKLid,
                    Convert.ToInt32(dataReader[4]),
                    Convert.ToBoolean(dataReader[5]));
                returnlist.Add(item);
            }
            conn.Close();
            return returnlist;
        }
        public List<Business.Reservatie> getVrijeReservatiesFromDB(string connString) //aanpassen
        {
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand("SELECT reservatie.idReservatie, reservatie.Datum, reservatie.Tijdstip, reservatie.FKLes " +
                "FROM fitnessreservatie.reservatie " +
                "INNER JOIN fitnessreservatie.les ON les.idLes = reservatie.FKLES " +
                "WHERE reservatie.Beschikbaar is false", conn);
         
            conn.Open();

            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<Reservatie> returnlist = new List<Reservatie>();

            while (dataReader.Read())
            {
                Business.Reservatie item = new Business.Reservatie(
                    Convert.ToInt32(dataReader[0]),
                    Convert.ToDateTime(dataReader[1]),
                    Convert.ToString(dataReader[2]),
                    Convert.ToInt32(dataReader[3]));
                returnlist.Add(item);
            }
            conn.Close();
            return returnlist;
        }
        public List<Business.Reservatie> getVrijeReservatiesFromGekozenLesFromDB(string connString, int idLes)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * " +
                "FROM fitnessreservatie.reservatie " +
                "WHERE reservatie.Beschikbaar = false and FKLes = @idLes", conn);
            cmd.Parameters.AddWithValue("idLes", idLes);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<Reservatie> returnlist = new List<Reservatie>();

            while (dataReader.Read())
            {
                int FKLid = 0;
                if (!Convert.IsDBNull(dataReader[3])) FKLid = Convert.ToInt32(dataReader[3]);
                Business.Reservatie item = new Business.Reservatie(
                    Convert.ToInt32(dataReader[0]),
                    Convert.ToDateTime(dataReader[1]),
                    Convert.ToString(dataReader[2]),
                    FKLid,
                    Convert.ToInt32(dataReader[4]),
                    Convert.ToBoolean(dataReader[5]));
                returnlist.Add(item);
            }
            conn.Close();
            return returnlist;
        }
        public void addReservatiesInDB(Business.Reservatie reser)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO fitnessreservatie.reservatie (Datum, Tijdstip,  FKLes, Beschikbaar) VALUES (@datum, @tijd, @fkles, 0)", conn);
            
            cmd.Parameters.AddWithValue("datum", reser.Datum);
            cmd.Parameters.AddWithValue("tijd", reser.Tijdstip);
            cmd.Parameters.AddWithValue("fkles", reser.FKLes);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void reserveerBeschikbareReservatieInDB(string connString, int indexReservatie,int FKLid)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            int idReservatie= getVrijeReservatiesFromDB(connString)[indexReservatie].IDReservatie;
            MySqlCommand cmd = new MySqlCommand("UPDATE fitnessreservatie.reservatie SET FKLid = @fklid, Beschikbaar = true WHERE (idReservatie = @idReservatie)", conn);
            cmd.Parameters.AddWithValue("fklid", FKLid);
            cmd.Parameters.AddWithValue("idreservatie", idReservatie);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
