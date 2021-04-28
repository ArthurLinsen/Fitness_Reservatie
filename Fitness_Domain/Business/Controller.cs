using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitness_Domain.Persistence;

namespace Fitness_Domain.Business
{
    public class Controller
    {
        //fields
        private Persistence.Controller _persistController;
        private Fitness _fitness;
        private Lid _user;
        private Les _gekozenLes;
        //properties
        //constructor
        public Controller()
        {
            _persistController = new Persistence.Controller();
            _fitness = new Fitness();
            _fitness.LidLijst = _persistController.getLeden();
            _fitness.LesLijst = _persistController.getLessen();
            _fitness.CategorieLijst = _persistController.getCategories();
            _fitness.ReservatieLijst = _persistController.getReservaties();
            _fitness.VrijeReservatieLijst = _persistController.getVrijeReservaties();
            _fitness.FitnessClubLijst = _persistController.getFitnessClubs();
            _fitness.FitnessClubGeeftLesLijst = _persistController.getFitnessClubsGevenLessen();
        }
        public Controller(string connstring)
        {
            _persistController = new Persistence.Controller(connstring);
        }
        //methods
        //leden
        public List<Lid> getLeden()
        {
            return _fitness.LidLijst;
        }
        public bool setLid(string familieNaam, string voorNaam, DateTime geboorteDatum, string adres, int postcode, string gemeente, string telefoonnummer, string emailadres, string rijksregisternummer)
        {
            List<Lid> Ledenlijst = getLeden();
            foreach (Lid lid in Ledenlijst)
            {
                if (lid.Rijksregisternummer == rijksregisternummer)
                {
                    return false;
                }
            }
            Lid newLid = new Lid(familieNaam, voorNaam, geboorteDatum, adres, postcode, gemeente, telefoonnummer, emailadres, rijksregisternummer);
            _persistController.addLid(newLid);
            return true;
        }
        //lessen
        public List<Les> getLessen()
        {
            return _fitness.LesLijst;
        }
        public void setLes(Les les)
        {
            _persistController.addLes(les);
            _fitness.LesLijst.Add(les);
        }
        //categorieën
        public List<Categorie> getCategories()
        {
            return _fitness.CategorieLijst;
        }
        public void setCategories(Categorie cate)
        {
            _persistController.addCategorie(cate);
            _fitness.CategorieLijst.Add(cate);
        }
        //reservaties
        public List<Reservatie> getReservaties()
        {
            return _fitness.ReservatieLijst;
        }
        public void setReservatie(Reservatie reser)
        {
            _persistController.addReservatie(reser);
            _fitness.ReservatieLijst.Add(reser);
        }
        //fitnessclubs
        public List<FitnessClub> getFitnessClubs()
        {
            return _fitness.FitnessClubLijst;
        }
        public void setFitnessClub(FitnessClub fitclub)
        {
            _persistController.addFitnessClub(fitclub);
            _fitness.FitnessClubLijst.Add(fitclub);
        }
        //fitnessclubsgevenles
        public List<FitnessClubGeeftLes> getFitnessClubGeeftLes()
        {
            return _fitness.FitnessClubGeeftLesLijst;
        }
        public void setFitnessClubGeeftLes(FitnessClubGeeftLes fitclubles)
        {
            _persistController.addFitnessClubGeeftLes(fitclubles);
            _fitness.FitnessClubGeeftLesLijst.Add(fitclubles);
        }
        //login user
        public bool LoginUser(string emailadres)
        {
            List<Lid> Ledenlijst = getLeden();
            foreach (Lid lid in Ledenlijst)
            {
                if (lid.Emailadres == emailadres)
                {
                    _user = lid;
                    return true;
                }
            }
            return false;
        }
        //Beschikbare reservaties
        public List<VrijeReservatie> getVrijeReservaties()
        {
            return _persistController.getVrijeReservaties();
        }
        public void reserveerBeschikbareReservatie(int indexBeschikbareAfspraak)
        {
            _persistController.reserveerBeschikbareReservatie(indexBeschikbareAfspraak, _user.IDLid);
        } 
        
        //Les kiezen bij reservatie
        public void KiesLes(int indexLes)
        {
            _gekozenLes = getLessen()[indexLes];
        }
        public List<VrijeReservatie> getVrijeReservatieFromGekozenLes()
        {
            _persistController.getVrijeReservatieFromGekozenLes(_gekozenLes.IDLes);
        }
    }
}
