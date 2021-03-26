using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Fitness_Domain.Business;

namespace Fitness_Domain.Persistence
{
    class FitnessClubGeeftLesMapper
    {
        //fields
        private string _connectionString;
        //properties
        //constructor
        public FitnessClubGeeftLesMapper()
        {
            _connectionString = "server = localhost; user id = root; password=1234;database=fitnessreservatie";
        }
        public FitnessClubGeeftLesMapper(string connstring)
        {
            _connectionString = connstring;
        }
        //methods
        public List<Business.FitnessClubGeeftLes> getFitnessClubsGeeftLessenFromDB()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM fitnessreservatie.fitnessclubgeeftles", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<FitnessClubGeeftLes> returnlist = new List<FitnessClubGeeftLes>();

            while (dataReader.Read())
            {
                Business.FitnessClubGeeftLes item = new Business.FitnessClubGeeftLes(
                    Convert.ToInt32(dataReader[0]),
                    Convert.ToInt32(dataReader[1]));
                returnlist.Add(item);
            }
            conn.Close();
            return returnlist;
        }
        public void addFitnessClubGeeftLesInDB(Business.FitnessClubGeeftLes fitclubles)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO fitnessreservatie.fitnessclubgeeftles (FKFitnessClub, FKLes) VALUES (@fitclub, @fkles", conn);
            cmd.Parameters.AddWithValue("fitclub", fitclubles.FKFitnessClub);
            cmd.Parameters.AddWithValue("fkles", fitclubles.FKLes);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
