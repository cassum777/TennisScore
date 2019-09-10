using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using TennisScore.Services.Models.MatchStatistics;

namespace TennisScore.Services
{
    /// <summary>
    /// Гейм
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GamePlayer
    {
        public GamePlayer(int indexNumber)
        {
            IndexNumber = indexNumber;
        }

        /// <summary>
        /// Счет гейма
        /// </summary>
        [JsonProperty]
        public int Score { get; set; }

        /// <summary>
        /// Победа?
        /// </summary>
        [JsonProperty]
        public bool Won { get; set; }

        /// <summary>
        /// Этот гейм, является таймбрейком?
        /// </summary>
        [JsonProperty]
        public bool TieBreak { get; set; }

        /// <summary>
        /// Порядковый номер сета
        /// </summary>
        [JsonProperty]
        public int IndexNumber { get; set; }

        /// <summary>
        /// Больше (счет, относительно другого игрока)?
        /// </summary>
        public bool Ad { get; set; }
    }
}
