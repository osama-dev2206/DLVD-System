namespace FrontEnd
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

       private static frmLogin login = new frmLogin();
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            login.OnUserLoggedSuccess += OnLoginSuccess;

            login.ShowDialog();

        }


       static void OnLoginSuccess(bool  Res)
        {
            if(Res)
            {
              frmMain main = new frmMain();
                login.Dispose();
                main.ShowDialog();
            }
        }


    }
}