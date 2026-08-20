using Klijent.UserControlls;
using System;
using System.Windows.Forms;
namespace Klijent.GuiControllers
{
    internal class MainCoordinator
    {
        private static MainCoordinator instance;
        public static MainCoordinator Instance
        {
            get
            {
                if (instance == null) instance = new MainCoordinator();
                return instance;
            }
        }
        private MainCoordinator()
        {
        }
        private FrmGlavna frmGlavna;
        private FrmLogin frmLogin;

        internal void ShowFrmLogin()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Komunikacija.Instance.Connect();

                frmLogin = new FrmLogin();

                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    frmGlavna = new FrmGlavna();
                    Application.Run(frmGlavna);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Neuspesna konekcija sa serverom!");
            }
        }


        internal void ShowDodajRacunPanel(object? sender, EventArgs e)
        {
            frmGlavna.ChangePanel(RacunGuiController.Instance.KreirajRacun());
        }
        internal void ShowPretraziRacunPanel(object? sender, EventArgs e)
        {
            frmGlavna.ChangePanel(RacunGuiController.Instance.PretraziRacun());
        }
        internal void ShowDodajKupcaPanel(object? sender, EventArgs e)
        {
            frmGlavna.ChangePanel(KupacGuiController.Instance.KreirajKupca());
        }
        internal void ShowPretraziKupcaPanel(object? sender, EventArgs e)
        {
            frmGlavna.ChangePanel(KupacGuiController.Instance.PretraziKupca());
        }
        internal void ShowDodajStrucnuSpremuPanel(object? sender, EventArgs e)
        {
            frmGlavna.ChangePanel(StrucnaSpremaGuiController.Instance.UbaciStrucnuSpremu());
        }
        internal void ShowPanel(UserControl ucPrikaz)
        {
            frmGlavna.ChangePanel(ucPrikaz);
        }
    }
}