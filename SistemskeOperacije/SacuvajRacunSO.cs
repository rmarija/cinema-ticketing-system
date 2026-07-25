using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class SacuvajRacunSO : BaseSO
    {
        private Racun racun;

        public SacuvajRacunSO(Racun racun)
        {
            this.racun = racun;
        }

        protected override void ExecuteConcreteOperation()
        {
            int idRacuna = broker.AddWithId(racun);
            racun.IdRacun = idRacuna;

            foreach (var stavka in racun.Stavke)
            {
                stavka.Racun = racun;
                broker.Add(stavka);
            }
        }
    }
}