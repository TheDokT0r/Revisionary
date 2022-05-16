namespace Revisionary
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //center the title
            lbl_title.Location = new Point((this.Width / 2) - (lbl_title.Width / 2), lbl_title.Location.Y);
        }


        private void btn_create_Click(object sender, EventArgs e)
        {

            Set_Title set_Title = new Set_Title();
            set_Title.Show();
            Hide();

            /*Create_Set create_Set = new Create_Set();
            create_Set.Show();
            Hide();*/
        }


        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btn_load_Click(object sender, EventArgs e)
        {
            /*Sets_List sets_List = new Sets_List();
            sets_List.Show();
            Hide();*/

            Choose_Set choose_Set = new Choose_Set(0);
            choose_Set.Show();
            Hide();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            MannageSets.ImportSets();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            Hide();
        }

        private void btn_exportSet_Click(object sender, EventArgs e)
        {
            Sets_List sets_List = new Sets_List();
            sets_List.Show();
            Hide();
        }
    }
}