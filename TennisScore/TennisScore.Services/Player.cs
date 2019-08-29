using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisScore.Services.Enums;

namespace TennisScore.Services
{
    public class Player
    {
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

        public int GamesWon { get; set; }

        public int SetWon { get; set; }

        public bool IsServe { get; set; }

    }
}
