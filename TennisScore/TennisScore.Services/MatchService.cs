using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisScore.Services.Enums;

namespace TennisScore.Services
{
    public class MatchService
    {
        #region Fields
        private readonly List<Player> _players;
        private readonly Match _match;
        private readonly Action _hanged;
        #endregion

        #region Constructor
        public MatchService(Match match, Action hanged)
        {
            _match = match;
            _players = match.Players;
            _hanged = hanged;
        }
        #endregion

        /// <summary>
        /// Добавить игроку очки гейма, за выигрыш подачи
        /// </summary>
        /// <param name="player">Игрок выигрывший подачу</param>
        public void AddScore(PlayerType player)
        {
            if (player == PlayerType.FirstPlayer)
                AddScore(_players[0], _players[1]);
            else
                AddScore(_players[1], _players[0]);
        }

        /// <summary>
        /// Добавить игроку очки гейма, за выигрыш подачи
        /// </summary>
        /// <param name="firstPlayer">Текущещий игрок</param>
        /// <param name="secondPlayer">Второй игрой</param>
        private void AddScore(Player firstPlayer, Player secondPlayer)
        {
            var gameFP = firstPlayer.Sets.Last().Games.Last();
            var gameSP = secondPlayer.Sets.Last().Games.Last();

            if (!gameFP.TieBreak)
            {
                switch (gameFP.Score)
                {
                    case 0:
                        gameFP.Score = 15;
                        return;
                    case 15:
                        gameFP.Score = 30;
                        return;
                    case 30:
                        gameFP.Score = 40;
                        return;
                }
                //текущее значение Score == 40;

                if (gameSP.Score != 40)
                {
                    //выигрыш гейма первым игроком
                    WonGame(firstPlayer, secondPlayer);
                }
                else if (gameSP.Ad)
                {
                    gameSP.Ad = false;
                }
                else if (gameFP.Ad)
                {
                    //выигрыш гейма первым игроком
                    WonGame(firstPlayer, secondPlayer);
                }
                else
                {
                    gameFP.Ad = true;
                }
            }
            else
            {
                ++gameFP.Score;
                //в tiebreak 1 подачу подает подающий до этого игрок, затем подают по 2 подачи каждый
                if ((gameFP.Score + gameSP.Score) % 2 == 1)
                {
                    firstPlayer.IsServe = !firstPlayer.IsServe;
                    secondPlayer.IsServe = !secondPlayer.IsServe;
                }
                if(gameFP.Score < 7)
                {
                    return;
                }
                else if (Math.Abs(gameFP.Score - gameSP.Score) >= 2)
                {
                    //выигрыш первого игрока
                    WonSet(firstPlayer);
                }
            }
        }

        private void WonGame(Player firstPlayer, Player secondPlayer)
        {
            var setFP = firstPlayer.Sets.Last();
            var setSP = secondPlayer.Sets.Last();

            setFP.Games.Last().Won = true;

            if (setFP.GamesWon < 6)
            {
                //=> новые геймы

                UpdateServe();
                return;
            }
            else if ((Math.Abs(setFP.GamesWon - setSP.GamesWon) > 1) || (setFP.GamesWon == 7))
            {
                //выигрыш (сета) первого играка
                WonSet(firstPlayer);
            }
            else if (setSP.GamesWon == 6)
            {
                UpdateServe(tiebreak: true);
            }
            else UpdateServe();
        }
        private void UpdateServe(bool tiebreak = false)
        {
            foreach(var player in _players)
            {
                player.Sets.Last().Games.Add(new Game() { TieBreak = tiebreak });
                player.IsServe = !player.IsServe;
            }
        }

        private void WonSet(Player firstPlayer)
        {
            firstPlayer.Sets.Last().Won = true;

            var k = (_match.CountSets < 5) ? 2 : 3;
            if (firstPlayer.Sets.Where(x => x.Won == true).Count() == k)
            {
                //выигрыш
                _hanged();
            }
            else
            {
                _players.ForEach(x => x.Sets.Add(new Set()));
            }
        }
    }
}
