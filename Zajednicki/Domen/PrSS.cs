using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class PrSS
    {
        public DateOnly DatumSticanja { get; set; }
        public Prodavac Prodavac { get; set; }
        public StrucnaSprema StrucnaSprema { get; set; }
    }
}
