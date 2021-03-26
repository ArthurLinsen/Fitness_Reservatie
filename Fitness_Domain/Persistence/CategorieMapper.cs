using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Fitness_Domain.Business;

namespace Fitness_Domain.Persistence
{
    class CategorieMapper
    {
        //fields
        private string _connectionString;
        //properties
        //constructor
        public CategorieMapper()
        {
            _connectionString = "server = localhost; user id = root; password=1234;database=fitnessreservatie";
        }
        public CategorieMapper(string connstring)
        {
            _connectionString = connstring;
        }
        //methods
        public List<Business.Categorie> getCategoriesFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM fitnessreservatie.categorie", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<Categorie> returnList = new List<Categorie>();

            while (dataReader.Read())
            {
                Business.Categorie item = new Business.Categorie(
                    Convert.ToInt32(dataReader[0]),
                    Convert.ToString(dataReader[1]),
                    Convert.ToString(dataReader[2]));
                returnList.Add(item);
            }
            conn.Close();
            return returnList;
        }
        public void addCategoriesInDB(Business.Categorie cate)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO fitnessreservatie.categorie (Naam, Omschrijving) VALUES (@naam, @omschr", conn);
            cmd.Parameters.AddWithValue("naam", cate.NaamCategorie);
            cmd.Parameters.AddWithValue("omschr", cate.OmschrijvingCategorie);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
