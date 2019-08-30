using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisScore.Services.Enums;

namespace TennisScore.Services
{
    public class TennisService
    {
        private event Action Changed;
        private bool _victory;
        private int _currenSet;
        TennisService(Action hanged)
        {
            Changed = hanged;
        }

        public bool Victory
        {
            get {
                return _victory;
            }
            private set {
                _victory = value;
                if (value)
                    Changed();
            }
        }

        private Match Match { get; set; }
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
                RollbackScore();

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
                RollbackScore();
                firstPlayer.Ad = false;
            }
            else
            {
                firstPlayer.Ad = true;
            }
        }
        private void RollbackScore()
        {
            foreach (var player in Players)
            {
                player.Score = 0;
                player.IsServe = !player.IsServe;
            }
        }
        public void AddScore(PlayerType player)
        {
            if (!Match.Tiebreak)
            {
                if (player == PlayerType.FirstPlayer)
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
            ++firstPlayer.SetsGame[_currenSet].GamesWon;
            if (firstPlayer.SetsGame[_currenSet].GamesWon < 6)
                return;
            else if (Math.Abs(firstPlayer.SetsGame[_currenSet].GamesWon - secondPlayer.SetsGame[_currenSet].GamesWon) > 1)
            {
                //выигрыш (сета) первого играка
                firstPlayer.SetsGame[_currenSet].Won = true;
                AddScoreSets(firstPlayer);
            }
            else if (secondPlayer.SetsGame[_currenSet].GamesWon == 6)
            {
                AddScoreTiebreak(firstPlayer, secondPlayer);
            }
        }
        private void AddScoreTiebreak(Player firstPlayer, Player secondPlayer)
        {
            ++firstPlayer.Score;
            if (firstPlayer.Score < 7)
                return;
            else if (Math.Abs(firstPlayer.Score - secondPlayer.Score) >= 2)
            {
                //выигрыш (сета)
                firstPlayer.SetsGame[_currenSet].Won = true;
                ++CurrenSet;
                AddScoreSets(firstPlayer);
                firstPlayer.Score = 0;
                secondPlayer.Score = 0;
            }
        }
        private void AddScoreSets(Player firstPlayer)
        {
            firstPlayer.SetsGame[_currenSet].Won = true;

            var k = (NSets < 5) ? 2 : 3;
            if (firstPlayer.SetsGame.Where(x => x.Won == true).Count() == k)
            {
                //выигрыш
                Victory = true;
                return;
            }
            ++CurrenSet;
        }
    }
}
