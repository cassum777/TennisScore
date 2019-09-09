using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TennisScore.Services;
using TennisScore.Services.Enums;

namespace TennisScore
{
    public partial class fmMain : Form
    {
        #region Fields
        Match _match;
        IList<Player> _players;
        DateTime startTime;
        MatchService _matchService;
        #endregion

        #region Constructor
        public fmMain()
        {
            InitializeComponent();

            _match = new Match();
            new FmStart(_match).ShowDialog();

            _players = _match.SetPlayers;


            lblScorePlayer1.Text = "0";
            lblScorePlayer2.Text = "0";
            lblTime.Text = "00:00:00";

            lblNamePlayer1.Text = _players[0].Name;
            lblNamePlayer2.Text = _players[1].Name;

            pbBallPlayer1.Visible = _players[0].IsServe;
            pbBallPlayer2.Visible = _players[1].IsServe;

            //добавляем игроков в таблицу и оставляем нужное кол-во сетов
            dgSummMatch.RowCount = 2;
            dgSummMatch.Rows[0].Cells[0].Value = _players[0].Name;
            dgSummMatch.Rows[1].Cells[0].Value = _players[1].Name;
            dgSummMatch.ColumnCount = _match.CountSets + 1;

            startTime = DateTime.Now;
            tMatchDuration.Enabled = true;

            _matchService = new MatchService(_match, Victory);
        }
        #endregion


        private void TMatchDuration_Tick(object sender, EventArgs e)
        {
            var tick = DateTime.Now.Subtract(startTime);
            lblTime.Text = tick.ToString(@"h\:mm\:ss");
        }

        /// <summary>
        /// Событие, остановки или продолжения отсчета таймера
        /// </summary>
        private void BtnStopTimer_Click(object sender, EventArgs e)
        {
            tMatchDuration.Enabled = !tMatchDuration.Enabled;
        }


        /// <summary>
        /// Событие, выигрыша подачи первым игроком
        /// </summary>
        private void BtnPlayer1_Click(object sender, EventArgs e)
        {
            _matchService.AddScore(PlayerType.FirstPlayer);
            UpdateMatchStatistics();
        }


        /// <summary>
        /// Событие, выигрыша подачи вторым игроком
        /// </summary>
        private void BtnPlayer2_Click(object sender, EventArgs e)
        {
            _matchService.AddScore(PlayerType.SecondPlayer);
            UpdateMatchStatistics();

        }

        private void AlterDataPlayer_Click(object sender, EventArgs e)
        {
            UpdateMatchStatistics();
        }

        /// <summary>
        /// Событие закрытия формы
        /// </summary>
        private void FmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// Событие победы
        /// </summary>
        private void Victory()
        {
            MessageBox.Show("Игра закончена!");
            tMatchDuration.Enabled = false;
        }

        /// <summary>
        /// Обновления таблицы счета
        /// </summary>
        private void UpdateMatchStatistics()
        {
            lblScorePlayer1.Text = _players[0].Score;
            lblScorePlayer2.Text = _players[1].Score;
            pbBallPlayer1.Visible = _players[0].IsServe;
            pbBallPlayer2.Visible = _players[1].IsServe;

            for(var i = 0; i < _players.Count; i++)
            {
                for(var j = 0; j < _players[i].Sets.Count; j++)
                {
                    if (!_players[i].Sets[j].GamesPlayers.Last().TieBreak)
                        dgSummMatch.Rows[i].Cells[j+1].Value = _players[i].Sets[j].Score.ToString();
                    else
                    {
                        dgSummMatch.Rows[i].Cells[j + 1].Value = string.Format("{0} ( {1} )", _players[i].Sets[j].Score, _players[i].Sets[j].GamesPlayers.Last().Score);
                    }
                }
            }
        }
    }
}
