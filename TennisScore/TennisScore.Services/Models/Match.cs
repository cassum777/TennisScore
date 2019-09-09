using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TennisScore.Services;

namespace TennisScore
{
    /// <summary>
    /// Матч
    /// </summary>
    public class Match
    {
        public Match()
        {
            TimeStarting = DateTime.Now;
        }

        /// <summary>
        /// Количество сетов в матче
        /// </summary>
        public int CountSets { get; set; }

        /// <summary>
        /// Время начала матча
        /// </summary>
        public DateTime TimeStarting { get; set; }

        /// <summary>
        /// Игроки матча
        /// </summary>
        public List<Player> SetPlayers { get; set; }
    }
}