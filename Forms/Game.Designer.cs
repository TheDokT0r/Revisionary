namespace Revisionary
{
    partial class Game
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_questionNumber = new System.Windows.Forms.Label();
            this.lbl_question = new System.Windows.Forms.Label();
            this.lbl_correctOrWrong = new System.Windows.Forms.Label();
            this.btn_playAgain = new System.Windows.Forms.Button();
            this.btn_backToMenu = new System.Windows.Forms.Button();
            this.lbl_stuts = new System.Windows.Forms.Label();
            this.timer_playTime = new System.Windows.Forms.Timer(this.components);
            this.btn_seeProgress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(300, 41);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "set name and subject";
            // 
            // lbl_questionNumber
            // 
            this.lbl_questionNumber.AutoSize = true;
            this.lbl_questionNumber.Location = new System.Drawing.Point(1188, 9);
            this.lbl_questionNumber.Name = "lbl_questionNumber";
            this.lbl_questionNumber.Size = new System.Drawing.Size(62, 41);
            this.lbl_questionNumber.TabIndex = 1;
            this.lbl_questionNumber.Text = "0/0";
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_question.ForeColor = System.Drawing.Color.White;
            this.lbl_question.Location = new System.Drawing.Point(464, 106);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(244, 59);
            this.lbl_question.TabIndex = 2;
            this.lbl_question.Text = "Placeholder";
            this.lbl_question.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_correctOrWrong
            // 
            this.lbl_correctOrWrong.AutoSize = true;
            this.lbl_correctOrWrong.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_correctOrWrong.Location = new System.Drawing.Point(494, 575);
            this.lbl_correctOrWrong.Name = "lbl_correctOrWrong";
            this.lbl_correctOrWrong.Size = new System.Drawing.Size(214, 89);
            this.lbl_correctOrWrong.TabIndex = 3;
            this.lbl_correctOrWrong.Text = "label1";
            this.lbl_correctOrWrong.Visible = false;
            // 
            // btn_playAgain
            // 
            this.btn_playAgain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_playAgain.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_playAgain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_playAgain.Location = new System.Drawing.Point(834, 331);
            this.btn_playAgain.Name = "btn_playAgain";
            this.btn_playAgain.Size = new System.Drawing.Size(235, 96);
            this.btn_playAgain.TabIndex = 4;
            this.btn_playAgain.Text = "Play Again";
            this.btn_playAgain.UseVisualStyleBackColor = false;
            this.btn_playAgain.Visible = false;
            this.btn_playAgain.Click += new System.EventHandler(this.btn_playAgain_Click);
            // 
            // btn_backToMenu
            // 
            this.btn_backToMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_backToMenu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_backToMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_backToMenu.Location = new System.Drawing.Point(139, 331);
            this.btn_backToMenu.Name = "btn_backToMenu";
            this.btn_backToMenu.Size = new System.Drawing.Size(238, 96);
            this.btn_backToMenu.TabIndex = 5;
            this.btn_backToMenu.Text = "Back to Menu";
            this.btn_backToMenu.UseVisualStyleBackColor = false;
            this.btn_backToMenu.Visible = false;
            this.btn_backToMenu.Click += new System.EventHandler(this.btn_backToMenu_Click);
            // 
            // lbl_stuts
            // 
            this.lbl_stuts.AutoSize = true;
            this.lbl_stuts.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_stuts.Location = new System.Drawing.Point(322, 97);
            this.lbl_stuts.Name = "lbl_stuts";
            this.lbl_stuts.Size = new System.Drawing.Size(553, 108);
            this.lbl_stuts.TabIndex = 6;
            this.lbl_stuts.Text = "You\'ve answered (  ) Correctly!\r\nPlay time: Idk";
            this.lbl_stuts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_stuts.Visible = false;
            // 
            // timer_playTime
            // 
            this.timer_playTime.Interval = 1000;
            this.timer_playTime.Tick += new System.EventHandler(this.timer_playTime_Tick);
            // 
            // btn_seeProgress
            // 
            this.btn_seeProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_seeProgress.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_seeProgress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_seeProgress.Location = new System.Drawing.Point(470, 331);
            this.btn_seeProgress.Name = "btn_seeProgress";
            this.btn_seeProgress.Size = new System.Drawing.Size(238, 96);
            this.btn_seeProgress.TabIndex = 7;
            this.btn_seeProgress.Text = "See Progress";
            this.btn_seeProgress.UseVisualStyleBackColor = false;
            this.btn_seeProgress.Visible = false;
            this.btn_seeProgress.Click += new System.EventHandler(this.btn_seeProgres_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btn_seeProgress);
            this.Controls.Add(this.lbl_stuts);
            this.Controls.Add(this.btn_backToMenu);
            this.Controls.Add(this.btn_playAgain);
            this.Controls.Add(this.lbl_correctOrWrong);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.lbl_questionNumber);
            this.Controls.Add(this.lbl_title);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_title;
        private Label lbl_questionNumber;
        private Label lbl_question;
        private Label lbl_correctOrWrong;
        private Button btn_playAgain;
        private Button btn_backToMenu;
        private Label lbl_stuts;
        private System.Windows.Forms.Timer timer_playTime;
        private Button btn_seeProgress;
    }
}