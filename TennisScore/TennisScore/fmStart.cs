using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TennisScore.Services;
using TennisScore.Services.Enums;

namespace TennisScore
{
    public partial class FmStart : Form
    {
        #region Fields
        Match _match;
        #endregion

        #region Constructor
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
        #endregion

        /// <summary>
        /// Событие, при вводе букв имени первого игрока
        /// </summary>
        private void TbNameFirsPlayer_TextChanged(object sender, EventArgs e)
        {
            rbPlayer1.Text = tbNameFirsPlayer.Text;
            ChangeData();
        }

        /// <summary>
        /// Событие, при вводе букв имени второго игрока
        /// </summary>
        private void TbNameSecondPlayer_TextChanged(object sender, EventArgs e)
        {
            rbPlayer2.Text = tbNameSecondPlayer.Text;
            ChangeData();
        }

        /// <summary>
        /// Блокировка начала игры, при отсуствии заполненных имен игроков
        /// </summary>
        private void ChangeData()
        {
            btnStartGame.Enabled = (tbNameFirsPlayer.Text != string.Empty) && (tbNameSecondPlayer.Text != string.Empty);
        }

        /// <summary>
        /// Событие сохранения данных о матче и игроках
        /// </summary>
        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            _match.CountSets = rbColSet3.Checked ? 3 : 5; ;
            _match.Players = new List<Player>()
            {
                new Player(){ Name = tbNameFirsPlayer.Text, PlayerType = PlayerType.FirstPlayer, IsServe = rbPlayer1.Checked },
                new Player(){ Name = tbNameSecondPlayer.Text, PlayerType = PlayerType.SecondPlayer, IsServe = rbPlayer2.Checked }
            };
            this.Close();
        }
    }
}
