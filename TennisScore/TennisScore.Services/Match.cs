using System;
using System.Linq;
using TennisScore.Services;
using TennisScore.Services.Enums;

namespace TennisScore
{
    public delegate void ChangedEventHandler();
    public class Match
    {
        #region Properties
        private bool _victory;
        private event Action Changed;
        private int _currenSet = 0;
        #endregion

        #region Constructors
        public Match(Action hanged)
        {
            Changed = hanged;
        }
        #endregion

        #region Properties
        public bool Tiebreak { get; set; }
        public Player[] Players { get; set; }

        public int CurrenSet
        {
            get {
                return _currenSet + 1;
            }
            set {
                _currenSet++;
                Players[0].SetsGame.Add(new SetGame(value));
                Players[1].SetsGame.Add(new SetGame(value));
            }
        }

        public bool Victory
        {
            get 
            {
                return _victory;
            }
            private set 
            {
                _victory = value;
                if(value)
                    Changed();
            }
        }

        public int NSets { get; set; }
        #endregion

        #region Metods
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
                //RollbackScore();

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
                //RollbackScore();
                firstPlayer.Ad = false;
            }
            else
            {
                firstPlayer.Ad = true;
            }
        }


        private void RollbackScore()
        {
            foreach(var player in Players)
            {
                player.Score = 0;
                player.IsServe = !player.IsServe;
                player.TieBreakScore = 0;
                player.SetsGame[_currenSet].TieBreakWon = -1;
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
            ++firstPlayer.SetsGame[_currenSet].GamesWon;
            if (firstPlayer.SetsGame[_currenSet].GamesWon < 6)
            {
                RollbackScore();
                return;
            }
            else if ((Math.Abs(firstPlayer.SetsGame[_currenSet].GamesWon - secondPlayer.SetsGame[_currenSet].GamesWon) > 1) || (firstPlayer.SetsGame[_currenSet].GamesWon == 7))
            {
                //выигрыш (сета) первого играка
                firstPlayer.SetsGame[_currenSet].Won = true;
                AddScoreSets(firstPlayer);
                RollbackScore();
            }
            else if (secondPlayer.SetsGame[_currenSet].GamesWon == 6)
            {
                AddScoreTiebreak(firstPlayer, secondPlayer);
            }
            else RollbackScore();
        }
        private void AddScoreTiebreak(Player firstPlayer, Player secondPlayer)
        {
            if (!Tiebreak) 
            {
                firstPlayer.Score = 0;
                secondPlayer.Score = 0;
                firstPlayer.SetsGame[_currenSet].TieBreakWon = 0;
                secondPlayer.SetsGame[_currenSet].TieBreakWon = 0;
                Tiebreak = true;
                return;
            }

            ++firstPlayer.TieBreakScore;
            firstPlayer.SetsGame[_currenSet].TieBreakWon = firstPlayer.TieBreakScore;
            //в tiebreak 1 подачу подает подающий до этого игрок, затем подают по 2 подачи каждый
            if ((firstPlayer.TieBreakScore + secondPlayer.TieBreakScore) % 2 == 1) //сумма не четная
            {
                firstPlayer.IsServe = !firstPlayer.IsServe;
                secondPlayer.IsServe = !secondPlayer.IsServe;
            }

            if (firstPlayer.TieBreakScore < 7)
                return;
            else if (Math.Abs(firstPlayer.TieBreakScore - secondPlayer.TieBreakScore) >= 2)
            {
                //выигрыш первого игрока
                AddNGame(firstPlayer, secondPlayer);
                Tiebreak = false;
            }
            //++firstPlayer.SetsGame[_currenSet].GamesWon;
            //if (firstPlayer.SetsGame[_currenSet].GamesWon < 7)
            //   return;
            //else if(Math.Abs(firstPlayer.SetsGame[_currenSet].GamesWon - secondPlayer.SetsGame[_currenSet].GamesWon) >= 2)
            //{
            //    //выигрыш (сета)
            //    firstPlayer.SetsGame[_currenSet].Won = true;
            //    ++CurrenSet;
            //    AddScoreSets(firstPlayer);
            //    firstPlayer.Score = 0;
            //    secondPlayer.Score = 0;
            //}
        }
        private void AddScoreSets(Player firstPlayer)
        {
            firstPlayer.SetsGame[_currenSet].Won = true;

            var k = (NSets < 5) ? 2 : 3; 
            if(firstPlayer.SetsGame.Where(x => x.Won == true).Count() == k)
            {
                //выигрыш
                Victory = true;
                return;
            }
            ++CurrenSet;
        }
        #endregion
    }
}