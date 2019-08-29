using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisScore.Services;
using TennisScore.Services.Enums;

namespace TennisScore
{
    public delegate void ChangedEventHandler();
    public class Match
    {
        public Match(Action hanged)
        {
            _changed = hanged;
        }
        private bool _victory;
        private event Action _changed;
        public bool Tiebreak { get; set; }
        public Player[] Players { get; set; }

        public bool Victory
        {
            get 
            {
                return _victory;
            }
            set 
            {
                _victory = value;
                if(value)
                    _changed();
            }
        }

        public int NSets { get; set; }

        private void AddScore(Player firstPlayer, Player secondPlayer)
        {
            switch (firstPlayer.Score)
            {
                case 0:
                    firstPlayer.Score = 15;
                    return;
                case 15:
                    firstPlayer.Score = 30;
                    return;
                case 30:
                    firstPlayer.Score = 40;
                    return;
            }
            //текущее значение firstPlayer.Score = 40;

            if (secondPlayer.Score != 40)
            {
                //выигрыш первого игрока
                AddNGame(firstPlayer, secondPlayer);
                firstPlayer.Score = 0;
                secondPlayer.Score = 0;
                firstPlayer.IsServe = !firstPlayer.IsServe;
                secondPlayer.IsServe = !secondPlayer.IsServe;
            }
            else if (secondPlayer.Ad)
            {
                firstPlayer.Score = 40;
                secondPlayer.Score = 40;
                secondPlayer.Ad = false;
            }
            else if (firstPlayer.Ad)
            {
                //выигрыш первого игрока
                AddNGame(firstPlayer, secondPlayer);
                firstPlayer.Score = 0;
                secondPlayer.Score = 0;
                firstPlayer.Ad = false;
                firstPlayer.IsServe = !firstPlayer.IsServe;
                secondPlayer.IsServe = !secondPlayer.IsServe;
            }
            else
            {
                firstPlayer.Ad = true;
            }
        }
        public void AddScore(PlayerType player)
        {
            if (!Tiebreak)
            {
                if(player == PlayerType.FirstPlayer)
                    AddScore(Players[0], Players[1]);
                else
                    AddScore(Players[1], Players[0]);
            }
            else
            {
                if (player == PlayerType.FirstPlayer)
                    AddScoreTiebreak(Players[0], Players[1]);
                else
                    AddScoreTiebreak(Players[1], Players[0]);
            }
        }

        private void AddNGame(Player firstPlayer, Player secondPlayer)
        {
            ++firstPlayer.GamesWon;
            if(firstPlayer.GamesWon < 6)
                return;
            else if(Math.Abs(firstPlayer.GamesWon - secondPlayer.GamesWon) > 1)
            {
                //выигрыш (сета) первого играка
                AddScoreSets(firstPlayer);
                firstPlayer.GamesWon = 0;
                secondPlayer.GamesWon = 0;
            }
            else if(secondPlayer.GamesWon == 6)
            {
                AddScoreTiebreak(firstPlayer, secondPlayer);
            }
        }
        private void AddScoreTiebreak(Player firstPlayer, Player secondPlayer)
        {
            ++firstPlayer.Score;
            if (firstPlayer.Score < 7)
                return;
            else if(Math.Abs(firstPlayer.Score - secondPlayer.Score) >= 2)
            {
                //выигрыш (сета)
                AddScoreSets(firstPlayer);
                firstPlayer.Score = 0;
                secondPlayer.Score = 0;
            }
        }
        private void AddScoreSets(Player firstPlayer)
        {
            ++firstPlayer.SetsWon;
            var k = (NSets < 5) ? 2 : 3; 
            if(firstPlayer.SetsWon == k)
            {
                //выигрыш
                Victory = true;
            }
        }
    }
}