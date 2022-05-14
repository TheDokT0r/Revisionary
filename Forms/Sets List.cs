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
    public partial class Sets_List : Form
    {
        CardsSet[] cardsSets;

        public Sets_List()
        {
            InitializeComponent();

            cardsSets = MannageSets.getAllSets();
            ViewCardSets();
        }

        private void Sets_List_Load(object sender, EventArgs e)
        {

        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void ViewCardSets()
        {
            foreach(CardsSet cardSet in cardsSets)
            {
                view_SetsList.Items.Add("Set: " + cardSet.title + " | Subject: " + cardSet.subject);
            }
        }

        private void view_SetsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_selectSet.Visible = true; //Giving the user an option to select a set only after a set was selected
        }

        private void btn_selectSet_Click(object sender, EventArgs e) //Selecting a set
        {
            int index = view_SetsList.SelectedIndex;

            CardsSet set = cardsSets[index];

            Game game = new Game(set);
            game.Show();
            Hide();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            MannageSets.ImportSets();
        }

        private void btn_backToMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }
    }
}
