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
        private Lid _user;
        private Les _gekozenLes;
        //properties
        //constructor
        public Controller()
        {
            _persistController = new Persistence.Controller();
        }
        public Controller(string connstring)
        {
            _persistController = new Persistence.Controller(connstring);
        }
        //methods
        //leden
        public List<Lid> getLeden()
        {
            //return _fitness.LidLijst;
            return _persistController.getLeden();
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
            return _persistController.getLessen();
        }
        public void setLes(Les les)
        {
            _persistController.addLes(les);
        }
        //categorieën
        public List<Categorie> getCategories()
        {
            return _persistController.getCategories();
        }
        public void setCategories(Categorie cate)
        {
            _persistController.addCategorie(cate);
        }
        //reservaties
        public List<Reservatie> getReservaties()
        {
            return _persistController.getReservaties();
        }
        public void setReservatie(Reservatie reser)
        {
            _persistController.addReservatie(reser);
        }
        public void setReservatie(DateTime datum,string tijdstip,int indexLes)
        {
            Reservatie reser = new Reservatie(datum, tijdstip, _persistController.getLessen()[indexLes].IDLes);
            _persistController.addReservatie(reser);
        }
        //fitnessclubs
        public List<FitnessClub> getFitnessClubs()
        {
            return _persistController.getFitnessClubs();
        }
        public void setFitnessClub(FitnessClub fitclub)
        {
            _persistController.addFitnessClub(fitclub);
        }
        //fitnessclubsgevenles
        public List<FitnessClubGeeftLes> getFitnessClubGeeftLes()
        {
            return _persistController.getFitnessClubsGevenLessen();
        }
        public void setFitnessClubGeeftLes(FitnessClubGeeftLes fitclubles)
        {
            _persistController.addFitnessClubGeeftLes(fitclubles);
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
        //beschikbare reservaties
        public List<Business.Reservatie> getVrijeReservaties()
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
        public List<Business.Reservatie> getVrijeReservatieFromGekozenLes()
        {
             return _persistController.getVrijeReservatieFromGekozenLes(_gekozenLes.IDLes);
        }
    }
}
