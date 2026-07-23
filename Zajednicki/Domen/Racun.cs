using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Zajednicki.Domen
{
    public class Racun : IEntity
    {
        public int IdRacun { get; set; }
        public DateTime DatumProdaje { get; set; }
        public DateTime DatumCekiranja { get; set; }
        public string NacinPlacanja { get; set; }
        public double UkupanIznos { get; set; }

        // Povezujemo ostale klase umesto stranih ključeva
        public Prodavac Prodavac { get; set; }
        public Kupac Kupac { get; set; }

        // Ključna stvar: Lista stavki
        public List<StavkaRacuna> Stavke { get; set; } = new List<StavkaRacuna>();

        public string TableName => "Racun";
        public string Values => "@datumProdaje, @datumCekiranja, @nacinPlacanja, @ukupanIznos, @idProdavac, @idKupac";
        public string IdColumnName => "idRacun";
        public object Columns => "datumProdaje, datumCekiranja, nacinPlacanja, ukupanIznos, idProdavac, idKupac";
        public object UpdateValues => "datumProdaje = @datumProdaje, datumCekiranja = @datumCekiranja, nacinPlacanja = @nacinPlacanja, ukupanIznos = @ukupanIznos, idProdavac = @idProdavac, idKupac = @idKupac";

        public override bool Equals(object? obj)
        {
            if (obj is Racun racun)
                return IdRacun == racun.IdRacun;

            return false;
        }

        public SqlParameter[] GetInsertParameters()
        {
            return new SqlParameter[] {
                new SqlParameter("@datumProdaje", DatumProdaje),
                new SqlParameter("@datumCekiranja", DatumCekiranja),
                new SqlParameter("@nacinPlacanja", NacinPlacanja),
                new SqlParameter("@ukupanIznos", UkupanIznos),
                // Uzimamo ID iz objekata
                new SqlParameter("@idProdavac", Prodavac.IdProdavac),
                new SqlParameter("@idKupac", Kupac.IdKupac)
            };
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> racuni = new List<IEntity>();

            while (reader.Read())
            {
                Racun r = new Racun()
                {
                    IdRacun = (int)reader["idRacun"],
                    DatumProdaje = (DateTime)reader["datumProdaje"],
                    DatumCekiranja = (DateTime)reader["datumCekiranja"],
                    NacinPlacanja = (string)reader["nacinPlacanja"],
                    // SQL FLOAT se u C# prevodi u double. 
                    // Bezbednije je koristiti Convert nego (double) kasting.
                    UkupanIznos = Convert.ToDouble(reader["ukupanIznos"]),

                    Prodavac = new Prodavac()
                    {
                        IdProdavac = (int)reader["idProdavac"]
                    },
                    Kupac = new Kupac()
                    {
                        IdKupac = (int)reader["idKupac"]
                    }
                };
                racuni.Add(r);
            }
            return racuni;
        }

        public SqlParameter[] GetUpdateParameters()
        {
            return new SqlParameter[] {
                new SqlParameter("@idRacun", IdRacun),
                new SqlParameter("@datumProdaje", DatumProdaje),
                new SqlParameter("@datumCekiranja", DatumCekiranja),
                new SqlParameter("@nacinPlacanja", NacinPlacanja),
                new SqlParameter("@ukupanIznos", UkupanIznos),
                new SqlParameter("@idProdavac", Prodavac.IdProdavac),
                new SqlParameter("@idKupac", Kupac.IdKupac)
            };
        }
    }
}