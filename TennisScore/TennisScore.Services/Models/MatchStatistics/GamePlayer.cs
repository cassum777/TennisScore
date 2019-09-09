namespace TennisScore.Services
{
    /// <summary>
    /// Гейм
    /// </summary>
    public class GamePlayer
    {
        /// <summary>
        /// Счет гейма
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Победа?
        /// </summary>
        public bool Won { get; set; }

        /// <summary>
        /// Этот гейм, является таймбрейком?
        /// </summary>
        public bool TieBreak { get; set; }

        /// <summary>
        /// Больше (счет, относительно другого игрока)?
        /// </summary>
        public bool Ad { get; set; }
    }
}
