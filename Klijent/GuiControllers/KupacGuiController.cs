using Klijent.ModelView;
using Klijent.UserControlls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Zajednicki.Domen;

namespace Klijent.GuiControllers
{
    internal class KupacGuiController
    {
        private static KupacGuiController? instance;
        private ErrorProvider? errorProvider;

        // Promenjeno ime forme u UCDodajKupca
        private UCDodajKupca? ucDodajKupca;

        public static KupacGuiController Instance
        {
            get
            {
                if (instance == null) instance = new KupacGuiController();
                return instance;
            }
        }

        private KupacGuiController()
        {
        }

        internal Control KreirajKupca()
        {
            ucDodajKupca = new UCDodajKupca();
            errorProvider = new ErrorProvider();

            ucDodajKupca.txtIme.TextChanged += (s, e) => ObrisiGresku(ucDodajKupca.txtIme);
            ucDodajKupca.txtTelefon.TextChanged += (s, e) => ObrisiGresku(ucDodajKupca.txtTelefon);
            ucDodajKupca.txtEmail.TextChanged += (s, e) => ObrisiGresku(ucDodajKupca.txtEmail);
            ucDodajKupca.txtNaziv.TextChanged += (s, e) => ObrisiGresku(ucDodajKupca.txtNaziv);
            ucDodajKupca.txtPostanski.TextChanged += (s, e) => ObrisiGresku(ucDodajKupca.txtPostanski);

            ucDodajKupca.btnSacuvaj.Click += SacuvajKupca;

            return ucDodajKupca;
        }

        private bool ValidirajKupca(TextBox txtIme, TextBox txtEmail, TextBox txtTelefon, TextBox txtNaziv, TextBox txtPostanski)
        {
            if (errorProvider == null) return false;
            bool isValid = true;

            if (string.IsNullOrEmpty(txtIme.Text))
            {
                PrikaziGresku(txtIme, "Ime i prezime je obavezno!");
                isValid = false;
            }
            else ObrisiGresku(txtIme);

            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                PrikaziGresku(txtEmail, "Email je obavezan!");
                isValid = false;
            }
            else if (!email.Contains("@"))
            {
                PrikaziGresku(txtEmail, "Email mora sadržati znak '@'!");
                isValid = false;
            }
            else ObrisiGresku(txtEmail);

            string telefon = txtTelefon.Text.Trim();
            if (string.IsNullOrEmpty(telefon))
            {
                PrikaziGresku(txtTelefon, "Telefon je obavezan!");
                isValid = false;
            }
            else if (!telefon.StartsWith("06"))
            {
                PrikaziGresku(txtTelefon, "Broj telefona mora počinjati sa '06'!");
                isValid = false;
            }
            else if (telefon.Length < 9)
            {
                PrikaziGresku(txtTelefon, "Broj telefona mora imati najmanje 9 cifara!");
                isValid = false;
            }
            else ObrisiGresku(txtTelefon);

            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                PrikaziGresku(txtNaziv, "Naziv mesta je obavezan!");
                isValid = false;
            }
            else ObrisiGresku(txtNaziv);

            string postanskiBroj = txtPostanski.Text.Trim();
            if (string.IsNullOrEmpty(postanskiBroj))
            {
                PrikaziGresku(txtPostanski, "Poštanski broj je obavezan!");
                isValid = false;
            }
            else if (!postanskiBroj.All(char.IsDigit))
            {
                PrikaziGresku(txtPostanski, "Poštanski broj može sadržati samo cifre!");
                isValid = false;
            }
            else ObrisiGresku(txtPostanski);

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

        private void SacuvajKupca(object? sender, EventArgs e)
        {
            if (ucDodajKupca == null) return;

            if (!ValidirajKupca(ucDodajKupca.txtIme, ucDodajKupca.txtEmail, ucDodajKupca.txtTelefon, ucDodajKupca.txtNaziv, ucDodajKupca.txtPostanski))
            {
                return;
            }

            Kupac kupac = new Kupac()
            {
                Naziv = ucDodajKupca.txtIme.Text,
                Telefon = ucDodajKupca.txtTelefon.Text,
                Email = ucDodajKupca.txtEmail.Text,
                Mesto = new Mesto()
                {
                    Naziv = ucDodajKupca.txtNaziv.Text,
                    PostanskiBroj = ucDodajKupca.txtPostanski.Text
                }
            };

            try
            {
                Komunikacija.Instance.SacuvajKupac(kupac);
                MessageBox.Show("Kupac je uspešno sačuvan!");
                RefreshDodaj();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da sačuva kupca! " + ex.Message);
            }
        }

        private void RefreshDodaj()
        {
            if (ucDodajKupca == null) return;

            ucDodajKupca.txtIme.Text = string.Empty;
            ucDodajKupca.txtTelefon.Text = string.Empty;
            ucDodajKupca.txtEmail.Text = string.Empty;
            ucDodajKupca.txtNaziv.Text = string.Empty;
            ucDodajKupca.txtPostanski.Text = string.Empty;

            ObrisiGresku(ucDodajKupca.txtIme);
            ObrisiGresku(ucDodajKupca.txtTelefon);
            ObrisiGresku(ucDodajKupca.txtEmail);
            ObrisiGresku(ucDodajKupca.txtNaziv);
            ObrisiGresku(ucDodajKupca.txtPostanski);
        }

      
        internal Control PretraziKupca()
        {
            UCPretraziKupca ucPretraga = new UCPretraziKupca();

            ucPretraga.dgvPretrazi.AutoGenerateColumns = true;
            ucPretraga.dgvPretrazi.AllowUserToAddRows = false;
            ucPretraga.dgvPretrazi.ReadOnly = true;
            ucPretraga.dgvPretrazi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ucPretraga.dgvPretrazi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 


            ucPretraga.txtPretrazi.TextChanged += (sender, e) =>
            {
                string kriterijum = ucPretraga.txtPretrazi.Text.Trim();

                if (string.IsNullOrEmpty(kriterijum))
                {
                    ucPretraga.dgvPretrazi.DataSource = null;
                    return;
                }

                PretraziKupceURealnomVremenu(ucPretraga, kriterijum);
            };

            ucPretraga.dgvPretrazi.CellDoubleClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    var selektovan = ucPretraga.dgvPretrazi.Rows[e.RowIndex].DataBoundItem as KupacMV;

                    if (selektovan != null)
                    {
                        PrikaziDetaljeKupca(selektovan.IdKupac);
                    }
                }
            };

            return ucPretraga;
        }

        private void PretraziKupceURealnomVremenu(UCPretraziKupca ucPretraga, string kriterijum)
        {
            try
            {
                List<Kupac>? kupci = Komunikacija.Instance.VratiKupcePoNazivuMesta(kriterijum);

                if (kupci == null || kupci.Count == 0)
                {
                    ucPretraga.dgvPretrazi.DataSource = null;
                    var praznaLista = new List<object> { new { Poruka = "Nema rezultata pretrage" } };
                    ucPretraga.dgvPretrazi.DataSource = praznaLista;
                    return;
                }

                var prikazKupaca = kupci.Select(k => new KupacMV
                {
                    IdKupac = k.IdKupac,
                    ImePrezime = k.Naziv,
                    Telefon = k.Telefon,
                    Email = k.Email,
                    Mesto = k.Mesto?.ToString() ?? ""
                }).ToList();

                ucPretraga.dgvPretrazi.DataSource = prikazKupaca;

                KupacMV.PodesiKolone(ucPretraga.dgvPretrazi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri pretrazi: {ex.Message}");
            }
        }

   


        private void PrikaziDetaljeKupca(int idKupac)
        {
            try
            {
                Kupac? kupac = Komunikacija.Instance.VratiKupcaPoId(idKupac);

                if (kupac != null)
                {
                    UCPrikaziKupca ucPrikaz = PopuniPodatkePrikaz(kupac);
                    MainCoordinator.Instance.ShowPanel(ucPrikaz);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ne mogu da učitam detalje kupca! " + ex.Message);
            }
        }

        private UCPrikaziKupca PopuniPodatkePrikaz(Kupac kupac)
        {
            UCPrikaziKupca ucPrikaz = new UCPrikaziKupca();
            errorProvider = new ErrorProvider();

            ucPrikaz.txtIme.Text = kupac.Naziv;
            ucPrikaz.txtTelefon.Text = kupac.Telefon;
            ucPrikaz.txtEmail.Text = kupac.Email;

            if (kupac.Mesto != null)
            {
                ucPrikaz.txtNaziv.Text = kupac.Mesto.Naziv;
                ucPrikaz.txtPostanski.Text = kupac.Mesto.PostanskiBroj.ToString();
            }

            ucPrikaz.txtIme.Enabled = false;
            ucPrikaz.txtTelefon.Enabled = false;
            ucPrikaz.txtEmail.Enabled = false;
            ucPrikaz.txtNaziv.Enabled = false;
            ucPrikaz.txtPostanski.Enabled = false;

            ucPrikaz.btnSacuvaj.Visible = false;
            ucPrikaz.btnIzmeni.Visible = true;
            ucPrikaz.btnObrisi.Visible = true;

            ucPrikaz.Tag = kupac;

            ucPrikaz.txtIme.TextChanged += (s, e) => ObrisiGresku(ucPrikaz.txtIme);
            ucPrikaz.txtTelefon.TextChanged += (s, e) => ObrisiGresku(ucPrikaz.txtTelefon);
            ucPrikaz.txtEmail.TextChanged += (s, e) => ObrisiGresku(ucPrikaz.txtEmail);
            ucPrikaz.txtNaziv.TextChanged += (s, e) => ObrisiGresku(ucPrikaz.txtNaziv);
            ucPrikaz.txtPostanski.TextChanged += (s, e) => ObrisiGresku(ucPrikaz.txtPostanski);

            ucPrikaz.btnIzmeni.Click += (sender, e) => OmoguciIzmenu(ucPrikaz, true);
            ucPrikaz.btnSacuvaj.Click += (sender, e) => SacuvajIzmeneKupca(ucPrikaz);
            ucPrikaz.btnObrisi.Click += (sender, e) => ObrisiKupca(ucPrikaz);

            return ucPrikaz;
        }

        private void OmoguciIzmenu(UCPrikaziKupca ucPrikaz, bool omoguceno)
        {
            ucPrikaz.txtIme.Enabled = omoguceno;
            ucPrikaz.txtTelefon.Enabled = omoguceno;
            ucPrikaz.txtEmail.Enabled = omoguceno;
            ucPrikaz.txtNaziv.Enabled = omoguceno;
            ucPrikaz.txtPostanski.Enabled = omoguceno;

            ucPrikaz.btnIzmeni.Visible = !omoguceno;
            ucPrikaz.btnObrisi.Visible = !omoguceno;
            ucPrikaz.btnSacuvaj.Visible = omoguceno;

            if (omoguceno)
            {
                ObrisiGresku(ucPrikaz.txtIme);
                ObrisiGresku(ucPrikaz.txtEmail);
                ObrisiGresku(ucPrikaz.txtTelefon);
                ObrisiGresku(ucPrikaz.txtPostanski);
                ObrisiGresku(ucPrikaz.txtNaziv);
            }
        }

        private void SacuvajIzmeneKupca(UCPrikaziKupca ucPrikaz)
        {
            if (!ValidirajKupca(ucPrikaz.txtIme, ucPrikaz.txtEmail, ucPrikaz.txtTelefon, ucPrikaz.txtNaziv, ucPrikaz.txtPostanski))
            {
                return;
            }

            try
            {
                Kupac? originalni = (Kupac?)ucPrikaz.Tag;

                if (originalni == null)
                {
                    MessageBox.Show("Nema podataka o kupcu!");
                    return;
                }

                Kupac azuriran = new Kupac()
                {
                    IdKupac = originalni.IdKupac,
                    Naziv = ucPrikaz.txtIme.Text,
                    Telefon = ucPrikaz.txtTelefon.Text,
                    Email = ucPrikaz.txtEmail.Text,
                    Mesto = new Mesto()
                    {
                        IdMesto = originalni.Mesto?.IdMesto ?? 0,
                        Naziv = ucPrikaz.txtNaziv.Text,
                        PostanskiBroj = ucPrikaz.txtPostanski.Text
                    }
                };

                Komunikacija.Instance.AzurirajKupac(azuriran);
                MessageBox.Show("Podaci o kupcu su uspešno ažurirani!");

                OmoguciIzmenu(ucPrikaz, false);
                ucPrikaz.Tag = azuriran;

                MainCoordinator.Instance.ShowPanel(PretraziKupca() as UCPretraziKupca);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri ažuriranju: " + ex.Message);
            }
        }

        private void ObrisiKupca(UCPrikaziKupca ucPrikaz)
        {
            var result = MessageBox.Show("Da li ste sigurni da želite da obrišete ovog kupca?",
                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Kupac? kupac = (Kupac?)ucPrikaz.Tag;

                    if (kupac == null)
                    {
                        MessageBox.Show("Nema podataka o kupcu!");
                        return;
                    }

                    Komunikacija.Instance.ObrisiKupac(kupac.IdKupac);
                    MessageBox.Show("Kupac je uspešno obrisan!");

                    MainCoordinator.Instance.ShowPanel(PretraziKupca() as UCPretraziKupca);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri brisanju: " + ex.Message);
                }
            }
        }
    }
}