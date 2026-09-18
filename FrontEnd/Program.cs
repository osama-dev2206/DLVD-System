namespace FrontEnd
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        private static frmLogin login = new frmLogin();
        private static frmMain main = new frmMain();

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // The First Time 
            login.OnUserLoggedSuccess += OnLoginSuccess;
            main.OnUserLogOut += OnLogout;
            login.ShowDialog();

        }


        static void OnLoginSuccess(bool Res)
        {
            if (Res)
            {
                login.Dispose();
                main.ShowDialog();
            }


        }

        static void OnLogout(bool Res)
        {
            if (Res)
            {
                main.Dispose(); // free the resources used by the main form
         
                login = new frmLogin(); // show a new instance of the login form
                login.OnUserLoggedSuccess += OnLoginSuccess; // re-subscribe to the login success event

                main = new frmMain(); // create a new instance of the main form
                main.OnUserLogOut += OnLogout;

                login.ShowDialog();
            }

        }





    }
}