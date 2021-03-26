using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Domain.Business
{
    class Fitness
    {
        //fields
        List<Lid> _lidLijst;
        List<Categorie> _categorieLijst;
        List<Les> _lesLijst;
        List<Reservatie> _reservatieLijst;
        List<FitnessClub> _fitnessClubLijst;
        List<FitnessClubGeeftLes> _fitnessClubGeeftLesLijst;
        //properties
        public List<Lid> LidLijst
        {
            get { return _lidLijst; }
            set { _lidLijst = value; }
        }
        public List<Categorie> CategorieLijst
        {
            get { return _categorieLijst; }
            set { _categorieLijst = value; }
        }
        public List<Les> LesLijst
        {
            get { return _lesLijst; }
            set { _lesLijst = value; }
        }
        public List<Reservatie> ReservatieLijst
        {
            get { return _reservatieLijst; }
            set { _reservatieLijst = value; }
        }
        public List<FitnessClub> FitnessClubLijst
        {
            get { return _fitnessClubLijst; }
            set { _fitnessClubLijst = value; }
        }
        public List<FitnessClubGeeftLes> FitnessClubGeeftLesLijst
        {
            get { return _fitnessClubGeeftLesLijst; }
            set { _fitnessClubGeeftLesLijst = value; }
        }
        //constructor
        public Fitness()
        {
            _lidLijst = new List<Lid>();
            _categorieLijst = new List<Categorie>();
            _lesLijst = new List<Les>();
            _reservatieLijst = new List<Reservatie>();
            _fitnessClubLijst = new List<FitnessClub>();
            _fitnessClubGeeftLesLijst = new List<FitnessClubGeeftLes>();
        }
        public Fitness(List<Lid> leden, List<Categorie> categories, List<Les> lessen,List<Reservatie> reservaties, List<FitnessClub> fitnessClubs, List<FitnessClubGeeftLes> fitnessClubsGevenLessen)
        {
            _lidLijst = leden;
            _categorieLijst = categories;
            _lesLijst = lessen;
            _reservatieLijst = reservaties;
            _fitnessClubLijst = fitnessClubs;
            _fitnessClubGeeftLesLijst = fitnessClubsGevenLessen;
        }
        //methods
    }
}
