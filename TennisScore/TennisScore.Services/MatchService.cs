using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using System;
using System.Collections.Generic;
using System.Linq;
using TennisScore.Services.Enums;

namespace TennisScore.Services
{
    /// <summary>
    /// Сервис по подсчету статистики игры
    /// </summary>
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
            _players = match.SetPlayers;
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
                AddPointsToTheGame(_players[0], _players[1]);
            else
                AddPointsToTheGame(_players[1], _players[0]);
        }

        /// <summary>
        /// Добавить игроку очки гейма, за выигрыш подачи
        /// </summary>
        /// <param name="firstPlayer">Текущещий игрок</param>
        /// <param name="secondPlayer">Второй игрой</param>
        private void AddPointsToTheGame(Player firstPlayer, Player secondPlayer)
        {
            var gameFP = firstPlayer.Sets.Last().GamesPlayers.Last();
            var gameSP = secondPlayer.Sets.Last().GamesPlayers.Last();

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
                    FinishGame(firstPlayer, secondPlayer);
                }
                else if (gameSP.Ad)
                {
                    gameSP.Ad = false;
                }
                else if (gameFP.Ad)
                {
                    //выигрыш гейма первым игроком
                    FinishGame(firstPlayer, secondPlayer);
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
                else if (gameFP.Score >= 7 && Math.Abs(gameFP.Score - gameSP.Score) >= 2)
                {
                    //выигрыш первого игрока
                    FinishSet(firstPlayer);
                }
            }
        }

        /// <summary>
        /// Окончить гейм (наступает, если кто-то выигрывает гейм)
        /// </summary>
        /// <param name="firstPlayer"></param>
        /// <param name="secondPlayer"></param>
        private void FinishGame(Player firstPlayer, Player secondPlayer)
        {
            var setFP = firstPlayer.Sets.Last();
            var setSP = secondPlayer.Sets.Last();

            setFP.GamesPlayers.Last().Won = true;

            if (setFP.Score < 6)
            {
                //=> новые геймы

                CreateNewGame();
                return;
            }
            else if ((Math.Abs(setFP.Score - setSP.Score) > 1) || (setFP.Score == 7))
            {
                //выигрыш (сета) первого играка
                FinishSet(firstPlayer);
            }
            else if (setSP.Score == 6)
            {
                CreateNewGame(tiebreak: true);
            }
            else CreateNewGame();
        }

        /// <summary>
        /// Создать новый гейм
        /// </summary>
        /// <param name="tiebreak">Является ли новый гейм таймбрейком? (по умолчанию - ложь)</param>
        private void CreateNewGame(bool tiebreak = false)
        {
            foreach(var player in _players)
            {
                player.Sets.Last().GamesPlayers.Add(new GamePlayer() { TieBreak = tiebreak });
                player.IsServe = !player.IsServe;
            }
        }

        /// <summary>
        /// Окончить сет (наступает, если кто-то выигрывает гейм)
        /// </summary>
        /// <param name="winner">игрок, выигрвший сет</param>
        private void FinishSet(Player winner)
        {
            winner.Sets.Last().Won = true;

            var needSetsToWin = (_match.CountSets < 5) ? 2 : 3;
            //проверка условия, окончания матча
            if (winner.Sets.Where(x => x.Won == true).Count() >= needSetsToWin)
            {
                //запуск события окончания матча
                _hanged();

                var jsonRepository = new JsonMatchRepository();
                jsonRepository.SaveMatch(_match);
            }
            else
            {
                _players.ForEach(x => x.Sets.Add(new SetPlayer()));
            }
        }
    }
}
