using System.Collections.Generic;
using System.Linq;

namespace TennisScore.Services
{
    /// <summary>
    /// Сет
    /// </summary>
    public class SetPlayer
    {
        public SetPlayer()
        {
            Games = new List<GamePlayer>() { new GamePlayer() };
        }

        /// <summary>
        /// Количество выигранных сетов игроком
        /// </summary>
        public int Score
        {
            get
            {
                return Games.Where(x => x.Won == true).Count();
            }
        }
        /// <summary>
        /// Победа игрока?
        /// </summary>
        public bool Won { get; set; }

        /// <summary>
        /// Геймы
        /// </summary>
        public ICollection<GamePlayer> Games { get; set; }
    }
}
