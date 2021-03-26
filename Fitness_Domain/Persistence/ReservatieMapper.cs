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
                Business.Reservatie item = new Business.Reservatie(
                    Convert.ToInt32(dataReader[0]),
                    Convert.ToDateTime(dataReader[1]),
                    Convert.ToString(dataReader[2]),
                    Convert.ToInt32(dataReader[3]),
                    Convert.ToInt32(dataReader[4]));
                returnlist.Add(item);
            }
            conn.Close();
            return returnlist;
        }
        public void addReservatiesInDB(Business.Reservatie reser)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO fitnessreservatie.reservatie (Datum, Tijdstip, FKLid, FKLes) VALUES (@datum, @tijd, @fklid, @fkles", conn);
            cmd.Parameters.AddWithValue("datum", reser.Datum);
            cmd.Parameters.AddWithValue("tijd", reser.Tijdstip);
            cmd.Parameters.AddWithValue("fklid", reser.FKLid);
            cmd.Parameters.AddWithValue("fkles", reser.FKLes);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
