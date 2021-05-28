using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Domain.Business
{
    public class Reservatie
    {
        //fields
        private int _idReservatie;
        private DateTime _datum;
        private string _tijdstip;
        private int _fkLid;
        private int _fkLes;
        private bool _beschikbaar;
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
        public int FKLid
        {
            get { return _fkLid; }
            set { _fkLid = value; }
        }
        public int FKLes
        {
            get { return _fkLes; }
            set { _fkLes = value; }
        }
        public bool Beschikbaar
        {
            get { return _beschikbaar; }
            set { _beschikbaar = value; }
        }
        //constructor
        public Reservatie(int idReservatie, DateTime datum, string tijdstip, int fkLid, int fkLes, bool beschikbaar)
        {
            _idReservatie = idReservatie;
            _datum = datum;
            _tijdstip = tijdstip;
            _fkLid = fkLid;
            _fkLes = fkLes;
            _beschikbaar = beschikbaar;
        }
        public Reservatie(DateTime datum, string tijdstip, int fkLid, int fkLes, bool beschikbaar)
        {
            _idReservatie = 0;
            _datum = datum;
            _tijdstip = tijdstip;
            _fkLid = fkLid;
            _fkLes = fkLes;
            _beschikbaar = beschikbaar;
        }
        //constructor beschikbare reservaties
        public Reservatie(int idReservatie, DateTime datum, string tijdstip, int fkLes)
        {
            _idReservatie = idReservatie;
            _datum = datum;
            _tijdstip = tijdstip;
            _fkLes = fkLes;
        }
        public Reservatie(DateTime datum, string tijdstip, int fkLes)
        {
            _idReservatie = 0;
            _datum = datum;
            _tijdstip = tijdstip;
            _fkLes = fkLes;
        }
        //methods
        public override string ToString()
        {
            return _idReservatie + " - " + _datum + " - " + _tijdstip + " - " + _fkLid + " - " + _fkLes + " - " + _beschikbaar;
        }
    }
}
