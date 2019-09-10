using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using TennisScore.Services.Enums;

namespace TennisScore.Services
{
    /// <summary>
    /// Игрок
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Player
    {
        #region Constructor
        public Player()
        {
            Sets = new List<SetPlayer>() { new SetPlayer(1) };
        }
        #endregion

        /// <summary>
        /// Тип игрока
        /// </summary>
        public PlayerType PlayerType { get; set; }

        /// <summary>
        /// Имя игрока
        /// </summary>
        [JsonProperty]
        public string Name { get; set; }

        /// <summary>
        /// Текущий счет игрока (геймы)
        /// </summary>
        public string Score
        {
            get 
            {
                return Sets.Last().GamesPlayers.Last().Score.ToString();
            }
        }

        /// <summary>
        /// Подает ли игрок? 
        /// </summary>
        public bool IsServe { get; set; }

        /// <summary>
        /// Сеты игрока
        /// </summary>
        [JsonProperty]
        public List<SetPlayer> Sets { get; private set; }
    }
}
