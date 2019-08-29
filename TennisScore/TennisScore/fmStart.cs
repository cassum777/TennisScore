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
            ChangeData();
        }

        private void ChangeData() 
        {
            btnStartGame.Enabled = (tbNameFirsPlayer.Text != String.Empty) && (tbNameSecondPlayer.Text != String.Empty);         
        }

        private void tbNameFirsPlayer_TextChanged(object sender, EventArgs e)
        {
            rbPlayer1.Text = tbNameFirsPlayer.Text;
            ChangeData();
        }

        private void tbNameSecondPlayer_TextChanged(object sender, EventArgs e)
        {
            rbPlayer2.Text = tbNameSecondPlayer.Text;
            ChangeData();
        }


        private void btnStartGame_Click(object sender, EventArgs e)
        {
            //var nSet = 3;
            //if (rbColSet5.Checked)
            //    nSet = 5;
            var nSet = rbColSet3.Checked ? 3 : 5;

            var players = new Player[]
            {
                new Player(){ Name = tbNameFirsPlayer.Text, PlayerType = PlayerType.FirstPlayer, IsServe = rbPlayer1.Checked },
                new Player(){ Name = tbNameSecondPlayer.Text, PlayerType = PlayerType.SecondPlayer, IsServe = rbPlayer2.Checked }
            };
            var match = new Match(players, nSet);
            var fmMain = new fmMain(match);
            fmMain.ShowDialog();
            this.Close();
        }
    }
}
