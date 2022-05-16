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
        string[] paths;

        public Sets_List()
        {
            InitializeComponent();

            cardsSets = MannageSets.getAllSets();
            paths = MannageSets.getAllSetsPaths();
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

            MannageSets.ExportSet(paths[index]);
            MessageBox.Show("Set has been saved in the target folder.\nYou can now send the file to your friends!");

            //CardsSet set = cardsSets[index];

            //MannageSets.ExportSet()

            //Game game = new Game(set);
            //game.Show();
            //Hide();
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
