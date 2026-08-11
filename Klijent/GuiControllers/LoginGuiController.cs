using Klijent;
using System;
using System.Windows.Forms;

namespace Klijent.GuiControllers
{
    internal class LoginGuiController
    {
        private static LoginGuiController instance;

        public static LoginGuiController Instance
        {
            get
            {
                if (instance == null) instance = new LoginGuiController();
                return instance;
            }
        }

        private LoginGuiController()
        {
        }

        FrmLogin frmLogin;

        internal void SrediFormu(FrmLogin forma)
        {
            frmLogin = forma;
        }

        internal void PrijaviSe(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Unesite korisničko ime i lozinku!");
                return;
            }

            try
            {
                bool uspesno = Komunikacija.Instance.Login(username, password);

                if (uspesno)
                {
                    MessageBox.Show("Uspešno ste se prijavili!");
                    frmLogin.Hide();
                    MainCoordinator.Instance.ShowFrmGlavna();
                }
                else
                {
                    MessageBox.Show("Pogrešno korisničko ime ili lozinka!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri prijavi: " + ex.Message);
            }
        }
    }
}