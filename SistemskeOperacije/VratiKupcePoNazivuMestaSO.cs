using Microsoft.Data.SqlClient;
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
            string query = @"SELECT k.idKupac, k.naziv, k.email, k.telefon,
                      m.idMesto, m.naziv as mestoNaziv, m.postanskiBroj
                      FROM Kupac k
                      INNER JOIN Mesto m ON k.idMesto = m.idMesto
                      WHERE m.naziv LIKE @nazivMesta";

            SqlParameter[] parametri = new SqlParameter[]
            {
        new SqlParameter("@nazivMesta", nazivMesta + "%")
            };

            Kupac kupacModel = new Kupac();
            List<IEntity> result = broker.GetByQuery(kupacModel, query, parametri);
            Result = result.Cast<Kupac>().ToList();
        }
    }
}