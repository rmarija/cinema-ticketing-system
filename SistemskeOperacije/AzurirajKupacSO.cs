using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using System.Collections.Generic;

namespace SistemskeOperacije
{
    public class AzurirajKupacSO : BaseSO
    {
        private Kupac kupac;

        public AzurirajKupacSO(Kupac kupac)
        {
            this.kupac = kupac;
        }

        protected override void ExecuteConcreteOperation()
        {
            Mesto mesto = kupac.Mesto;

            if (mesto != null)
            {
                string proveraQuery = $"SELECT * FROM Mesto WHERE idMesto = {mesto.IdMesto}";
                List<IEntity> postojeceMesto = broker.GetByQuery(new Mesto(), proveraQuery);

                if (postojeceMesto.Count > 0)
                {
                    Mesto postojece = (Mesto)postojeceMesto[0];
                    kupac.Mesto = postojece;
                }
                else
                {
                    int idMesta = broker.AddWithId(mesto);
                    mesto.IdMesto = idMesta;
                }
            }

            broker.Update(kupac);
        }
    }
}