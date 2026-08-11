using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klijent.ModelView
{
    internal class RacunPretragaMV
    {
        public int IdRacun { get; set; }
        public DateTime DatumProdaje { get; set; }
        public DateTime DatumCekiranja { get; set; }
        public string NacinPlacanja { get; set; }
        public double UkupanIznos { get; set; }
        public int BrojStavki { get; set; }
        public string Kupac { get; set; }
        public string Prodavac { get; set; }

    }
}
