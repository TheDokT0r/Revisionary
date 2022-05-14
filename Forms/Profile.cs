using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisionary
{
    public partial class Profile : Form
    {
        dynamic usrData;
        public Profile()
        {
            InitializeComponent();

            usrData = ProfileMannager.GetAllData();
        }


        private void Profile_Load(object sender, EventArgs e)
        {
            ProfileMannager.SetProfileFiles();
            setData();
        }


        void setData()
        {
            lbl_userName.Text = "Welcome Back " + usrData.name + "!";
            lbl_gamesPlayed.Text = "Games Played: " + usrData.games_played;
            lbl_perfectGames.Text = "Perfect Games: " + usrData.perfect_games;
            lbl_timePlayed.Text = "Time Played: " + usrData.time_played;
            lbl_setsCreated.Text = "Sets Created: " + usrData.sets_created;
        }


        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
