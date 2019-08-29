namespace TennisScore
{
    partial class FmStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNamePlayer1 = new System.Windows.Forms.Label();
            this.tbNameFirsPlayer = new System.Windows.Forms.TextBox();
            this.tbNameSecondPlayer = new System.Windows.Forms.TextBox();
            this.lblNamePlayer2 = new System.Windows.Forms.Label();
            this.gbServe = new System.Windows.Forms.GroupBox();
            this.rbPlayer1 = new System.Windows.Forms.RadioButton();
            this.rbPlayer2 = new System.Windows.Forms.RadioButton();
            this.gbColSets = new System.Windows.Forms.GroupBox();
            this.rbColSet5 = new System.Windows.Forms.RadioButton();
            this.rbColSet3 = new System.Windows.Forms.RadioButton();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.gbServe.SuspendLayout();
            this.gbColSets.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNamePlayer1
            // 
            this.lblNamePlayer1.AutoSize = true;
            this.lblNamePlayer1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNamePlayer1.Location = new System.Drawing.Point(29, 41);
            this.lblNamePlayer1.Name = "lblNamePlayer1";
            this.lblNamePlayer1.Size = new System.Drawing.Size(146, 15);
            this.lblNamePlayer1.TabIndex = 0;
            this.lblNamePlayer1.Text = "Фамилия, имя 1 игрока:";
            // 
            // tbNameFirsPlayer
            // 
            this.tbNameFirsPlayer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameFirsPlayer.Location = new System.Drawing.Point(180, 34);
            this.tbNameFirsPlayer.Multiline = true;
            this.tbNameFirsPlayer.Name = "tbNameFirsPlayer";
            this.tbNameFirsPlayer.Size = new System.Drawing.Size(361, 30);
            this.tbNameFirsPlayer.TabIndex = 1;
            this.tbNameFirsPlayer.TextChanged += new System.EventHandler(this.TbNameFirsPlayer_TextChanged);
            // 
            // tbNameSecondPlayer
            // 
            this.tbNameSecondPlayer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameSecondPlayer.Location = new System.Drawing.Point(180, 71);
            this.tbNameSecondPlayer.Multiline = true;
            this.tbNameSecondPlayer.Name = "tbNameSecondPlayer";
            this.tbNameSecondPlayer.Size = new System.Drawing.Size(361, 30);
            this.tbNameSecondPlayer.TabIndex = 3;
            this.tbNameSecondPlayer.TextChanged += new System.EventHandler(this.TbNameSecondPlayer_TextChanged);
            // 
            // lblNamePlayer2
            // 
            this.lblNamePlayer2.AutoSize = true;
            this.lblNamePlayer2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNamePlayer2.Location = new System.Drawing.Point(28, 78);
            this.lblNamePlayer2.Name = "lblNamePlayer2";
            this.lblNamePlayer2.Size = new System.Drawing.Size(146, 15);
            this.lblNamePlayer2.TabIndex = 2;
            this.lblNamePlayer2.Text = "Фамилия, имя 2 игрока:";
            // 
            // gbServe
            // 
            this.gbServe.Controls.Add(this.rbPlayer2);
            this.gbServe.Controls.Add(this.rbPlayer1);
            this.gbServe.Location = new System.Drawing.Point(31, 107);
            this.gbServe.Name = "gbServe";
            this.gbServe.Size = new System.Drawing.Size(496, 78);
            this.gbServe.TabIndex = 4;
            this.gbServe.TabStop = false;
            this.gbServe.Text = "Первым подает:";
            // 
            // rbPlayer1
            // 
            this.rbPlayer1.AutoSize = true;
            this.rbPlayer1.Location = new System.Drawing.Point(20, 25);
            this.rbPlayer1.Name = "rbPlayer1";
            this.rbPlayer1.Size = new System.Drawing.Size(69, 17);
            this.rbPlayer1.TabIndex = 0;
            this.rbPlayer1.TabStop = true;
            this.rbPlayer1.Text = "rbPlayer1";
            this.rbPlayer1.UseVisualStyleBackColor = true;
            // 
            // rbPlayer2
            // 
            this.rbPlayer2.AutoSize = true;
            this.rbPlayer2.Location = new System.Drawing.Point(20, 55);
            this.rbPlayer2.Name = "rbPlayer2";
            this.rbPlayer2.Size = new System.Drawing.Size(69, 17);
            this.rbPlayer2.TabIndex = 1;
            this.rbPlayer2.TabStop = true;
            this.rbPlayer2.Text = "rbPlayer2";
            this.rbPlayer2.UseVisualStyleBackColor = true;
            // 
            // gbColSets
            // 
            this.gbColSets.Controls.Add(this.rbColSet5);
            this.gbColSets.Controls.Add(this.rbColSet3);
            this.gbColSets.Location = new System.Drawing.Point(31, 191);
            this.gbColSets.Name = "gbColSets";
            this.gbColSets.Size = new System.Drawing.Size(496, 53);
            this.gbColSets.TabIndex = 5;
            this.gbColSets.TabStop = false;
            this.gbColSets.Text = "Колличество сетов:";
            // 
            // rbColSet5
            // 
            this.rbColSet5.AutoSize = true;
            this.rbColSet5.Location = new System.Drawing.Point(376, 25);
            this.rbColSet5.Name = "rbColSet5";
            this.rbColSet5.Size = new System.Drawing.Size(31, 17);
            this.rbColSet5.TabIndex = 1;
            this.rbColSet5.TabStop = true;
            this.rbColSet5.Text = "5";
            this.rbColSet5.UseVisualStyleBackColor = true;
            // 
            // rbColSet3
            // 
            this.rbColSet3.AutoSize = true;
            this.rbColSet3.Location = new System.Drawing.Point(49, 25);
            this.rbColSet3.Name = "rbColSet3";
            this.rbColSet3.Size = new System.Drawing.Size(31, 17);
            this.rbColSet3.TabIndex = 0;
            this.rbColSet3.TabStop = true;
            this.rbColSet3.Text = "3";
            this.rbColSet3.UseVisualStyleBackColor = true;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStartGame.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartGame.Location = new System.Drawing.Point(31, 293);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(496, 53);
            this.btnStartGame.TabIndex = 6;
            this.btnStartGame.Text = "Начать игру";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // fmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 358);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.gbColSets);
            this.Controls.Add(this.gbServe);
            this.Controls.Add(this.tbNameSecondPlayer);
            this.Controls.Add(this.lblNamePlayer2);
            this.Controls.Add(this.tbNameFirsPlayer);
            this.Controls.Add(this.lblNamePlayer1);
            this.Name = "fmStart";
            this.Text = "Ввод данных по игрокам";
            this.gbServe.ResumeLayout(false);
            this.gbServe.PerformLayout();
            this.gbColSets.ResumeLayout(false);
            this.gbColSets.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamePlayer1;
        private System.Windows.Forms.TextBox tbNameFirsPlayer;
        private System.Windows.Forms.TextBox tbNameSecondPlayer;
        private System.Windows.Forms.Label lblNamePlayer2;
        private System.Windows.Forms.GroupBox gbServe;
        private System.Windows.Forms.RadioButton rbPlayer2;
        private System.Windows.Forms.RadioButton rbPlayer1;
        private System.Windows.Forms.GroupBox gbColSets;
        private System.Windows.Forms.RadioButton rbColSet5;
        private System.Windows.Forms.RadioButton rbColSet3;
        private System.Windows.Forms.Button btnStartGame;
    }
}