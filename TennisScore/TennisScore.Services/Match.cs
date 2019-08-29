using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisScore.Services;
using TennisScore.Services.Enums;

namespace TennisScore
{
    public class Match
    {
        public bool TimeBreak { get; set; }
        public Player[] Players { get; private set; }
        public Match(Player[] players, int nset)
        {
            Players = players;
            NSets = nset;
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
            if (!TimeBreak)
            {
                if(player == PlayerType.FirstPlayer)
                    AddScore(Players[0], Players[1]);
                else
                    AddScore(Players[1], Players[0]);
            }
            else
            {
                if (player == PlayerType.FirstPlayer)
                    AddScopeTimeBreak(Players[0], Players[1]);
                else
                    AddScopeTimeBreak(Players[1], Players[0]);
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
                firstPlayer.GamesWon = 0;
                secondPlayer.GamesWon = 0;
            }
            else if(secondPlayer.GamesWon == 6)
            {
                
            }
        }
        public void AddScopeTimeBreak(Player firstPlayer, Player secondPlayer)
        {
            ++firstPlayer.Score;
            if (firstPlayer.Score < 7)
                return;
            else if(Math.Abs(firstPlayer.Score - secondPlayer.Score) >= 2)
            {
                //выигрыш (сета)
                firstPlayer.Score = 0;
                secondPlayer.Score = 0;
            }
        }
    }
}