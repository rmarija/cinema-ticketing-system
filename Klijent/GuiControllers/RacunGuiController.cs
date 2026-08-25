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
    internal class RacunGuiController
    {
        private static RacunGuiController instance;
        public static RacunGuiController Instance
        {
            get
            {
                if (instance == null) instance = new RacunGuiController();
                return instance;
            }
        }
        private RacunGuiController() { }

        private UCDodajRacun ucDodajRacun;
        private List<StavkaRacuna> stavkeRacuna = new List<StavkaRacuna>();

        internal class TagPodaci
        {
            public Racun Racun { get; set; }
            public List<StavkaRacuna> Stavke { get; set; }
        }

        internal Control KreirajRacun()
        {
            ucDodajRacun = new UCDodajRacun();
            SrediFormuKreiraj();

            ucDodajRacun.btnDodaj.Click += DodajStavku;
            ucDodajRacun.btnObrisi.Click += ObrisiStavku;
            ucDodajRacun.btnSacuvaj.Click += SacuvajRacun;
            ucDodajRacun.cbProjekcija.SelectedIndexChanged += CbProjekcija_SelectedIndexChanged;

            ucDodajRacun.numKolicina.ValueChanged += AzurirajPreview;
            ucDodajRacun.cbProjekcija.SelectedIndexChanged += AzurirajPreview;

            return ucDodajRacun;
        }

        private void SrediFormuKreiraj()
        {
            try
            {
                ucDodajRacun.cbKupac.DataSource = Komunikacija.Instance.VratiListuSviKupac();
                ucDodajRacun.cbKupac.SelectedIndex = -1;

                ucDodajRacun.cbProdavac.DataSource = Komunikacija.Instance.VratiSviProdavac();
                ucDodajRacun.cbProdavac.SelectedIndex = -1;

                ucDodajRacun.cbProjekcija.DataSource = Komunikacija.Instance.VratiListuSviKarta();
                ucDodajRacun.cbProjekcija.SelectedIndex = -1;

                ucDodajRacun.btnObrisi.Enabled = false;
                ucDodajRacun.cbNacinPlacanja.SelectedIndex = -1;
                ucDodajRacun.dtpDatumProdaje.Value = DateTime.Now;
                ucDodajRacun.dtpDatumCekiranja.Value = DateTime.Now;
                ucDodajRacun.lblCena.Text = "0.00 RSD";

                OsveziTabeluKreiraj();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem ne može da kreira račun!");
            }
        }

        private void CbProjekcija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox cb && cb.SelectedItem is Karta izabranaKarta)
            {
                if (cb.Parent is UCDodajRacun) ucDodajRacun.lblCena.Text = izabranaKarta.Cena.ToString("N2") + " RSD";
            }
        }

        private void DodajStavku(object sender, EventArgs e)
        {
            if (ucDodajRacun.cbProjekcija.SelectedIndex == -1) return;

            Karta izabranaKarta = (Karta)ucDodajRacun.cbProjekcija.SelectedItem;
            int kolicina = (int)ucDodajRacun.numKolicina.Value;
            double cena = izabranaKarta.Cena;

            StavkaRacuna postojecaStavka = stavkeRacuna.FirstOrDefault(s => s.Karta.IdKarta == izabranaKarta.IdKarta);

            if (postojecaStavka != null) postojecaStavka.Kolicina += kolicina;
            else
            {
                stavkeRacuna.Add(new StavkaRacuna { Karta = izabranaKarta, Kolicina = kolicina, Cena = cena });
            }

            OsveziTabeluKreiraj();
            ucDodajRacun.cbProjekcija.SelectedIndex = -1;
            ucDodajRacun.numKolicina.Value = 1;
            ucDodajRacun.lblCena.Text = "0.00 RSD";
        }

        private void ObrisiStavku(object sender, EventArgs e)
        {
            if (ucDodajRacun.dgvStavke.SelectedRows.Count > 0)
            {
                int index = ucDodajRacun.dgvStavke.SelectedRows[0].Index;
                stavkeRacuna.RemoveAt(index);
                OsveziTabeluKreiraj();
            }
        }

        private void OsveziTabeluKreiraj()
        {
            ucDodajRacun.dgvStavke.DataSource = null;

            ucDodajRacun.dgvStavke.DataSource = stavkeRacuna.Select(s => new StavkaRacunaMV
            {
                Projekcija = s.Karta.ToString(),
                Kolicina = s.Kolicina,
                Cena = s.Cena,
                Iznos = s.Kolicina * s.Cena
            }).ToList();

            if (ucDodajRacun.dgvStavke.Columns.Count > 0)
            {
                ucDodajRacun.dgvStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (ucDodajRacun.dgvStavke.Columns["Projekcija"] != null)
                    ucDodajRacun.dgvStavke.Columns["Projekcija"].FillWeight = 200; 

                if (ucDodajRacun.dgvStavke.Columns["Kolicina"] != null)
                    ucDodajRacun.dgvStavke.Columns["Kolicina"].FillWeight = 60;

                if (ucDodajRacun.dgvStavke.Columns["Cena"] != null)
                {
                    ucDodajRacun.dgvStavke.Columns["Cena"].FillWeight = 80;
                    ucDodajRacun.dgvStavke.Columns["Cena"].DefaultCellStyle.Format = "N2";
                }

                if (ucDodajRacun.dgvStavke.Columns["Iznos"] != null)
                {
                    ucDodajRacun.dgvStavke.Columns["Iznos"].FillWeight = 80;
                    ucDodajRacun.dgvStavke.Columns["Iznos"].DefaultCellStyle.Format = "N2";
                }
            }

            double ukupanIznos = stavkeRacuna.Sum(s => s.Kolicina * s.Cena);
            ucDodajRacun.lblUkupanIznos.Text = $"{ukupanIznos:N2} RSD";
            ucDodajRacun.btnObrisi.Enabled = stavkeRacuna.Count > 0;
        }

        private void AzurirajPreview(object sender, EventArgs e)
        {
            double zbirDodatih = stavkeRacuna.Sum(s => s.Kolicina * s.Cena);
            double previewIznos = 0;

            if (ucDodajRacun.cbProjekcija.SelectedItem is Karta izabranaKarta)
            {
                int kolicina = (int)ucDodajRacun.numKolicina.Value;
                previewIznos = izabranaKarta.Cena * kolicina;
            }

            ucDodajRacun.lblUkupanIznos.Text = $"{(zbirDodatih + previewIznos):N2} RSD";
        }

        private void SacuvajRacun(object sender, EventArgs e)
        {
            if (ucDodajRacun.cbKupac.SelectedIndex == -1 || ucDodajRacun.cbProdavac.SelectedIndex == -1
               || ucDodajRacun.cbNacinPlacanja.SelectedIndex == -1 || stavkeRacuna.Count == 0)
            {
                MessageBox.Show("Popunite sva polja i unesite bar jednu stavku!");
                return;
            }

            DateTime datumProdaje = ucDodajRacun.dtpDatumProdaje.Value;
            DateTime datumCekiranja = ucDodajRacun.dtpDatumCekiranja.Value;

            if (datumCekiranja < datumProdaje)
            {
                MessageBox.Show("Datum čekiranja mora biti veći ili jednak datumu prodaje!");
                return;
            }

            foreach (var stavka in stavkeRacuna)
            {
                if (datumProdaje > stavka.Karta.DatumVremeProjekcije)
                {
                    MessageBox.Show($"Datum prodaje ne može biti nakon datuma projekcije za film {stavka.Karta.NazivFilma}!");
                    return;
                }
            }

            Racun racun = new Racun
            {
                DatumProdaje = ucDodajRacun.dtpDatumProdaje.Value,
                DatumCekiranja = ucDodajRacun.dtpDatumCekiranja.Value,
                Kupac = (Kupac)ucDodajRacun.cbKupac.SelectedItem,
                Prodavac = (Prodavac)ucDodajRacun.cbProdavac.SelectedItem,
                Stavke = new List<StavkaRacuna>(stavkeRacuna),
                UkupanIznos = stavkeRacuna.Sum(s => s.Kolicina * s.Cena),
                NacinPlacanja = ucDodajRacun.cbNacinPlacanja.SelectedItem?.ToString()
            };

            try
            {
                Komunikacija.Instance.SacuvajRacun(racun);
                MessageBox.Show("Račun uspešno sačuvan!");
                stavkeRacuna.Clear();
                OsveziTabeluKreiraj();
                ucDodajRacun.cbKupac.SelectedIndex = -1;
                ucDodajRacun.cbProjekcija.SelectedIndex = -1;
                ucDodajRacun.lblCena.Text = "0.00 RSD";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Greška: " + ex.Message);
                MessageBox.Show("Sistem ne može da zapamti račun!");
            }
        }

        internal Control PretraziRacun()
        {
            UCPretraziRacun ucPretraga = new UCPretraziRacun();

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
                PretraziURealnomVremenu(ucPretraga, kriterijum);
            };

            ucPretraga.dgvPretrazi.CellDoubleClick += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    var selektovan = ucPretraga.dgvPretrazi.Rows[e.RowIndex].DataBoundItem as RacunPretragaMV;
                    if (selektovan != null) PrikaziDetaljeRacuna(selektovan.IdRacun);
                }
            };

            return ucPretraga;
        }

        private void PretraziURealnomVremenu(UCPretraziRacun ucPretraga, string kriterijum)
        {
            try
            {
                List<Racun> racuni = Komunikacija.Instance.VratiRacunPoProdavcu(kriterijum);

                if (racuni == null || racuni.Count == 0)
                {
                    ucPretraga.dgvPretrazi.DataSource = new List<object> { new { Poruka = "Nema rezultata pretrage" } };
                    return;
                }

                var prikazRacuna = racuni.Select(r => new RacunPretragaMV
                {
                    IdRacun = r.IdRacun,
                    DatumProdaje = r.DatumProdaje,
                    DatumCekiranja = r.DatumCekiranja,
                    NacinPlacanja = r.NacinPlacanja,
                    Kupac = r.Kupac?.ToString(),
                    Prodavac = r.Prodavac?.ToString(),
                    BrojStavki = r.Stavke?.Count ?? 0,
                    UkupanIznos = r.UkupanIznos
                }).ToList();

                ucPretraga.dgvPretrazi.DataSource = prikazRacuna;
                RacunPretragaMV.PodesiKolone(ucPretraga.dgvPretrazi);


                ucPretraga.dgvPretrazi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri pretrazi: {ex.Message}");
            }
        }


        private void PrikaziDetaljeRacuna(int idRacun)
        {

            try
            {
                Racun racun = Komunikacija.Instance.VratiRacunPoId(idRacun);
                if (racun != null)
                {
                    UCPrikaziRacun ucPrikaz = PopuniPodatke(racun);
                    MainCoordinator.Instance.ShowPanel(ucPrikaz);
                }
                else
                {
                    MessageBox.Show("Sistem ne može da nađe račun!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ne mogu da učitam detalje računa! " + ex.Message);
            }
        }

        private UCPrikaziRacun PopuniPodatke(Racun racun)
        {
            UCPrikaziRacun ucPrikaz = new UCPrikaziRacun();
            List<StavkaRacuna> stavkeIzmena = new List<StavkaRacuna>(racun.Stavke);
            StavkaRacuna stavkaZaIzmenu = null;

            try
            {
                ucPrikaz.cbKupac.DataSource = Komunikacija.Instance.VratiListuSviKupac();
                ucPrikaz.cbProdavac.DataSource = Komunikacija.Instance.VratiSviProdavac();
                ucPrikaz.cbProjekcija.DataSource = Komunikacija.Instance.VratiListuSviKarta();
            }
            catch (Exception ex) { MessageBox.Show("Greška: " + ex.Message); }

            foreach (Kupac k in ucPrikaz.cbKupac.Items)
                if (k.IdKupac == racun.Kupac.IdKupac) { ucPrikaz.cbKupac.SelectedItem = k; break; }

            foreach (Prodavac p in ucPrikaz.cbProdavac.Items)
                if (p.IdProdavac == racun.Prodavac.IdProdavac) { ucPrikaz.cbProdavac.SelectedItem = p; break; }

            ucPrikaz.dtpDatumProdaje.Value = racun.DatumProdaje;
            ucPrikaz.dtpDatumCekiranja.Value = racun.DatumCekiranja;
            ucPrikaz.cbProjekcija.SelectedIndex = -1;

            void OsveziTabeluIzmena()
            {
                ucPrikaz.dgvStavke.DataSource = null;
                ucPrikaz.dgvStavke.DataSource = stavkeIzmena.Select(s => new StavkaRacunaMV
                {
                    Projekcija = s.Karta.ToString(),
                    Kolicina = s.Kolicina,
                    Cena = s.Cena,
                    Iznos = s.Kolicina * s.Cena
                }).ToList();

                if (ucPrikaz.dgvStavke.Columns.Count > 0)
                {
                    ucPrikaz.dgvStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (ucPrikaz.dgvStavke.Columns["Projekcija"] != null)
                        ucPrikaz.dgvStavke.Columns["Projekcija"].FillWeight = 200;

                    if (ucPrikaz.dgvStavke.Columns["Kolicina"] != null)
                        ucPrikaz.dgvStavke.Columns["Kolicina"].FillWeight = 60;

                    if (ucPrikaz.dgvStavke.Columns["Cena"] != null)
                    {
                        ucPrikaz.dgvStavke.Columns["Cena"].FillWeight = 80;
                        ucPrikaz.dgvStavke.Columns["Cena"].DefaultCellStyle.Format = "N2";
                    }

                    if (ucPrikaz.dgvStavke.Columns["Iznos"] != null)
                    {
                        ucPrikaz.dgvStavke.Columns["Iznos"].FillWeight = 80;
                        ucPrikaz.dgvStavke.Columns["Iznos"].DefaultCellStyle.Format = "N2";
                    }
                }

                double ukupno = stavkeIzmena.Sum(s => s.Kolicina * s.Cena);
                ucPrikaz.lblUkupanIznos.Text = $"{ukupno:N2} RSD";
                ucPrikaz.btnObrisi.Enabled = stavkeIzmena.Count > 0;

            }



            ucPrikaz.dgvStavke.CellClick += (s, e) =>
            {
                if (e.RowIndex < 0 || e.RowIndex >= stavkeIzmena.Count) return;

                StavkaRacuna stavka = stavkeIzmena[e.RowIndex];
                stavkaZaIzmenu = stavka;

                foreach (Karta k in ucPrikaz.cbProjekcija.Items)
                    if (k.IdKarta == stavka.Karta.IdKarta) { ucPrikaz.cbProjekcija.SelectedItem = k; break; }

                ucPrikaz.numKolicina.Value = stavka.Kolicina;
            };

            void AzurirajPreviewIzmena()
            {
                double zbirDodatih = stavkeIzmena.Sum(s => s.Kolicina * s.Cena);

                if (ucPrikaz.cbProjekcija.SelectedItem is Karta izabranaKarta)
                {
                    int kolicina = (int)ucPrikaz.numKolicina.Value;
                    double previewIznos = izabranaKarta.Cena * kolicina;

                    StavkaRacuna postojeca = stavkeIzmena.FirstOrDefault(st => st.Karta.IdKarta == izabranaKarta.IdKarta);
                    if (postojeca != null)
                        zbirDodatih -= postojeca.Kolicina * postojeca.Cena;   

                    zbirDodatih += previewIznos;                
                }

                ucPrikaz.lblUkupanIznos.Text = $"{zbirDodatih:N2} RSD";
            }

            void PrimeniIzmenuStavke()
            {
                if (!(ucPrikaz.cbProjekcija.SelectedItem is Karta izabranaKarta)) return;

                int kolicina = (int)ucPrikaz.numKolicina.Value;
                double cena = izabranaKarta.Cena;


                if (stavkaZaIzmenu != null && stavkaZaIzmenu.Karta.IdKarta != izabranaKarta.IdKarta)
                {
                    int indeksZaUklanjanje = stavkeIzmena.FindIndex(st => ReferenceEquals(st, stavkaZaIzmenu));
                    if (indeksZaUklanjanje >= 0) stavkeIzmena.RemoveAt(indeksZaUklanjanje);
                }

                StavkaRacuna postojeca = stavkeIzmena.FirstOrDefault(st => st.Karta.IdKarta == izabranaKarta.IdKarta);
                if (postojeca != null) postojeca.Kolicina = kolicina;
                else stavkeIzmena.Add(new StavkaRacuna { Karta = izabranaKarta, Kolicina = kolicina, Cena = cena });

                stavkaZaIzmenu = null;  

                OsveziTabeluIzmena();
                ucPrikaz.cbProjekcija.SelectedIndex = -1;
                ucPrikaz.lblCena.Text = "0.00 RSD";
                ucPrikaz.numKolicina.Value = 1;
            }



            OsveziTabeluIzmena();

            ucPrikaz.cbProjekcija.SelectedIndexChanged += (s, e) =>
            {
                if (ucPrikaz.cbProjekcija.SelectedItem is Karta izabranaKarta)
                    ucPrikaz.lblCena.Text = izabranaKarta.Cena.ToString("N2") + " RSD";
                ucPrikaz.numKolicina.Value = 1;
                AzurirajPreviewIzmena();
            };

            ucPrikaz.numKolicina.ValueChanged += (s, e) => AzurirajPreviewIzmena();

            ucPrikaz.btnDodaj.Click += (s, e) => PrimeniIzmenuStavke();

            ucPrikaz.btnObrisi.Click += (s, e) =>
            {
                if (ucPrikaz.dgvStavke.SelectedRows.Count == 0) return;

                int index = ucPrikaz.dgvStavke.SelectedRows[0].Index;
                stavkeIzmena.RemoveAt(index);
                stavkaZaIzmenu = null;
                OsveziTabeluIzmena();

                ucPrikaz.cbProjekcija.SelectedIndex = -1;
                ucPrikaz.lblCena.Text = "0.00 RSD";
            };


            OmoguciIzmenu(ucPrikaz, false);
            ucPrikaz.Tag = new TagPodaci { Racun = racun, Stavke = stavkeIzmena };

            ucPrikaz.btnIzmeni.Click += (s, e) => OmoguciIzmenu(ucPrikaz, true);
            ucPrikaz.btnSacuvaj.Click += (s, e) =>
            {
                PrimeniIzmenuStavke();
                SacuvajIzmene(ucPrikaz);
            };

            return ucPrikaz;
        }

        private void OmoguciIzmenu(UCPrikaziRacun ucPrikaz, bool omoguceno)
        {
          //  ucPrikaz.dtpDatumProdaje.Enabled = omoguceno;
            ucPrikaz.dtpDatumCekiranja.Enabled = omoguceno;
            ucPrikaz.cbKupac.Enabled = omoguceno;
           // ucPrikaz.cbProdavac.Enabled = omoguceno;
            ucPrikaz.cbProjekcija.Enabled = omoguceno;
            ucPrikaz.numKolicina.Enabled = omoguceno;
            ucPrikaz.cbNacinPlacanja.Enabled = omoguceno;
            ucPrikaz.btnObrisi.Visible = omoguceno;

            ucPrikaz.btnDodaj.Visible = omoguceno;
            ucPrikaz.btnIzmeni.Visible = !omoguceno;
            ucPrikaz.btnSacuvaj.Visible = omoguceno;

            ucPrikaz.dgvStavke.ReadOnly = !omoguceno;
        }

        private void SacuvajIzmene(UCPrikaziRacun ucPrikaz)
        {
            TagPodaci podaci = (TagPodaci)ucPrikaz.Tag;
            Racun original = podaci.Racun;

            if (ucPrikaz.cbKupac.SelectedIndex == -1 || ucPrikaz.cbNacinPlacanja.SelectedIndex == -1
                || podaci.Stavke.Count == 0)
            {
                MessageBox.Show("Popunite sva polja i unesite bar jednu stavku!");
                return;
            }

            DateTime datumProdaje = ucPrikaz.dtpDatumProdaje.Value;
            DateTime datumCekiranja = ucPrikaz.dtpDatumCekiranja.Value;

            if (datumCekiranja < datumProdaje)
            {
                MessageBox.Show("Datum čekiranja mora biti veći ili jednak datumu prodaje!");
                return;
            }

            foreach (var stavka in podaci.Stavke)
            {
                if (datumProdaje > stavka.Karta.DatumVremeProjekcije)
                {
                    MessageBox.Show($"Datum prodaje ne može biti nakon datuma projekcije za film {stavka.Karta.NazivFilma}!");
                    return;
                }
            }

            Racun azuriran = new Racun
            {
                IdRacun = original.IdRacun,
                DatumProdaje = ucPrikaz.dtpDatumProdaje.Value,
                DatumCekiranja = ucPrikaz.dtpDatumCekiranja.Value,
                Kupac = (Kupac)ucPrikaz.cbKupac.SelectedItem,
                Prodavac = (Prodavac)ucPrikaz.cbProdavac.SelectedItem,
                NacinPlacanja = ucPrikaz.cbNacinPlacanja.SelectedItem?.ToString() ?? original.NacinPlacanja,
                UkupanIznos = podaci.Stavke.Sum(s => s.Kolicina * s.Cena),
                Stavke = podaci.Stavke
            };

            try
            {
                Komunikacija.Instance.AzurirajRacun(azuriran);
                MessageBox.Show("Račun je uspešno ažuriran!");
                OmoguciIzmenu(ucPrikaz, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska pri azuriranju racuna!");
            }
        }
    }
}