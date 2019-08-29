using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TennisScore.Services;
using TennisScore.Services.Enums;

namespace TennisScore
{
    public partial class fmMain : Form
    {
        Match _match;
        Player[] _players;
        DateTime startTime;

        private fmMain()
        {
            InitializeComponent();
        }

        public fmMain(Match match) : this()
        {
            _match = match;
            _players = _match.Players;
            lblScorePlayer1.Text = "0";
            lblScorePlayer2.Text = "0";
            lblTime.Text = "00:00:00";

            lblNamePlayer1.Text = match.Players[0].Name;
            lblNamePlayer2.Text = match.Players[1].Name;

            pbBallPlayer1.Visible = match.Players[0].IsServe;
            pbBallPlayer2.Visible = match.Players[1].IsServe;

            //добавляем игроков в таблицу и оставляем нужное кол-во сетов
            dgSummMatch.RowCount = 2;
            dgSummMatch.Rows[0].Cells[0].Value = match.Players[0].Name;
            dgSummMatch.Rows[1].Cells[0].Value = match.Players[1].Name;
            dgSummMatch.ColumnCount = match.NSets + 1;

            startTime = DateTime.Now;
            tMatchDuration.Enabled = true;
        }

        private void tMatchDuration_Tick(object sender, EventArgs e)
        {
            TimeSpan tick = new TimeSpan();
            tick = DateTime.Now.Subtract(startTime);
            lblTime.Text = String.Format("{0}:{1}:{2}", tick.Hours.ToString().PadLeft(2, '0'), tick.Minutes.ToString().PadLeft(2, '0'), tick.Seconds.ToString().PadLeft(2, '0'));
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            //остановка/запуск таймера
            tMatchDuration.Enabled = !tMatchDuration.Enabled;
        }



        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            _match.AddScore(PlayerType.FirstPlayer);
            lblScorePlayer1.Text = _players[0].ScoreString;
            lblScorePlayer2.Text = _players[1].ScoreString;
            pbBallPlayer1.Visible = _players[0].IsServe;
            pbBallPlayer2.Visible = _players[1].IsServe;
        }



        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            _match.AddScore(PlayerType.SecondPlayer);
            lblScorePlayer1.Text = _players[0].ScoreString;
            lblScorePlayer2.Text = _players[1].ScoreString;
            pbBallPlayer1.Visible = _players[0].IsServe;
            pbBallPlayer2.Visible = _players[1].IsServe;
        }

        private void alterDataPlayer_Click(object sender, EventArgs e)
        {

        }

        private void FmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Dispose();
        }
    }
}
