using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace TennisScore.Services
{
    /// <summary>
    /// Сет
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class SetPlayer
    {
        public SetPlayer(int indexNumber)
        {
            IndexNumber = indexNumber;
            GamesPlayers = new List<GamePlayer>() { new GamePlayer(1) };
        }

        /// <summary>
        /// Количество выигранных сетов игроком
        /// </summary>
        public int Score
        {
            get
            {
                return GamesPlayers.Where(x => x.Won == true).Count();
            }
        }
        /// <summary>
        /// Победа игрока?
        /// </summary>
        [JsonProperty]
        public bool Won { get; set; }

        /// <summary>
        /// Порядковый номер сета
        /// </summary>
        [JsonProperty]
        public int IndexNumber { get; set; }

        /// <summary>
        /// Геймы
        /// </summary>
        [JsonProperty]
        public ICollection<GamePlayer> GamesPlayers { get; set; }
    }
}
