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
    public partial class Set_Title : Form
    {
        public Set_Title()
        {
            InitializeComponent();
        }

        private void Set_Title_Load(object sender, EventArgs e)
        {

        }


        private void btn_continue_Click(object sender, EventArgs e)
        {
            if (cmb_subjects.Text == "" || cmb_subjects.Text == "" || !cmb_subjects.Items.Contains(cmb_subjects.Text))
            {
                MessageBox.Show("Data is invalid. Please Make sure you've filled the title field and chose a subject from the list", "Error");
                return;
            }

            /*Create_Set_Old create_Set = new Create_Set_Old(txb_title.Text, cmb_subjects.Text);
            create_Set.Show();
            Hide();*/

            Create_Set create_Set = new Create_Set(txb_title.Text, cmb_subjects.Text);
            create_Set.Show();
            Hide();
        }


        private void btn_GoBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }


        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
