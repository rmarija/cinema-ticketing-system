using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Zajednicki.Domen
{
    public class StavkaRacuna : IEntity
    {
        public Racun Racun { get; set; }
        public int Rb { get; set; }
        public int Kolicina { get; set; }
        public double Cena { get; set; }
        public double Iznos { get; set; }
        public Karta Karta { get; set; }

        public string TableName => "StavkaRacuna";

        public string Values => "@idRacun, @rb, @kolicina, @cena, @iznos, @idKarta";

       
        public string IdColumnName => "rb";

        public object Columns => "idRacun, rb, kolicina, cena, iznos, idKarta";

        public object UpdateValues => "kolicina = @kolicina, cena = @cena, iznos = @iznos, idKarta = @idKarta";

        public override bool Equals(object? obj)
        {
            if (obj is StavkaRacuna stavka)
                return Rb == stavka.Rb && Racun.IdRacun == stavka.Racun.IdRacun;

            return false;
        }

        public SqlParameter[] GetInsertParameters()
        {
            return new SqlParameter[] {
                new SqlParameter("@idRacun", Racun.IdRacun),
                new SqlParameter("@rb", Rb),
                new SqlParameter("@kolicina", Kolicina),
                new SqlParameter("@cena", Cena),
                new SqlParameter("@iznos", Iznos),
                new SqlParameter("@idKarta", Karta.IdKarta)
            };
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> stavke = new List<IEntity>();

            while (reader.Read())
            {
                StavkaRacuna s = new StavkaRacuna()
                {
                    Rb = (int)reader["rb"],
                    Kolicina = (int)reader["kolicina"],
                    Cena = Convert.ToDouble(reader["cena"]),
                    Iznos = Convert.ToDouble(reader["iznos"]),

                    Racun = new Racun()
                    {
                        IdRacun = (int)reader["idRacun"]
                    },

                   
                    Karta = new Karta()
                    {
                        IdKarta = (int)reader["idKarta"]
                    }
                };

                stavke.Add(s);
            }

            return stavke;
        }

        public SqlParameter[] GetUpdateParameters()
        {
            return new SqlParameter[] {
                new SqlParameter("@idRacun", Racun.IdRacun),
                new SqlParameter("@rb", Rb),
                new SqlParameter("@kolicina", Kolicina),
                new SqlParameter("@cena", Cena),
                new SqlParameter("@iznos", Iznos),
                new SqlParameter("@idKarta", Karta.IdKarta)
            };
        }
    }
}