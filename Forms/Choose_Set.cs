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
    public partial class Choose_Set : Form
    {
        Button[] subjectButtons;
        List<CardsSet> setsList;
        int purpose; //0 = to game. 1 = show progress.

        public Choose_Set(int purpose)
        {
            InitializeComponent();
            this.purpose = purpose;

            setsList = new List<CardsSet>();

            subjectButtons = new Button[] { btn_subj1, btn_subj2, btn_subj3, btn_subj4, btn_subj5, btn_subj6, btn_others };

            for(int i = 0; i < subjectButtons.Length; i++)
            {
                subjectButtons[i].Click += new System.EventHandler(this.click_subj);
            }
        }

        private void Choose_Set_Progress_Load(object sender, EventArgs e)
        {
            allSubjects();
        }


        private void click_subj(object sender, EventArgs e)
        {
            lst_sets.Items.Clear(); //clears the list before adding mew subjects
            setsList.Clear();

            var btn = sender as Button; //Sets the sender back as a button

            var sets = MannageSets.getAllSets();

            foreach(var set in sets)
            {
                if (set.subject.ToLower() == btn.Text.ToLower())
                {
                    setsList.Add(set);
                    lst_sets.Items.Add(set.title);
                }
            }
        }



        private void btn_allSubjs_Click(object sender, EventArgs e) //Select all subjects
        {
            allSubjects();
        }


        void allSubjects()
        {
            lst_sets.Items.Clear(); //clears the list before adding mew subjects
            setsList.Clear();

            var sets = MannageSets.getAllSets();

            foreach (var set in sets)
            {
                setsList.Add(set);
                lst_sets.Items.Add(set.title);
            }
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btn_select_Click(object sender, EventArgs e)
        {
            if(lst_sets.SelectedItems == null || lst_sets.SelectedIndex < 0)
            {
                return;
            }

            int index = lst_sets.SelectedIndex;
            
            if (purpose == 0)
            {
                Game game = new Game(setsList[index]);
                game.Show();
                this.Hide();
            }
            else if (purpose == 1)
            {
                if(setsList[index] != null)
                {
                    Progress progress = new Progress(setsList[index]);
                    progress.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Set couldn't be found");
                }
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Hide();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            /*if(lst_sets.SelectedItems == null || lst_sets.SelectedIndex < 0)
            {
                return;
            }

            Edit_Set edit_Set = new Edit_Set(setsList[lst_sets.SelectedIndex]);
            edit_Set.Show();
            Hide();*/

            MessageBox.Show("This feature isn't avaliable yet");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lst_sets.SelectedItems == null || lst_sets.SelectedIndex < 0)
            {
                return;
            }

            var results = MessageBox.Show("Are you sure you want to delete this set?", "Are you sure", MessageBoxButtons.YesNo);

            if (results == DialogResult.Yes)
            {
                MannageSets.removeSet(setsList[lst_sets.SelectedIndex]);
                allSubjects();
                MessageBox.Show("Set has been removed from the database");
            }
        }
    }
}
