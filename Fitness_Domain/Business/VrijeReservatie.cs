using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Domain.Business
{
    public class VrijeReservatie
    {
        //fields
        private int _idReservatie;
        private DateTime _datum;
        private string _tijdstip, _lesnaam;
       
        //properties
        public int IDReservatie
        { get { return _idReservatie; } }
        public DateTime Datum
        {
            get { return _datum; }
            set { _datum = value; }
        }
        public string Tijdstip
        {
            get { return _tijdstip; }
            set { _tijdstip = value; }
        }
        public string Lesnaam
        {
            get { return _lesnaam; }
            set { _lesnaam= value; }
        }
        //constructor
        public VrijeReservatie(int idReservatie, DateTime datum, string tijdstip, string lesnaam)
        {
            _idReservatie = idReservatie;
            _datum = datum;
            _tijdstip = tijdstip;
            _lesnaam = lesnaam;
        }
        public VrijeReservatie(DateTime datum, string tijdstip, string lesnaam)
        {
            _idReservatie = 0;
            _datum = datum;
            _tijdstip = tijdstip;
            _lesnaam = lesnaam;
        }
        //methods
        public override string ToString()
        {
            return _idReservatie + " - " + _datum + " - " + _tijdstip + " - " + _lesnaam;
        }
    }
}
