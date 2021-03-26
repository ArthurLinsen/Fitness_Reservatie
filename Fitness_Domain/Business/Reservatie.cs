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
        //constructor
        public Reservatie(int idReservatie, DateTime datum, string tijdstip, int fkLid, int fkLes)
        {
            _idReservatie = idReservatie;
            _datum = datum;
            _tijdstip = tijdstip;
            _fkLid = fkLid;
            _fkLes = fkLes;
        }
        //methods
        public override string ToString()
        {
            return _idReservatie + " - " + _datum + " - " + _tijdstip + " - " + _fkLid + " - " + _fkLes;
        }
    }
}
