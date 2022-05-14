namespace Revisionary
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            MannageSets.checkFolder(); //Checks if the sets folder exists
            ProfileMannager.SetProfileFiles();

            Application.Run(new Menu());
        }
    }
}