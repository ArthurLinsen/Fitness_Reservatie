using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Fitness_Domain.Business;

namespace Fitness_Domain.Persistence
{
    class FitnessClubMapper
    {
        //fields
        private string _connectionString;
        //properties
        //constructor
        public FitnessClubMapper()
        {
            _connectionString = "server = localhost; user id = root; password=1234;database=fitnessreservatie";
        }
        public FitnessClubMapper(string connstring)
        {
            _connectionString = connstring;
        }
        //methods
        public List<Business.FitnessClub> getFitnessClubsFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM fitnessreservatie.fitnessclub", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<FitnessClub> returnlist = new List<FitnessClub>();

            while (dataReader.Read())
            {
                Business.FitnessClub item = new Business.FitnessClub(
                    Convert.ToInt32(dataReader[0]),
                    Convert.ToString(dataReader[1]),
                    Convert.ToString(dataReader[2]),
                    Convert.ToString(dataReader[3]),
                    Convert.ToString(dataReader[4]),
                    Convert.ToString(dataReader[5]));
                returnlist.Add(item);
            }
            conn.Close();
            return returnlist;
        }
        public void addFitnessClubInDB(Business.FitnessClub fitclub)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO fitnessreservatie.fitnessclub (Naam, Adres, Telefoonnummer, Emailadres, Openingsuren) VALUES (@naam, @adres, @tele, @email, @open", conn);
            cmd.Parameters.AddWithValue("naam", fitclub.Naam);
            cmd.Parameters.AddWithValue("adres", fitclub.Adres);
            cmd.Parameters.AddWithValue("tele", fitclub.Telefoonnummer);
            cmd.Parameters.AddWithValue("email", fitclub.Emailadres);
            cmd.Parameters.AddWithValue("open", fitclub.Openingsuren);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
