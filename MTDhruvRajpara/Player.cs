using System;
using System.Collections.Generic;
using System.Text;

namespace MTDhruvRajpara
{
    class Player : Person
    {

        private int _matchesPlayed;

        public int MatchesPlayed
        {
            get { return _matchesPlayed; }
            set { _matchesPlayed = value; }

        }


        private int _won;

          public int Won
        {
            get { return _won; }
            set { _won = value; }
        }

        private int _lost;

        public int Lost
        {
            get { return _lost; }
            set { _lost = value; }
        }

        private int _goalsScored;

        public int GoalsScored
        {
            get { return _goalsScored; }
            set { _goalsScored = value; }
        }


        public Player(int id, String name, int matchesPlayed, int won, int lost, int goalsScored) : base(id , name)
        {
            MatchesPlayed = matchesPlayed;
            Won = won;
            Lost = lost;
            GoalsScored = goalsScored;
        }
    }
}
