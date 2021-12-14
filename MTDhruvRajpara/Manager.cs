using System;
using System.Collections.Generic;
using System.Text;

namespace MTDhruvRajpara
{
    class Manager : Person
    {
        private int _playersRecruited;

        public int PlayersRecruited
        {
            get { return _playersRecruited; }
            set { _playersRecruited = value; }

        }


        private double _availabelBudget;

        public double AvailableBudget
        {
            get { return _availabelBudget; }
            set { _availabelBudget = value; }
        }

        private String _strength;

        public String Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }

   

        public Manager(int id, String name, int playersRecruited, double availableBudget, String strength) : base(id, name)
        {
            PlayersRecruited = playersRecruited;
            AvailableBudget = availableBudget;
            Strength = strength;
        }
    }
}
