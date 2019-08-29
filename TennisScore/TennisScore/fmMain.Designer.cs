namespace TennisScore
{
    partial class fmMain
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
            this.components = new System.ComponentModel.Container();
            this.pnlPlayers = new System.Windows.Forms.Panel();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.pbBallPlayer2 = new System.Windows.Forms.PictureBox();
            this.lblNamePlayer2 = new System.Windows.Forms.Label();
            this.pnlPlayers1 = new System.Windows.Forms.Panel();
            this.pbBallPlayer1 = new System.Windows.Forms.PictureBox();
            this.lblNamePlayer1 = new System.Windows.Forms.Label();
            this.pnlScores = new System.Windows.Forms.Panel();
            this.pnlScorePlayer2 = new System.Windows.Forms.Panel();
            this.lblScorePlayer2 = new System.Windows.Forms.Label();
            this.pnlScorePlayer1 = new System.Windows.Forms.Panel();
            this.lblScorePlayer1 = new System.Windows.Forms.Label();
            this.pnlButtnons = new System.Windows.Forms.Panel();
            this.pnlButtonPlayer2 = new System.Windows.Forms.Panel();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.pnlButtonPlayer1 = new System.Windows.Forms.Panel();
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.pnlUndo = new System.Windows.Forms.Panel();
            this.btnUndo = new System.Windows.Forms.Button();
            this.panelMatchSum = new System.Windows.Forms.Panel();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblNameTime = new System.Windows.Forms.Label();
            this.dgSummMatch = new System.Windows.Forms.DataGridView();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLableSum = new System.Windows.Forms.Panel();
            this.lblSummMatch = new System.Windows.Forms.Label();
            this.tMatchDuration = new System.Windows.Forms.Timer(this.components);
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.alterDataPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPlayers.SuspendLayout();
            this.pnlPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBallPlayer2)).BeginInit();
            this.pnlPlayers1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBallPlayer1)).BeginInit();
            this.pnlScores.SuspendLayout();
            this.pnlScorePlayer2.SuspendLayout();
            this.pnlScorePlayer1.SuspendLayout();
            this.pnlButtnons.SuspendLayout();
            this.pnlButtonPlayer2.SuspendLayout();
            this.pnlButtonPlayer1.SuspendLayout();
            this.pnlUndo.SuspendLayout();
            this.panelMatchSum.SuspendLayout();
            this.pnlTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSummMatch)).BeginInit();
            this.pnlLableSum.SuspendLayout();
            this.mMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayers.Controls.Add(this.pnlPlayer2);
            this.pnlPlayers.Controls.Add(this.pnlPlayers1);
            this.pnlPlayers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPlayers.Location = new System.Drawing.Point(0, 24);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(882, 72);
            this.pnlPlayers.TabIndex = 0;
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.Controls.Add(this.pbBallPlayer2);
            this.pnlPlayer2.Controls.Add(this.lblNamePlayer2);
            this.pnlPlayer2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPlayer2.Location = new System.Drawing.Point(480, 0);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(400, 70);
            this.pnlPlayer2.TabIndex = 1;
            // 
            // pbBallPlayer2
            // 
            this.pbBallPlayer2.Image = global::TennisScore.Properties.Resources.ball;
            this.pbBallPlayer2.InitialImage = null;
            this.pbBallPlayer2.Location = new System.Drawing.Point(0, 20);
            this.pbBallPlayer2.Name = "pbBallPlayer2";
            this.pbBallPlayer2.Size = new System.Drawing.Size(32, 34);
            this.pbBallPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBallPlayer2.TabIndex = 2;
            this.pbBallPlayer2.TabStop = false;
            // 
            // lblNamePlayer2
            // 
            this.lblNamePlayer2.AutoEllipsis = true;
            this.lblNamePlayer2.BackColor = System.Drawing.SystemColors.Control;
            this.lblNamePlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNamePlayer2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNamePlayer2.Location = new System.Drawing.Point(0, 0);
            this.lblNamePlayer2.Name = "lblNamePlayer2";
            this.lblNamePlayer2.Size = new System.Drawing.Size(400, 70);
            this.lblNamePlayer2.TabIndex = 1;
            this.lblNamePlayer2.Text = "lblNamePlayer2";
            this.lblNamePlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPlayers1
            // 
            this.pnlPlayers1.Controls.Add(this.pbBallPlayer1);
            this.pnlPlayers1.Controls.Add(this.lblNamePlayer1);
            this.pnlPlayers1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPlayers1.Location = new System.Drawing.Point(0, 0);
            this.pnlPlayers1.Name = "pnlPlayers1";
            this.pnlPlayers1.Size = new System.Drawing.Size(400, 70);
            this.pnlPlayers1.TabIndex = 0;
            // 
            // pbBallPlayer1
            // 
            this.pbBallPlayer1.Image = global::TennisScore.Properties.Resources.ball;
            this.pbBallPlayer1.InitialImage = null;
            this.pbBallPlayer1.Location = new System.Drawing.Point(365, 20);
            this.pbBallPlayer1.Name = "pbBallPlayer1";
            this.pbBallPlayer1.Size = new System.Drawing.Size(32, 34);
            this.pbBallPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBallPlayer1.TabIndex = 1;
            this.pbBallPlayer1.TabStop = false;
            // 
            // lblNamePlayer1
            // 
            this.lblNamePlayer1.AutoEllipsis = true;
            this.lblNamePlayer1.BackColor = System.Drawing.SystemColors.Control;
            this.lblNamePlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNamePlayer1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNamePlayer1.Location = new System.Drawing.Point(0, 0);
            this.lblNamePlayer1.Name = "lblNamePlayer1";
            this.lblNamePlayer1.Size = new System.Drawing.Size(400, 70);
            this.lblNamePlayer1.TabIndex = 0;
            this.lblNamePlayer1.Text = "lblNamePlayer1";
            this.lblNamePlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlScores
            // 
            this.pnlScores.Controls.Add(this.pnlScorePlayer2);
            this.pnlScores.Controls.Add(this.pnlScorePlayer1);
            this.pnlScores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlScores.Location = new System.Drawing.Point(0, 96);
            this.pnlScores.Name = "pnlScores";
            this.pnlScores.Size = new System.Drawing.Size(882, 57);
            this.pnlScores.TabIndex = 1;
            // 
            // pnlScorePlayer2
            // 
            this.pnlScorePlayer2.Controls.Add(this.lblScorePlayer2);
            this.pnlScorePlayer2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlScorePlayer2.Location = new System.Drawing.Point(481, 0);
            this.pnlScorePlayer2.Name = "pnlScorePlayer2";
            this.pnlScorePlayer2.Size = new System.Drawing.Size(401, 57);
            this.pnlScorePlayer2.TabIndex = 1;
            // 
            // lblScorePlayer2
            // 
            this.lblScorePlayer2.AutoEllipsis = true;
            this.lblScorePlayer2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScorePlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScorePlayer2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScorePlayer2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblScorePlayer2.Location = new System.Drawing.Point(0, 0);
            this.lblScorePlayer2.Name = "lblScorePlayer2";
            this.lblScorePlayer2.Size = new System.Drawing.Size(401, 57);
            this.lblScorePlayer2.TabIndex = 2;
            this.lblScorePlayer2.Text = "lblScorePlayer2";
            this.lblScorePlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlScorePlayer1
            // 
            this.pnlScorePlayer1.Controls.Add(this.lblScorePlayer1);
            this.pnlScorePlayer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlScorePlayer1.Location = new System.Drawing.Point(0, 0);
            this.pnlScorePlayer1.Name = "pnlScorePlayer1";
            this.pnlScorePlayer1.Size = new System.Drawing.Size(398, 57);
            this.pnlScorePlayer1.TabIndex = 0;
            // 
            // lblScorePlayer1
            // 
            this.lblScorePlayer1.AutoEllipsis = true;
            this.lblScorePlayer1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblScorePlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScorePlayer1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScorePlayer1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblScorePlayer1.Location = new System.Drawing.Point(0, 0);
            this.lblScorePlayer1.Name = "lblScorePlayer1";
            this.lblScorePlayer1.Size = new System.Drawing.Size(398, 57);
            this.lblScorePlayer1.TabIndex = 1;
            this.lblScorePlayer1.Text = "lblScorePlayer1";
            this.lblScorePlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtnons
            // 
            this.pnlButtnons.Controls.Add(this.pnlButtonPlayer2);
            this.pnlButtnons.Controls.Add(this.pnlButtonPlayer1);
            this.pnlButtnons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtnons.Location = new System.Drawing.Point(0, 153);
            this.pnlButtnons.Name = "pnlButtnons";
            this.pnlButtnons.Size = new System.Drawing.Size(882, 199);
            this.pnlButtnons.TabIndex = 2;
            // 
            // pnlButtonPlayer2
            // 
            this.pnlButtonPlayer2.Controls.Add(this.btnPlayer2);
            this.pnlButtonPlayer2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtonPlayer2.Location = new System.Drawing.Point(481, 0);
            this.pnlButtonPlayer2.Name = "pnlButtonPlayer2";
            this.pnlButtonPlayer2.Size = new System.Drawing.Size(401, 199);
            this.pnlButtonPlayer2.TabIndex = 1;
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.BackColor = System.Drawing.Color.Chartreuse;
            this.btnPlayer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlayer2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlayer2.Location = new System.Drawing.Point(0, 0);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(401, 199);
            this.btnPlayer2.TabIndex = 1;
            this.btnPlayer2.Text = "Выиграно очко";
            this.btnPlayer2.UseVisualStyleBackColor = false;
            this.btnPlayer2.Click += new System.EventHandler(this.btnPlayer2_Click);
            // 
            // pnlButtonPlayer1
            // 
            this.pnlButtonPlayer1.Controls.Add(this.btnPlayer1);
            this.pnlButtonPlayer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButtonPlayer1.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonPlayer1.Name = "pnlButtonPlayer1";
            this.pnlButtonPlayer1.Size = new System.Drawing.Size(398, 199);
            this.pnlButtonPlayer1.TabIndex = 0;
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.BackColor = System.Drawing.Color.Chartreuse;
            this.btnPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlayer1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlayer1.Location = new System.Drawing.Point(0, 0);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(398, 199);
            this.btnPlayer1.TabIndex = 0;
            this.btnPlayer1.Text = "Выиграно очко";
            this.btnPlayer1.UseVisualStyleBackColor = false;
            this.btnPlayer1.Click += new System.EventHandler(this.btnPlayer1_Click);
            // 
            // pnlUndo
            // 
            this.pnlUndo.Controls.Add(this.btnUndo);
            this.pnlUndo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUndo.Location = new System.Drawing.Point(0, 352);
            this.pnlUndo.Name = "pnlUndo";
            this.pnlUndo.Size = new System.Drawing.Size(882, 92);
            this.pnlUndo.TabIndex = 3;
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUndo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUndo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUndo.Location = new System.Drawing.Point(0, 0);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(882, 92);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.Text = "Отменить предыдущее действие";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Visible = false;
            // 
            // panelMatchSum
            // 
            this.panelMatchSum.Controls.Add(this.pnlTime);
            this.panelMatchSum.Controls.Add(this.dgSummMatch);
            this.panelMatchSum.Controls.Add(this.pnlLableSum);
            this.panelMatchSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMatchSum.Location = new System.Drawing.Point(0, 444);
            this.panelMatchSum.Name = "panelMatchSum";
            this.panelMatchSum.Size = new System.Drawing.Size(882, 245);
            this.panelMatchSum.TabIndex = 4;
            // 
            // pnlTime
            // 
            this.pnlTime.Controls.Add(this.btnStopTimer);
            this.pnlTime.Controls.Add(this.lblTime);
            this.pnlTime.Controls.Add(this.lblNameTime);
            this.pnlTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTime.Location = new System.Drawing.Point(0, 185);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(882, 60);
            this.pnlTime.TabIndex = 2;
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnStopTimer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopTimer.Location = new System.Drawing.Point(465, 7);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(192, 41);
            this.btnStopTimer.TabIndex = 2;
            this.btnStopTimer.Text = "Стоп/старт таймер";
            this.btnStopTimer.UseVisualStyleBackColor = false;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(211, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(72, 22);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "lblTime";
            // 
            // lblNameTime
            // 
            this.lblNameTime.AutoSize = true;
            this.lblNameTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameTime.Location = new System.Drawing.Point(28, 16);
            this.lblNameTime.Name = "lblNameTime";
            this.lblNameTime.Size = new System.Drawing.Size(164, 19);
            this.lblNameTime.TabIndex = 0;
            this.lblNameTime.Text = "Длительность матча:";
            // 
            // dgSummMatch
            // 
            this.dgSummMatch.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgSummMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSummMatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Player,
            this.set1,
            this.set2,
            this.set3,
            this.set4,
            this.set5});
            this.dgSummMatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgSummMatch.Location = new System.Drawing.Point(0, 41);
            this.dgSummMatch.Name = "dgSummMatch";
            this.dgSummMatch.Size = new System.Drawing.Size(882, 144);
            this.dgSummMatch.TabIndex = 1;
            // 
            // Player
            // 
            this.Player.HeaderText = "Игрок";
            this.Player.Name = "Player";
            this.Player.ReadOnly = true;
            this.Player.Width = 300;
            // 
            // set1
            // 
            this.set1.HeaderText = "1-й сет";
            this.set1.MinimumWidth = 70;
            this.set1.Name = "set1";
            this.set1.ReadOnly = true;
            this.set1.Width = 70;
            // 
            // set2
            // 
            this.set2.HeaderText = "2-й сет";
            this.set2.MinimumWidth = 70;
            this.set2.Name = "set2";
            this.set2.ReadOnly = true;
            this.set2.Width = 70;
            // 
            // set3
            // 
            this.set3.HeaderText = "3-й сет";
            this.set3.MinimumWidth = 70;
            this.set3.Name = "set3";
            this.set3.ReadOnly = true;
            this.set3.Width = 70;
            // 
            // set4
            // 
            this.set4.HeaderText = "4-й сет";
            this.set4.MinimumWidth = 70;
            this.set4.Name = "set4";
            this.set4.ReadOnly = true;
            this.set4.Width = 70;
            // 
            // set5
            // 
            this.set5.HeaderText = "5-й сет";
            this.set5.MinimumWidth = 70;
            this.set5.Name = "set5";
            this.set5.ReadOnly = true;
            this.set5.Width = 70;
            // 
            // pnlLableSum
            // 
            this.pnlLableSum.Controls.Add(this.lblSummMatch);
            this.pnlLableSum.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLableSum.Location = new System.Drawing.Point(0, 0);
            this.pnlLableSum.Name = "pnlLableSum";
            this.pnlLableSum.Size = new System.Drawing.Size(882, 41);
            this.pnlLableSum.TabIndex = 0;
            // 
            // lblSummMatch
            // 
            this.lblSummMatch.AutoSize = true;
            this.lblSummMatch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSummMatch.Location = new System.Drawing.Point(9, 11);
            this.lblSummMatch.Name = "lblSummMatch";
            this.lblSummMatch.Size = new System.Drawing.Size(150, 22);
            this.lblSummMatch.TabIndex = 0;
            this.lblSummMatch.Text = "Итого по матчу:";
            // 
            // tMatchDuration
            // 
            this.tMatchDuration.Interval = 1000;
            this.tMatchDuration.Tick += new System.EventHandler(this.tMatchDuration_Tick);
            // 
            // mMenu
            // 
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterDataPlayer});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Size = new System.Drawing.Size(882, 24);
            this.mMenu.TabIndex = 5;
            this.mMenu.Text = "menuStrip1";
            // 
            // alterDataPlayer
            // 
            this.alterDataPlayer.Name = "alterDataPlayer";
            this.alterDataPlayer.Size = new System.Drawing.Size(81, 20);
            this.alterDataPlayer.Text = "Новая игра";
            this.alterDataPlayer.Click += new System.EventHandler(this.alterDataPlayer_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(882, 689);
            this.Controls.Add(this.panelMatchSum);
            this.Controls.Add(this.pnlUndo);
            this.Controls.Add(this.pnlButtnons);
            this.Controls.Add(this.pnlScores);
            this.Controls.Add(this.pnlPlayers);
            this.Controls.Add(this.mMenu);
            this.Name = "fmMain";
            this.Text = "Протокол теннисного матча. Версия 1.0.0. ®Бабейко Е.В.";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FmMain_FormClosed);
            this.pnlPlayers.ResumeLayout(false);
            this.pnlPlayer2.ResumeLayout(false);
            this.pnlPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBallPlayer2)).EndInit();
            this.pnlPlayers1.ResumeLayout(false);
            this.pnlPlayers1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBallPlayer1)).EndInit();
            this.pnlScores.ResumeLayout(false);
            this.pnlScorePlayer2.ResumeLayout(false);
            this.pnlScorePlayer1.ResumeLayout(false);
            this.pnlButtnons.ResumeLayout(false);
            this.pnlButtonPlayer2.ResumeLayout(false);
            this.pnlButtonPlayer1.ResumeLayout(false);
            this.pnlUndo.ResumeLayout(false);
            this.panelMatchSum.ResumeLayout(false);
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSummMatch)).EndInit();
            this.pnlLableSum.ResumeLayout(false);
            this.pnlLableSum.PerformLayout();
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayers;
        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.Label lblNamePlayer2;
        private System.Windows.Forms.Panel pnlPlayers1;
        private System.Windows.Forms.Label lblNamePlayer1;
        private System.Windows.Forms.PictureBox pbBallPlayer1;
        private System.Windows.Forms.PictureBox pbBallPlayer2;
        private System.Windows.Forms.Panel pnlScores;
        private System.Windows.Forms.Panel pnlScorePlayer2;
        private System.Windows.Forms.Label lblScorePlayer2;
        private System.Windows.Forms.Panel pnlScorePlayer1;
        private System.Windows.Forms.Label lblScorePlayer1;
        private System.Windows.Forms.Panel pnlButtnons;
        private System.Windows.Forms.Panel pnlButtonPlayer2;
        private System.Windows.Forms.Button btnPlayer2;
        private System.Windows.Forms.Panel pnlButtonPlayer1;
        private System.Windows.Forms.Button btnPlayer1;
        private System.Windows.Forms.Panel pnlUndo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Panel panelMatchSum;
        private System.Windows.Forms.DataGridView dgSummMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn set1;
        private System.Windows.Forms.DataGridViewTextBoxColumn set2;
        private System.Windows.Forms.DataGridViewTextBoxColumn set3;
        private System.Windows.Forms.DataGridViewTextBoxColumn set4;
        private System.Windows.Forms.DataGridViewTextBoxColumn set5;
        private System.Windows.Forms.Panel pnlLableSum;
        private System.Windows.Forms.Label lblSummMatch;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblNameTime;
        private System.Windows.Forms.Timer tMatchDuration;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem alterDataPlayer;
    }
}

