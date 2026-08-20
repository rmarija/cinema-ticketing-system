using System;
using System.ComponentModel;

namespace Klijent.ModelView
{
    internal class RacunPretragaMV
    {
        [DisplayName("Broj računa")]
        public int IdRacun { get; set; }

        [DisplayName("Datum prodaje")]
        public DateTime DatumProdaje { get; set; }

        [DisplayName("Datum čekiranja")]
        public DateTime DatumCekiranja { get; set; }

        [DisplayName("Način plaćanja")]
        public string NacinPlacanja { get; set; }

        [DisplayName("Ukupan iznos")]
        public double UkupanIznos { get; set; }

        [DisplayName("Broj stavki")]
        public int BrojStavki { get; set; }

        [DisplayName("Kupac")]
        public string Kupac { get; set; }

        [DisplayName("Prodavac")]
        public string Prodavac { get; set; }

        public static void PodesiKolone(DataGridView dgv)
        {
            if (dgv.Columns["IdRacun"] != null)
                dgv.Columns["IdRacun"].Visible = false;

            if (dgv.Columns["DatumProdaje"] != null)
                dgv.Columns["DatumProdaje"].DefaultCellStyle.Format = "dd.MM.yyyy. HH:mm";

            if (dgv.Columns["DatumCekiranja"] != null)
                dgv.Columns["DatumCekiranja"].DefaultCellStyle.Format = "dd.MM.yyyy. HH:mm";

            if (dgv.Columns["UkupanIznos"] != null)
                dgv.Columns["UkupanIznos"].DefaultCellStyle.Format = "N2";

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}