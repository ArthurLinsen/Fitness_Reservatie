using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Domain.Business
{
    public class Les
    {
        //fields
        private int _idLes;
        private string _naam;
        private int _maximumAantalPersonen;
        private string _omschrijving;
        private int _fkCategorie;
        //properties
        public int IDLes
        { get { return _idLes; } }
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public int MaximumAantalPersonen
        {
            get { return _maximumAantalPersonen; }
            set { _maximumAantalPersonen = value; }
        }
        public string Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }
        public int FKCategorie
        {
            get { return _fkCategorie; }
            set { _fkCategorie = value; }
        }
        //constructor
        public Les(int idLes, string Naam, int MaximumAantalPersonen, string Omschrijving, int fkCategorie)
        {
            _idLes = idLes;
            _naam = Naam;
            _maximumAantalPersonen = MaximumAantalPersonen;
            _omschrijving = Omschrijving;
            _fkCategorie = fkCategorie;
        }
        public Les(string Naam, int MaximumAantalPersonen, string Omschrijving, int fkCategorie)
        {
            _idLes = 0;
            _naam = Naam;
            _maximumAantalPersonen = MaximumAantalPersonen;
            _omschrijving = Omschrijving;
            _fkCategorie = fkCategorie;
        }
        //methods
        public override string ToString()
        {
            return _idLes + " - " + _naam + " - " + _maximumAantalPersonen + ": " + _omschrijving + " / " + _fkCategorie;
        }
    }
}
