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
        public SetPlayer()
        {
            GamesPlayers = new List<GamePlayer>() { new GamePlayer() };
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
        /// Геймы
        /// </summary>
        [JsonProperty]
        public ICollection<GamePlayer> GamesPlayers { get; set; }
    }
}
