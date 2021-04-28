using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Fitness_Domain.Business;

namespace Fitness_Domain.Persistence
{
    class LesMapper
    {
        //fields
        private string _connectionString;
        //properties
        //constructor
        public LesMapper()
        {
            _connectionString = "server = localhost; user id = root; password=1234;database=fitnessreservatie";
        }
        public LesMapper(string connString)
        {
            _connectionString = connString;
        }
        //methods
        public List<Business.Les> getLessenFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM fitnessreservatie.les", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<Les> returnList = new List<Les>();

            while (dataReader.Read())
            {
                Business.Les item = new Business.Les(
                    Convert.ToInt32(dataReader[0]),
                    Convert.ToString(dataReader[1]),
                    Convert.ToInt32(dataReader[2]),
                    Convert.ToString(dataReader[3]),
                    Convert.ToInt32(dataReader[4]));
                returnList.Add(item);
            }
            conn.Close();
            return returnList;
        }
        public void addLessenInDB(Business.Les les)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO fitnessreservatie.les (Naam, MaximumAantalPersonen, FKCategorie, Omschrijving) VALUES (@naam, @maxPers, @fkCate, @omschr", conn);
            cmd.Parameters.AddWithValue("naam", les.Naam);
            cmd.Parameters.AddWithValue("maxPers", les.MaximumAantalPersonen);
            cmd.Parameters.AddWithValue("fkCate", les.FKCategorie);
            cmd.Parameters.AddWithValue("omschr", les.Omschrijving);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
