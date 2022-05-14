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
        public Profile()
        {
            InitializeComponent();


        }

        private void Profile_Load(object sender, EventArgs e)
        {
            ProfileMannager.SetProfileFiles();
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
