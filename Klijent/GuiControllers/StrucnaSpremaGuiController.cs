using Klijent.UserControlls;
using System;
using System.Drawing;
using System.Windows.Forms;
using Zajednicki.Domen;

namespace Klijent.GuiControllers
{
    internal class StrucnaSpremaGuiController
    {
        private static StrucnaSpremaGuiController? instance;
        private ErrorProvider? errorProvider;
        private UCDodajStrucnuSpremu? ucDodajStrucnuSpremu;

        public static StrucnaSpremaGuiController Instance
        {
            get
            {
                if (instance == null) instance = new StrucnaSpremaGuiController();
                return instance;
            }
        }

        private StrucnaSpremaGuiController()
        {
        }

        internal Control UbaciStrucnuSpremu()
        {
            ucDodajStrucnuSpremu = new UCDodajStrucnuSpremu();
            errorProvider = new ErrorProvider();
            ucDodajStrucnuSpremu.txtNaziv.TextChanged += (s, e) => ObrisiGresku(ucDodajStrucnuSpremu.txtNaziv);
            ucDodajStrucnuSpremu.cbStrSprema.SelectedIndexChanged += (s, e) => ObrisiGresku(ucDodajStrucnuSpremu.cbStrSprema);
            ucDodajStrucnuSpremu.cbStrSprema.SelectedIndex = -1;
            ucDodajStrucnuSpremu.btnDodaj.Click += DodajStrSpremu;
            return ucDodajStrucnuSpremu;
        }

        private bool ValidirajStrucnuSpremu()
        {
            if (ucDodajStrucnuSpremu == null || errorProvider == null) return false;
            bool isValid = true;

            if (string.IsNullOrEmpty(ucDodajStrucnuSpremu.txtNaziv.Text))
            {
                PrikaziGresku(ucDodajStrucnuSpremu.txtNaziv, "Naziv je obavezan!");
                isValid = false;
            }
            else
            {
                ObrisiGresku(ucDodajStrucnuSpremu.txtNaziv);
            }

            if (ucDodajStrucnuSpremu.cbStrSprema.SelectedItem == null)
            {
                PrikaziGresku(ucDodajStrucnuSpremu.cbStrSprema, "Stepen obrazovanja je obavezan!");
                isValid = false;
            }
            else
            {
                ObrisiGresku(ucDodajStrucnuSpremu.cbStrSprema);
            }

            return isValid;
        }

        private void PrikaziGresku(Control control, string poruka)
        {
            if (errorProvider == null) return;
            control.BackColor = Color.LightCoral;
            errorProvider.SetError(control, poruka);
        }

        private void ObrisiGresku(Control control)
        {
            if (errorProvider == null) return;
            control.BackColor = SystemColors.Window;
            errorProvider.SetError(control, "");
        }

        private void DodajStrSpremu(object? sender, EventArgs e)
        {
            if (ucDodajStrucnuSpremu == null) return;
            if (!ValidirajStrucnuSpremu())
            {
                return;
            }

            StrucnaSprema objekatStrucnaSprema = new StrucnaSprema
            {
                Naziv = ucDodajStrucnuSpremu.txtNaziv.Text,
                StepenObrazovanja = ucDodajStrucnuSpremu.cbStrSprema.SelectedItem.ToString()
            };

            try
            {
                Komunikacija.Instance.SacuvajStrucnaSprema(objekatStrucnaSprema);
                MessageBox.Show("Stručna sprema je uspešno sačuvana!");
                RefreshFormu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška prilikom čuvanja stručne spreme: " + ex.Message);
            }
        }


        private void RefreshFormu()
        {
            if (ucDodajStrucnuSpremu == null) return;
            ucDodajStrucnuSpremu.txtNaziv.Clear();
            ucDodajStrucnuSpremu.cbStrSprema.SelectedIndex = -1;
            ObrisiGresku(ucDodajStrucnuSpremu.txtNaziv);
            ObrisiGresku(ucDodajStrucnuSpremu.cbStrSprema);
        }
    }
}