namespace TennisScore.Services
{
    public class SetGame
    {
        public SetGame(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }

        public int GamesWon { get; set; }

        public int TieBreakWon { get; set; }

        public bool Won { get; set; }
    }
}
