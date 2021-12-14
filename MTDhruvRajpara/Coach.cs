    using System;
using System.Collections.Generic;
using System.Text;

namespace MTDhruvRajpara
{
    class Coach : Person
    {
        private int _numberOfTeamsCoached;

        public int NumberOfTeansCoached
        {
            get { return _numberOfTeamsCoached; }
            set { _numberOfTeamsCoached = value; }

        }


        private int _playerTrained;

        public int PlayerTrained
        {
            get { return _playerTrained; }
            set { _playerTrained = value; }
        }

        private double _winPercentage;

        public double WinPercentage
        {
            get { return _winPercentage; }
            set { _winPercentage = value; }
        }

        private int _yearsOfExperience;

        public int YearsOfExperience
        {
            get { return _yearsOfExperience; }
            set { _yearsOfExperience = value; }
        }


        public Coach(int id, String name, int numberOfTeamsCoached, int playerTrained, double winPercentage, int yearsOfExperince) : base(id, name)
        {
            NumberOfTeansCoached = numberOfTeamsCoached;
            PlayerTrained = playerTrained;
            WinPercentage = winPercentage;
            YearsOfExperience = yearsOfExperince;
        }
    }
}
