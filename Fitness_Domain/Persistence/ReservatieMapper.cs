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
                    Convert.ToInt32(dataReader[4]));
                returnlist.Add(item);
            }
            conn.Close();
            return returnlist;
        }
        public List<Business.VrijeReservatie> getVrijeReservatiesFromDB(string connString)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand("SELECT reservatie.idReservatie, reservatie.Datum, reservatie.Tijdstip, les.Naam " +
                "FROM fitnessreservatie.reservatie " +
                "INNER JOIN fitnessreservatie.les ON les.idLes = reservatie.FKLES " +
                "WHERE reservatie.FKLid is null ", conn);
         
            conn.Open();

            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<VrijeReservatie> returnlist = new List<VrijeReservatie>();

            while (dataReader.Read())
            {
                Business.VrijeReservatie item = new Business.VrijeReservatie(
                    Convert.ToInt32(dataReader[0]),
                    Convert.ToDateTime(dataReader[1]),
                    Convert.ToString(dataReader[2]),
                    Convert.ToString(dataReader[3]));
                returnlist.Add(item);
            }
            conn.Close();
            return returnlist;
        }
        //public List<Business.Reservatie> getReservatiesFromLidFromDB(string connString, int idLid)
        //{
        //    MySqlConnection conn = new MySqlConnection(connString);
        //    MySqlCommand cmd = new MySqlCommand("SELECT reservatie.idReservatie, reservatie.Datum, reservatie.Tijdstip, " +
        //        "lid.FamilieNaam, lid.VoorNaam, les.Naam " +
        //        "FROM fitnessreservatie.reservatie " +
        //        "INNER JOIN fitnessreservatie.lid ON lid.idLid = reservatie.FKLid " +
        //        "INNER JOIN fitnessreservatie.les ON les.idLes = reservatie.FKLES " +
        //        "WHERE idLid = @idLid; ", conn);
        //    cmd.Parameters.AddWithValue("idLid", idLid);

        //    conn.Open();

        //    MySqlDataReader dataReader = cmd.ExecuteReader();
        //    List<Reservatie> returnlist = new List<Reservatie>();

        //    while (dataReader.Read())
        //    {
        //        Business.Reservatie item = new Business.Reservatie(
        //            Convert.ToInt32(dataReader[0]),
        //            Convert.ToDateTime(dataReader[1]),
        //            Convert.ToString(dataReader[2]),
        //            Convert.ToInt32(dataReader[3]),
        //            Convert.ToInt32(dataReader[4]));
        //        returnlist.Add(item);
        //    }
        //    conn.Close();
        //    return returnlist;
        //}
        public List<VrijeReservatie> getVrijeReservatiesFromGekozenLesFromDB(string connString, int idLes)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * " +
                "FROM fitnessreservatie.reservatie " +
                "WHERE reservatie.FKLid is null and FKLes = @idLes", conn);
            cmd.Parameters.AddWithValue("idLes", idLes);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            List<Reservatie> returnlist = new List<Reservatie>(); //fout tussen "Reservatie" & "VrijeReservatie"

            while (dataReader.Read())
            {
                int FKLid = 0;
                if (!Convert.IsDBNull(dataReader[3])) FKLid = Convert.ToInt32(dataReader[3]);
                Business.Reservatie item = new Business.Reservatie(
                    Convert.ToInt32(dataReader[0]),
                    Convert.ToDateTime(dataReader[1]),
                    Convert.ToString(dataReader[2]),
                    FKLid,
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
        public void reserveerBeschikbareReservatieInDB(string connString, int indexReservatie,int FKLid)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            int idReservatie= getVrijeReservatiesFromDB(connString)[indexReservatie].IDReservatie;
            MySqlCommand cmd = new MySqlCommand("UPDATE fitnessreservatie.reservatie SET FKLid = @fklid,  WHERE (idReservatie = @idReservatie)", conn);
          cmd.Parameters.AddWithValue("fklid", FKLid);
            cmd.Parameters.AddWithValue("idreservatie", idReservatie);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
