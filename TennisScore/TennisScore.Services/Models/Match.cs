using System.Collections.Generic;
using TennisScore.Services;

namespace TennisScore
{
    public class Match
    {
        public int CountSets { get; set; }

        public List<Player> Players { get; set; }
    }
}