using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Domain.Business
{
    public class Categorie
    {
        //fields
        private int _idCategorie;
        private string _naamCategorie;
        private string _omschrijvingCategorie;
        //properties
        public int IDCategorie
        { get { return _idCategorie; } }
        public string NaamCategorie
        {
            get { return _naamCategorie; }
            set { _naamCategorie = value; }
        }
        public string OmschrijvingCategorie
        {
            get { return _omschrijvingCategorie; }
            set { _omschrijvingCategorie = value; }
        }
        //constructor
        public Categorie(int idCategorie, string naamCategorie, string omschrijvingCategorie)
        {
            _idCategorie = idCategorie;
            _naamCategorie = naamCategorie;
            _omschrijvingCategorie = omschrijvingCategorie;
        }
        public Categorie(string naamCategorie, string omschrijvingCategorie)
        {
            _idCategorie = 0;
            _naamCategorie = naamCategorie;
            _omschrijvingCategorie = omschrijvingCategorie;
        }
        //methods
        public override string ToString()
        {
            return _idCategorie + " - " + _naamCategorie + ": " + _omschrijvingCategorie;
        }
    }
}
