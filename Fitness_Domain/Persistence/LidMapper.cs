using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Fitness_Domain.Business;

namespace Fitness_Domain.Persistence
{
    class LidMapper
    {
        //fields
        private string _connectionString;
        //properties
        //constructor
        public LidMapper()
        {
            _connectionString = "server = localhost; user id = root; password=1234;database=fitnessreservatie";
        }
        public LidMapper(string connString)
        {
            _connectionString = connString;
        }
        //methods
        public List<Business.Lid> getLedenFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM fitnessreservatie.lid", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<Lid> returnList = new List<Lid>();

            while (dataReader.Read())
            {
                Business.Lid item = new Business.Lid(
                    Convert.ToInt32(dataReader[0]),
                    Convert.ToString(dataReader[1]),
                    Convert.ToString(dataReader[2]),
                    Convert.ToDateTime(dataReader[3]),
                    Convert.ToString(dataReader[4]),
                    Convert.ToInt32(dataReader[5]),
                    Convert.ToString(dataReader[6]),
                    Convert.ToString(dataReader[7]),
                    Convert.ToString(dataReader[8]),
                    Convert.ToString(dataReader[9]));
                returnList.Add(item);
            }
            conn.Close();
            return returnList;
        }
        public void addLedenInDB(Business.Lid lid)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO fitnessreservatie.lid (FamilieNaam, VoorNaam, GeboorteDatum, Adres, Postcode, Gemeente, Telefoonnummer, Emailadres, Rijksregisternummer) VALUES (@famNaam, @vNaam, @gDatum, @adres, @post, @geme, @tele, @email, @rijksNummer)", conn);

            cmd.Parameters.AddWithValue("famNaam", lid.FamilieNaam);
            cmd.Parameters.AddWithValue("vNaam", lid.VoorNaam);
            cmd.Parameters.AddWithValue("gDatum", lid.GeboorteDatum);
            cmd.Parameters.AddWithValue("adres", lid.Adres);
            cmd.Parameters.AddWithValue("post", lid.Postcode);
            cmd.Parameters.AddWithValue("geme", lid.Gemeente);
            cmd.Parameters.AddWithValue("tele", lid.Telefoonnummer);
            cmd.Parameters.AddWithValue("email", lid.Emailadres);
            cmd.Parameters.AddWithValue("rijksNummer", lid.Rijksregisternummer);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
