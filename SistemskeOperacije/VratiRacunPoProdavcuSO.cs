using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class VratiRacunPoProdavcuSO : BaseSO
    {
        private string kriterijum;
        public List<Racun> Result { get; set; }

        public VratiRacunPoProdavcuSO(string kriterijum)
        {
            this.kriterijum = kriterijum;
        }

        protected override void ExecuteConcreteOperation()
        {
            string k = kriterijum.Replace("'", "''");

            string query = $@"SELECT r.idRacun, r.datum, r.ukupnaCena,
                                     p.idProdavac, p.ime, p.prezime,
                                     k.idKupac, k.naziv as kupacNaziv
                              FROM Racun r
                              INNER JOIN Prodavac p ON r.idProdavac = p.idProdavac
                              INNER JOIN Kupac k ON r.idKupac = k.idKupac
                              WHERE p.ime LIKE '%{k}%' OR p.prezime LIKE '%{k}%' OR p.ime + ' ' + p.prezime LIKE '%{k}%'
                              ORDER BY r.datum DESC";

            Racun racunModel = new Racun();
            List<IEntity> result = broker.GetByQuery(racunModel, query);

            List<Racun> racuni = result.Cast<Racun>().ToList();

            foreach (var racun in racuni)
            {
                string queryStavke = $@"SELECT sr.rb, sr.kolicina, sr.cena, sr.iznos,
                                             ka.idKarta, ka.naziv as kartaNaziv
                                      FROM StavkaRacuna sr
                                      INNER JOIN Karta ka ON sr.idKarta = ka.idKarta
                                      WHERE sr.idRacun = {racun.IdRacun}";

                StavkaRacuna stavkaModel = new StavkaRacuna();
                List<IEntity> stavkeResult = broker.GetByQuery(stavkaModel, queryStavke);
                racun.Stavke = stavkeResult.Cast<StavkaRacuna>().ToList();
            }

            Result = racuni;
        }
    }
}
