using System.Collections.Generic;
using System.Linq;

namespace TennisScore.Services
{
    public class Set
    {
        public Set()
        {
            Games = new List<Game>() { new Game() };
        }

        public int GamesWon
        {
            get
            {
                return Games.Where(x => x.Won == true).Count();
            }
        }

        public bool Won { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
