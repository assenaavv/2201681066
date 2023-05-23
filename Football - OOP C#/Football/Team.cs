using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal class Team
    {
        private Coach coach;
        private List<FootballPlayer> players;

        public Coach Coach
        {
            get { return coach; }
            private set { coach = value; }
        }

        public List<FootballPlayer> Players
        {
            get { return players; }
            private set { players = value; }
        }

        
    }
}
