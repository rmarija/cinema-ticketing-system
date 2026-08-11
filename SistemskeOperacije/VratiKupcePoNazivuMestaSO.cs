using System.Collections.Generic;
using System.Linq;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class VratiKupcePoNazivuMestaSO : BaseSO
    {
        private string nazivMesta;
        public List<Kupac> Result { get; set; }

        public VratiKupcePoNazivuMestaSO(string nazivMesta)
        {
            this.nazivMesta = nazivMesta;
        }

        protected override void ExecuteConcreteOperation()
        {
            string bezbedanNaziv = nazivMesta.Replace("'", "''");
            string query = $@"SELECT k.idKupac, k.naziv, k.email, k.telefon,
                              m.idMesto, m.naziv as mestoNaziv, m.postanskiBroj
                              FROM Kupac k
                              INNER JOIN Mesto m ON k.idMesto = m.idMesto
                              WHERE m.naziv LIKE '{bezbedanNaziv}%'";
            Kupac kupacModel = new Kupac();
            List<IEntity> result = broker.GetByQuery(kupacModel, query);
            Result = result.Cast<Kupac>().ToList();
        }
    }
}