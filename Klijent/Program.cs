using Klijent.GuiControllers;

namespace Klijent
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            MainCoordinator.Instance.ShowFrmLogin();


        }
    }
}