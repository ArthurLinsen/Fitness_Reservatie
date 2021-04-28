using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Fitness_Domain.Business;

namespace Fitness_Domain.Persistence
{
    class Controller
    {
        //fields
        private string _connectionString;
        //properties
        //constructor
        public Controller()
        {
            _connectionString = "server = localhost; user id = root; password=1234;database=fitnessreservatie";
        }
        public Controller(string connstring)
        {
            _connectionString = connstring;
        }
        //methods
        //leden
        public List<Lid> getLeden()
        {
            LidMapper mapper = new LidMapper(_connectionString); //_connstring omdraaien?
            return mapper.getLedenFromDB();
        }
        public void addLid(Lid lid)
        {
            LidMapper mapper = new LidMapper(_connectionString); //_connstring omdraaien?
            mapper.addLedenInDB(lid);
        }
        //categorieën
        public List<Categorie> getCategories()
        {
            CategorieMapper mapper = new CategorieMapper(_connectionString);
            return mapper.getCategoriesFromDB();
        }
        public void addCategorie(Categorie cate)
        {
            CategorieMapper mapper = new CategorieMapper(_connectionString);
            mapper.addCategoriesInDB(cate);
        }
        //lessen
        public List<Les> getLessen()
        {
            LesMapper mapper = new LesMapper(_connectionString);
            return mapper.getLessenFromDB();
        }
        public void addLes(Les les)
        {
            LesMapper mapper = new LesMapper(_connectionString);
            mapper.addLessenInDB(les);
        }
        //reservaties
        public List<Reservatie> getReservaties()
        {
            ReservatieMapper mapper = new ReservatieMapper(_connectionString);
            return mapper.getReservatiesFromDB();
        }
        public void addReservatie(Reservatie reser)
        {
            ReservatieMapper mapper = new ReservatieMapper(_connectionString);
            mapper.addReservatiesInDB(reser);
        }
        //fitnessclub
        public List<FitnessClub> getFitnessClubs()
        {
            FitnessClubMapper mapper = new FitnessClubMapper(_connectionString);
            return mapper.getFitnessClubsFromDB();
        }
        public void addFitnessClub(FitnessClub fitclub)
        {
            FitnessClubMapper mapper = new FitnessClubMapper(_connectionString);
            mapper.addFitnessClubInDB(fitclub);
        }
        //fitnessclubgeeftles
        public List<FitnessClubGeeftLes> getFitnessClubsGevenLessen()
        {
            FitnessClubGeeftLesMapper mapper = new FitnessClubGeeftLesMapper(_connectionString);
            return mapper.getFitnessClubsGeeftLessenFromDB();
        }
        public void addFitnessClubGeeftLes(FitnessClubGeeftLes fitclubles)
        {
            FitnessClubGeeftLesMapper mapper = new FitnessClubGeeftLesMapper(_connectionString);
            mapper.addFitnessClubGeeftLesInDB(fitclubles);
        }
        //vrijereservaties
        public List<VrijeReservatie> getVrijeReservaties()
        {
            ReservatieMapper mapper = new ReservatieMapper();
            return mapper.getVrijeReservatiesFromDB(_connectionString);
        }
        public List<VrijeReservatie> getVrijeReservatieFromGekozenLes(int idLes)
        {
            ReservatieMapper mapper = new ReservatieMapper();
            return mapper.getVrijeReservatiesFromGekozenLesFromDB(_connectionString, idLes);
        }
        public void reserveerBeschikbareReservatie(int indexReservatie, int FKLid)
        {
            ReservatieMapper mapper = new ReservatieMapper();
             mapper.reserveerBeschikbareReservatieInDB(_connectionString, indexReservatie, FKLid);
        }
    }
}
