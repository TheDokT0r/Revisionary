namespace Revisionary
{
    partial class Profile
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
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_gamesPlayed = new System.Windows.Forms.Label();
            this.lbl_timePlayed = new System.Windows.Forms.Label();
            this.lbl_perfectGames = new System.Windows.Forms.Label();
            this.lbl_setsCreated = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txb_newName = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_newUsrname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_userName.Location = new System.Drawing.Point(337, 9);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(591, 67);
            this.lbl_userName.TabIndex = 0;
            this.lbl_userName.Text = "Welcome Back username!";
            // 
            // lbl_gamesPlayed
            // 
            this.lbl_gamesPlayed.AutoSize = true;
            this.lbl_gamesPlayed.Location = new System.Drawing.Point(12, 119);
            this.lbl_gamesPlayed.Name = "lbl_gamesPlayed";
            this.lbl_gamesPlayed.Size = new System.Drawing.Size(276, 46);
            this.lbl_gamesPlayed.TabIndex = 1;
            this.lbl_gamesPlayed.Text = "Games Played: -1";
            // 
            // lbl_timePlayed
            // 
            this.lbl_timePlayed.AutoSize = true;
            this.lbl_timePlayed.Location = new System.Drawing.Point(12, 196);
            this.lbl_timePlayed.Name = "lbl_timePlayed";
            this.lbl_timePlayed.Size = new System.Drawing.Size(248, 46);
            this.lbl_timePlayed.TabIndex = 2;
            this.lbl_timePlayed.Text = "Time Played: -1";
            // 
            // lbl_perfectGames
            // 
            this.lbl_perfectGames.AutoSize = true;
            this.lbl_perfectGames.Location = new System.Drawing.Point(12, 272);
            this.lbl_perfectGames.Name = "lbl_perfectGames";
            this.lbl_perfectGames.Size = new System.Drawing.Size(283, 46);
            this.lbl_perfectGames.TabIndex = 3;
            this.lbl_perfectGames.Text = "Perfect Games: -1";
            // 
            // lbl_setsCreated
            // 
            this.lbl_setsCreated.AutoSize = true;
            this.lbl_setsCreated.Location = new System.Drawing.Point(12, 348);
            this.lbl_setsCreated.Name = "lbl_setsCreated";
            this.lbl_setsCreated.Size = new System.Drawing.Size(257, 46);
            this.lbl_setsCreated.TabIndex = 4;
            this.lbl_setsCreated.Text = "Sets Created: -1";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_back.Location = new System.Drawing.Point(513, 599);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(191, 62);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Back to Menu";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.Location = new System.Drawing.Point(1059, 23);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(191, 62);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Update Profile";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txb_newName
            // 
            this.txb_newName.Location = new System.Drawing.Point(417, 190);
            this.txb_newName.Name = "txb_newName";
            this.txb_newName.Size = new System.Drawing.Size(467, 52);
            this.txb_newName.TabIndex = 7;
            this.txb_newName.Visible = false;
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_submit.Location = new System.Drawing.Point(549, 268);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(191, 62);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Visible = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_newUsrname
            // 
            this.lbl_newUsrname.AutoSize = true;
            this.lbl_newUsrname.Location = new System.Drawing.Point(513, 141);
            this.lbl_newUsrname.Name = "lbl_newUsrname";
            this.lbl_newUsrname.Size = new System.Drawing.Size(254, 46);
            this.lbl_newUsrname.TabIndex = 9;
            this.lbl_newUsrname.Text = "New Username:";
            this.lbl_newUsrname.Visible = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.lbl_newUsrname);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txb_newName);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_setsCreated);
            this.Controls.Add(this.lbl_perfectGames);
            this.Controls.Add(this.lbl_timePlayed);
            this.Controls.Add(this.lbl_gamesPlayed);
            this.Controls.Add(this.lbl_userName);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_userName;
        private Label lbl_gamesPlayed;
        private Label lbl_timePlayed;
        private Label lbl_perfectGames;
        private Label lbl_setsCreated;
        private Button btn_back;
        private Button btn_update;
        private TextBox txb_newName;
        private Button btn_submit;
        private Label lbl_newUsrname;
    }
}