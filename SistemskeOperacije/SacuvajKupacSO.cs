using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using System.Collections.Generic;

namespace SistemskeOperacije
{
    public class SacuvajKupacSO : BaseSO
    {
        private Kupac kupac;

        public SacuvajKupacSO(Kupac kupac)
        {
            this.kupac = kupac;
        }

        protected override void ExecuteConcreteOperation()
        {
            Mesto mesto = kupac.Mesto;

            if (mesto != null)
            {
               
                string query = $"SELECT * FROM Mesto WHERE idMesto = {mesto.IdMesto}";

                List<IEntity> postojeceMesto = broker.GetByQuery(mesto, query);

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

            int id = broker.AddWithId(kupac);
            kupac.IdKupac = id;
        }
    }
}