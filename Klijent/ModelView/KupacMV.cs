using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent.ModelView
{
    internal class KupacMV
    {
        public int IdKupac { get; set; }
        public string ImePrezime { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Mesto { get; set; }

        public static void PodesiKolone(DataGridView dgvPretrazi)
        {
            if (dgvPretrazi.Columns.Count == 0) return;

            if (dgvPretrazi.Columns["IdKupac"] != null)
            {
                dgvPretrazi.Columns["IdKupac"].Visible = false;
            }

            if (dgvPretrazi.Columns.Contains("Poruka"))
            {
                dgvPretrazi.Columns["Poruka"].HeaderText = "";
                return;
            }

            if (dgvPretrazi.Columns["ImePrezime"] != null)
            {
                dgvPretrazi.Columns["ImePrezime"].HeaderText = "Ime i prezime";
                dgvPretrazi.Columns["ImePrezime"].Width = 130;
            }

            if (dgvPretrazi.Columns["Telefon"] != null)
            {
                dgvPretrazi.Columns["Telefon"].HeaderText = "Telefon";
                dgvPretrazi.Columns["Telefon"].Width = 120;
            }

            if (dgvPretrazi.Columns["Email"] != null)
            {
                dgvPretrazi.Columns["Email"].HeaderText = "Email";
                dgvPretrazi.Columns["Email"].Width = 150;
            }

            if (dgvPretrazi.Columns["Mesto"] != null)
            {
                dgvPretrazi.Columns["Mesto"].HeaderText = "Mesto";
                dgvPretrazi.Columns["Mesto"].Width = 150;
            }
        }
    }

  
}
