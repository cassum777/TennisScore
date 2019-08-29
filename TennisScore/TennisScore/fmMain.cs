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

        private fmMain() => 
            InitializeComponent();

        public fmMain(Match match) : this()
        {
            _match = match;
            _players = _match.Players;
            lblScorePlayer1.Text = "0";
            lblScorePlayer2.Text = "0";

            lblNamePlayer1.Text = match.Players[0].Name;
            lblNamePlayer2.Text = match.Players[1].Name;
        }

        private void tMatchDuration_Tick(object sender, EventArgs e)
        {
  
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {

        }



        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            _match.AddScore(PlayerType.FirstPlayer);
            lblScorePlayer1.Text = _players[0].ScoreString;
            lblScorePlayer2.Text = _players[1].ScoreString;
        }



        private void btnPlayer2_Click(object sender, EventArgs e)
        {
            _match.AddScore(PlayerType.SecondPlayer);
            lblScorePlayer1.Text = _players[0].ScoreString;
            lblScorePlayer2.Text = _players[1].ScoreString;
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
