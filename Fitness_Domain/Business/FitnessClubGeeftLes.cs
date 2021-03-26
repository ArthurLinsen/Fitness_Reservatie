using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Domain.Business
{
    public class FitnessClubGeeftLes
    {
        //fields
        private int _fkFitnessClub;
        private int _fkLes;
        //properties
        public int FKFitnessClub
        {
            get { return _fkFitnessClub; }
            set { _fkFitnessClub = value; }
        }
        public int FKLes
        {
            get { return _fkLes; }
            set { _fkLes = value; }
        }
        //constructor
        public FitnessClubGeeftLes(int fkFitnessClub, int fkLes)
        {
            _fkFitnessClub = fkFitnessClub;
            _fkLes = fkLes;
        }
        //methods
        public override string ToString()
        {
            return _fkFitnessClub + " - " + _fkLes;
        }
    }
}
