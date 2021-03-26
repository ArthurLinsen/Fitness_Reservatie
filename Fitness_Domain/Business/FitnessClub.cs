using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Domain.Business
{
    public class FitnessClub
    {
        //fields
        private int _idFitnessClub;
        private string _naam;
        private string _adres;
        private string _telefoonnummer;
        private string _emailadres;
        private string _openingsuren;
        //properties
        public int IDFitnessClub
        { get { return _idFitnessClub; } }
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }
        public string Telefoonnummer
        {
            get { return _telefoonnummer; }
            set { _telefoonnummer = value; }
        }
        public string Emailadres
        {
            get { return _emailadres; }
            set { _emailadres = value; }
        }
        public string Openingsuren
        {
            get { return _openingsuren; }
            set { _openingsuren = value; }
        }
        //constructor
        public FitnessClub(int idFitnessClub, string Naam, string Adres, string Telefoonnummer, string Emailadres, string Openingsuren)
        {
            _idFitnessClub = idFitnessClub;
            _naam = Naam;
            _adres = Adres;
            _telefoonnummer = Telefoonnummer;
            _emailadres = Emailadres;
            _openingsuren = Openingsuren;
        }
        public FitnessClub(string Naam, string Adres, string Telefoonnummer, string Emailadres, string Openingsuren)
        {
            _idFitnessClub = 0;
            _naam = Naam;
            _adres = Adres;
            _telefoonnummer = Telefoonnummer;
            _emailadres = Emailadres;
            _openingsuren = Openingsuren;
        }
        //methods
        public override string ToString()
        {
            return _idFitnessClub + " " + _naam + ": " + _adres + " - " + _telefoonnummer + " - " + _emailadres + ". " + _openingsuren;
        }
    }
}
