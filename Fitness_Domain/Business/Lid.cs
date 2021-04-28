using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Domain.Business
{
    public class Lid
    {
        //fields
        private int _idLid;
        private string _familieNaam;
        private string _voorNaam;
        private DateTime _geboorteDatum;
        private string _adres;
        private int _postcode;
        private string _gemeente;
        private string _telefoonnummer;
        private string _emailadres;
        private string _rijksregisternummer;
        //properties
        public int IDLid
        { get { return _idLid; } }
        public string FamilieNaam
        {
            get { return _familieNaam; }
            set { _familieNaam = value; }
        }
        public string VoorNaam
        {
            get { return _voorNaam; }
            set { _voorNaam = value; }
        }
        public DateTime GeboorteDatum
        {
            get { return _geboorteDatum; }
            set { _geboorteDatum = value; }
        }
        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }
        public int Postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }
        public string Gemeente
        {
            get { return _gemeente; }
            set { _gemeente = value; }
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
        public string Rijksregisternummer
        {
            get { return _rijksregisternummer; }
            set { _rijksregisternummer = value; }
        }
        //constructor
        public Lid(int idLid, string familieNaam, string voorNaam, DateTime geboorteDatum, string adres, int postcode, string gemeente, string telefoonnummer, string emailadres, string rijksregisternummer)
        {
            _idLid = idLid;
            _familieNaam = familieNaam;
            _voorNaam = voorNaam;
            _geboorteDatum = geboorteDatum;
            _adres = adres;
            _postcode = postcode;
            _gemeente = gemeente;
            _telefoonnummer = telefoonnummer;
            _emailadres = emailadres;
            _rijksregisternummer = rijksregisternummer;
        }
        public Lid(string familieNaam, string voorNaam, DateTime geboorteDatum, string adres, int postcode, string gemeente, string telefoonnummer, string emailadres, string rijksregisternummer)
        {
            _idLid = 0;
            _familieNaam = familieNaam;
            _voorNaam = voorNaam;
            _geboorteDatum = geboorteDatum;
            _adres = adres;
            _postcode = postcode;
            _gemeente = gemeente;
            _telefoonnummer = telefoonnummer;
            _emailadres = emailadres;
            _rijksregisternummer = rijksregisternummer;
        }
        //methods
        public override string ToString()
        {
            return _idLid + " - " + _familieNaam + " - " + _voorNaam + " - " + _geboorteDatum + " - " + _adres + " - " + _postcode + " - " + _gemeente + " - "+ _telefoonnummer + " - " + _emailadres + " - " + _rijksregisternummer;
        }
    }
}