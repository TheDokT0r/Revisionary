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
            Sets_List sets_List = new Sets_List();
            sets_List.Show();
            Hide();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            MannageSets.ImportSets();
        }
    }
}