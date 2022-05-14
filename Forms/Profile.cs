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
        string rootPath;
        string profileDir;
        string usrDataFile;
        string usrStuts;

        public Profile()
        {
            InitializeComponent();

            rootPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.Revisionary";
            profileDir = rootPath + "/usr/";
            usrDataFile = profileDir + "/pf.you";
            usrStuts = profileDir + "/stuts.you";
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            SetProfileFiles();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        void SetProfileFiles()
        {
            if(!Directory.Exists(profileDir))
            {
                Directory.CreateDirectory(profileDir);
                File.Create(profileDir);
                File.Create(usrStuts);
            }
        }
    }
}
