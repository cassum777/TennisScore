using System.Collections.Generic;
using TennisScore.Services;

namespace TennisScore
{
    /// <summary>
    /// Матч
    /// </summary>
    public class Match
    {
        /// <summary>
        /// Количество сетов в матче
        /// </summary>
        public int CountSets { get; set; }

        /// <summary>
        /// Игроки матча
        /// </summary>
        public List<Player> Players { get; set; }
    }
}