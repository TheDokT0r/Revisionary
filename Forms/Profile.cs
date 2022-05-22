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
            lbl_userName.Location = new Point(this.Width / 2 - lbl_userName.Width / 2, lbl_userName.Location.Y);

            lbl_gamesPlayed.Text = "Games Played: " + usrData.games_played;
            lbl_perfectGames.Text = "Perfect Games: " + usrData.perfect_games;
            lbl_timePlayed.Text = "Time Played: " + setTimePlayedStr(Convert.ToDouble(usrData.minutes_practiced)) + " minutes";
            lbl_setsCreated.Text = "Sets Created: " + usrData.sets_created;
        }


        string setTimePlayedStr(double timePlayed)
        {
            string[] splited = timePlayed.ToString().Split(".");

            try
            {
                return splited[0] + "." + splited[1].Substring(0, 2);
            }
            catch
            {
                return splited[0] + ".00";
            }
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            foreach(dynamic item in Controls) //Makes all other items invisible
            {
                item.Visible = false;
            }

            lbl_newUsrname.Visible = true;
            txb_newName.Visible = true;
            btn_submit.Visible = true;
        }

        private void btn_submit_Click(object sender, EventArgs e) //Submit a new username
        {
            if(txb_newName.Text == String.Empty)
            {
                MessageBox.Show("Invalid username. Please try again");
                return;
            }

            ProfileMannager.ChangeName(txb_newName.Text);

            foreach (dynamic item in Controls)
            {
                item.Visible = true;
            }

            lbl_newUsrname.Visible = false;
            txb_newName.Visible = false;
            btn_submit.Visible = false;

            usrData = ProfileMannager.GetAllData();
            setData();
        }


        private void btn_progress_Click(object sender, EventArgs e)
        {
            Choose_Set choose_Set_Progress = new Choose_Set(1);
            choose_Set_Progress.Show();
            Hide();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
