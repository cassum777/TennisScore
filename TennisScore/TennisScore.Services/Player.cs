using System.Collections.Generic;
using System.Linq;
using TennisScore.Services.Enums;

namespace TennisScore.Services
{
    public class Player
    {
        public Player()
        {
            SetsGame = new List<SetGame>() { new SetGame(1) };
        }

        public PlayerType PlayerType { get; set; }

        public string Name { get; set; }

        public string ScoreString
        {
            get 
            {
                return Ad ? "Ad" : Score.ToString();
            }
        }
        public int Score { get; set; }

        public bool Ad { get; set; }

        public bool IsServe { get; set; }

        public List<SetGame> SetsGame { get; private set; }

    }
}
