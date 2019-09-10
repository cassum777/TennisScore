using Newtonsoft.Json;

namespace TennisScore.Services.Models.MatchStatistics
{
    /// <summary>
    /// Подача
    /// </summary>
    public class ServePlayer
    {
        /// <summary>
        /// Порядковый номер подачи
        /// </summary>
        public int IndexNumber { get; set; }

        /// <summary>
        /// Подает ли игрок?
        /// </summary>
        public bool IsServe { get; set; }

        /// <summary>
        /// Выиграл?
        /// </summary>
        public bool Won { get; set; }

        /// <summary>
        /// Ошибки при подаче
        /// </summary>
        public int Fall { get; set; }

        /// <summary>
        /// Подача на вылет (+очко подающему игроку)
        /// </summary>
        public bool Ace { get; set; }

        /// <summary>
        /// Количество заработанных очков
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// Больше (счет, относительно другого игрока)?
        /// </summary>
        public bool Ad { get; set; }
    }
}
