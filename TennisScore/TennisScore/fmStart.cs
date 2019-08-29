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
    public partial class fmStart : Form
    {
        public fmStart()
        {
            InitializeComponent();
            rbPlayer1.Checked = true;
            rbPlayer1.Text = string.Empty;
            rbPlayer2.Text = string.Empty;
            rbColSet3.Checked = true;
        }

        private void tbNameFirsPlayer_TextChanged(object sender, EventArgs e)
        {
            rbPlayer1.Text = tbNameFirsPlayer.Text;
        }

        private void tbNameSecondPlayer_TextChanged(object sender, EventArgs e)
        {
            rbPlayer2.Text = tbNameSecondPlayer.Text;
        }


        private void btnStartGame_Click(object sender, EventArgs e)
        {
            var nSet = 3;
            if (rbColSet5.Checked)
                nSet = 5;

            var players = new Player[]
            {
                new Player(){ Name = rbPlayer1.Text, PlayerType = PlayerType.FirstPlayer },
                new Player(){ Name = rbPlayer2.Text, PlayerType = PlayerType.SecondPlayer }
            };
            var match = new Match(players, nSet);
            var fmMain = new fmMain(match);
            fmMain.ShowDialog();
            this.Close();
        }
    }
}
