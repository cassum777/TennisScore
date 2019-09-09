using System.Collections.Generic;
using System.Linq;
using TennisScore.Services.Enums;

namespace TennisScore.Services
{
    public class Player
    {
        public Player()
        {
            Sets = new List<Set>() { new Set() };
        }

        public PlayerType PlayerType { get; set; }

        public string Name { get; set; }

        public string Score
        {
            get 
            {
                return Sets.Last().Games.Last().Score.ToString();
            }
        }

        public bool IsServe { get; set; }
        
        public List<Set> Sets { get; private set; }
    }
}
