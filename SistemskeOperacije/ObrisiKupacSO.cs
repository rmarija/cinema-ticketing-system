using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using System;

namespace SistemskeOperacije
{
    public class ObrisiKupacSO : BaseSO
    {
        private int idKupac;

        public ObrisiKupacSO(int idKupac)
        {
            this.idKupac = idKupac;
        }

        protected override void ExecuteConcreteOperation()
        {

            string proveraQuery = $"SELECT COUNT(*) FROM Racun WHERE idKupac = {idKupac}";
            int brojRacuna = broker.ExecuteScalar(proveraQuery);

            if (brojRacuna > 0)
            {
                throw new Exception("Ne može se obrisati kupac jer ima evidentirane račune u sistemu!");
            }

            Kupac kupac = new Kupac();
            broker.Delete(kupac, idKupac);
        }
    }
}