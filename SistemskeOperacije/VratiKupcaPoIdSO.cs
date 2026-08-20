using System.Collections.Generic;
using System.Linq;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class VratiKupcaPoIdSO : BaseSO
    {
        private int idKupac;
        public Kupac Result { get; set; }

        public VratiKupcaPoIdSO(int idKupac)
        {
            this.idKupac = idKupac;
        }

        protected override void ExecuteConcreteOperation()
        {
            
            string query = $@"SELECT k.idKupac, k.naziv, k.email, k.telefon,
                              m.idMesto, m.naziv as mestoNaziv, m.postanskiBroj
                              FROM Kupac k
                              INNER JOIN Mesto m ON k.idMesto = m.idMesto
                              WHERE k.idKupac = {idKupac}";

            Kupac kupacModel = new Kupac();
            List<IEntity> result = broker.GetByQuery(kupacModel, query);

            if (result.Count > 0)
            {
                Result = (Kupac)result[0];
            }
        }
    }
}