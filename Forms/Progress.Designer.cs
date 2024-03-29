﻿namespace Revisionary
{
    partial class Progress
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_gamesPlayed = new System.Windows.Forms.Label();
            this.lbl_perfectGames = new System.Windows.Forms.Label();
            this.lbl_timePlayed = new System.Windows.Forms.Label();
            this.btn_backToMenu = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.lbl_avrgCorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(309, 7);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(355, 37);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Your progress in placeholder";
            // 
            // lbl_gamesPlayed
            // 
            this.lbl_gamesPlayed.AutoSize = true;
            this.lbl_gamesPlayed.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_gamesPlayed.Location = new System.Drawing.Point(10, 72);
            this.lbl_gamesPlayed.Name = "lbl_gamesPlayed";
            this.lbl_gamesPlayed.Size = new System.Drawing.Size(154, 30);
            this.lbl_gamesPlayed.TabIndex = 1;
            this.lbl_gamesPlayed.Text = "Games Played:";
            // 
            // lbl_perfectGames
            // 
            this.lbl_perfectGames.AutoSize = true;
            this.lbl_perfectGames.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_perfectGames.Location = new System.Drawing.Point(10, 116);
            this.lbl_perfectGames.Name = "lbl_perfectGames";
            this.lbl_perfectGames.Size = new System.Drawing.Size(157, 30);
            this.lbl_perfectGames.TabIndex = 2;
            this.lbl_perfectGames.Text = "Perfect Games:";
            // 
            // lbl_timePlayed
            // 
            this.lbl_timePlayed.AutoSize = true;
            this.lbl_timePlayed.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_timePlayed.Location = new System.Drawing.Point(10, 154);
            this.lbl_timePlayed.Name = "lbl_timePlayed";
            this.lbl_timePlayed.Size = new System.Drawing.Size(136, 30);
            this.lbl_timePlayed.TabIndex = 3;
            this.lbl_timePlayed.Text = "Time Played:";
            // 
            // btn_backToMenu
            // 
            this.btn_backToMenu.BackColor = System.Drawing.SystemColors.Info;
            this.btn_backToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_backToMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_backToMenu.Location = new System.Drawing.Point(926, 440);
            this.btn_backToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_backToMenu.Name = "btn_backToMenu";
            this.btn_backToMenu.Size = new System.Drawing.Size(168, 56);
            this.btn_backToMenu.TabIndex = 4;
            this.btn_backToMenu.Text = "Back to Menu";
            this.btn_backToMenu.UseVisualStyleBackColor = false;
            this.btn_backToMenu.Click += new System.EventHandler(this.btn_backToMenu_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.Info;
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_play.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_play.Location = new System.Drawing.Point(745, 440);
            this.btn_play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(168, 56);
            this.btn_play.TabIndex = 5;
            this.btn_play.Text = "Replay Set";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // lbl_avrgCorrect
            // 
            this.lbl_avrgCorrect.AutoSize = true;
            this.lbl_avrgCorrect.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_avrgCorrect.Location = new System.Drawing.Point(10, 198);
            this.lbl_avrgCorrect.Name = "lbl_avrgCorrect";
            this.lbl_avrgCorrect.Size = new System.Drawing.Size(263, 30);
            this.lbl_avrgCorrect.TabIndex = 6;
            this.lbl_avrgCorrect.Text = "Average Correct Answers:";
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1104, 505);
            this.Controls.Add(this.lbl_avrgCorrect);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_backToMenu);
            this.Controls.Add(this.lbl_timePlayed);
            this.Controls.Add(this.lbl_perfectGames);
            this.Controls.Add(this.lbl_gamesPlayed);
            this.Controls.Add(this.lbl_title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Progress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Revisionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Progress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_title;
        private Label lbl_gamesPlayed;
        private Label lbl_perfectGames;
        private Label lbl_timePlayed;
        private Button btn_backToMenu;
        private Button btn_play;
        private Label lbl_avrgCorrect;
    }
}