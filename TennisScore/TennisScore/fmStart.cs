using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TennisScore.Services;
using TennisScore.Services.Enums;

namespace TennisScore
{
    public partial class FmStart : Form
    {
        Match _match;
        public FmStart(Match match)
        {
            InitializeComponent();
            _match = match;
            rbPlayer1.Checked = true;
            rbPlayer1.Text = string.Empty;
            rbPlayer2.Text = string.Empty;
            rbColSet3.Checked = true;
            ChangeData();
        }

        private void ChangeData() 
        {
            btnStartGame.Enabled = (tbNameFirsPlayer.Text != String.Empty) && (tbNameSecondPlayer.Text != String.Empty);         
        }

        private void TbNameFirsPlayer_TextChanged(object sender, EventArgs e)
        {
            rbPlayer1.Text = tbNameFirsPlayer.Text;
            ChangeData();
        }

        private void TbNameSecondPlayer_TextChanged(object sender, EventArgs e)
        {
            rbPlayer2.Text = tbNameSecondPlayer.Text;
            ChangeData();
        }


        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            _match.NSets = rbColSet3.Checked ? 3 : 5;
            _match.Players = new Player[]
            {
                new Player(){ Name = tbNameFirsPlayer.Text, PlayerType = PlayerType.FirstPlayer, IsServe = rbPlayer1.Checked },
                new Player(){ Name = tbNameSecondPlayer.Text, PlayerType = PlayerType.SecondPlayer, IsServe = rbPlayer2.Checked }
            };
            this.Close();
        }
    }
}
