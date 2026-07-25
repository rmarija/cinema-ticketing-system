using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class AzurirajRacunSO : BaseSO
    {
        private Racun racun;

        public AzurirajRacunSO(Racun racun)
        {
            this.racun = racun;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Update(racun);

            string deleteQuery = $"delete from StavkaRacuna where idRacun = {racun.IdRacun}";
            broker.GetByQuery(new StavkaRacuna(), deleteQuery);

            foreach (var stavka in racun.Stavke)
            {
                stavka.Racun = racun;
                broker.Add(stavka);
            }
        }
    }
}