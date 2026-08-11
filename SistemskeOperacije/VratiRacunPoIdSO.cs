using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
namespace SistemskeOperacije
{
    public class VratiRacunPoIdSO : BaseSO
    {
        private int idRacun;
        public Racun Result { get; set; }
        public VratiRacunPoIdSO(int idRacun)
        {
            this.idRacun = idRacun;
        }
        protected override void ExecuteConcreteOperation()
        {
            string queryRacun = @"SELECT r.idRacun, r.datumProdaje, r.datumCekiranja, r.ukupanIznos, r.nacinPlacanja,
                             p.idProdavac, p.ime, p.prezime,
                             k.idKupac, k.naziv as kupacNaziv
                      FROM Racun r
                      INNER JOIN Prodavac p ON r.idProdavac = p.idProdavac
                      INNER JOIN Kupac k ON r.idKupac = k.idKupac
                      WHERE r.idRacun = " + idRacun;
            Racun r = new Racun();
            List<IEntity> result = broker.GetByQuery(r, queryRacun);
            if (result.Count > 0)
            {
                Result = (Racun)result[0];
                string queryStavke = @"SELECT sr.idRacun, sr.rb, sr.kolicina, sr.cena, sr.iznos,
                     ka.idKarta, ka.nazivFilma as kartaNaziv, ka.sala as kartaSala, 
                     ka.datumVremeProjekcije as kartaDatum, ka.cena as kartaCena
                  FROM StavkaRacuna sr
                  INNER JOIN Karta ka ON sr.idKarta = ka.idKarta
                  WHERE sr.idRacun = " + idRacun;
                StavkaRacuna stavkaModel = new StavkaRacuna();
                List<IEntity> stavkeResult = broker.GetByQuery(stavkaModel, queryStavke);
                Result.Stavke = stavkeResult.Cast<StavkaRacuna>().ToList();
            }
        }
    }
}