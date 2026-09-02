using Microsoft.Data.SqlClient;
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
            string query = @"SELECT r.idRacun, r.datumProdaje, r.datumCekiranja, r.ukupanIznos, r.nacinPlacanja,
             p.idProdavac, p.ime, p.prezime,
             k.idKupac, k.naziv as kupacNaziv
      FROM Racun r
      INNER JOIN Prodavac p ON r.idProdavac = p.idProdavac
      INNER JOIN Kupac k ON r.idKupac = k.idKupac
      WHERE p.ime LIKE @kriterijum OR p.prezime LIKE @kriterijum OR p.ime + ' ' + p.prezime LIKE @kriterijum
      ORDER BY r.datumProdaje DESC";

            SqlParameter[] parametri = new SqlParameter[]
            {
        new SqlParameter("@kriterijum", "%" + kriterijum + "%")
            };

            Racun racunModel = new Racun();
            List<IEntity> result = broker.GetByQuery(racunModel, query, parametri);

            List<Racun> racuni = result.Cast<Racun>().ToList();

            foreach (var racun in racuni)
            {
                string queryStavke = $@"SELECT sr.idRacun, sr.rb, sr.kolicina, sr.cena, sr.iznos,
                     ka.idKarta, ka.nazivFilma as kartaNaziv, ka.sala as kartaSala, 
                     ka.datumVremeProjekcije as kartaDatum, ka.cena as kartaCena
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
