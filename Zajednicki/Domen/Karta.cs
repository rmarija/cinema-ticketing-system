using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class Karta : IEntity
    {

       public int IdKarta { get; set; }
        public string NazivFilma { get; set; }
        public DateTime DatumVremeProjekcije { get; set; }
        public string Sala { get; set; }
        public double Cena { get; set; }


        public string TableName => "Karta";

        public string Values => "";

        public string IdColumnName => "";

        public object Columns => "";

        public object UpdateValues => "";

        public override bool Equals(object? obj)
        {
            if (obj is Karta karta)
                return IdKarta == karta.IdKarta;

            return false;
        }

        public SqlParameter[] GetInsertParameters()
        {
            return new SqlParameter[0];
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> karte = new List<IEntity>();

            while (reader.Read())
            {
                Karta k = new Karta
                {
                    IdKarta = (int)reader["idKarta"],
                    NazivFilma = (string)reader["nazivFilma"],
                    DatumVremeProjekcije = (DateTime)reader["datumVremeProjekcije"],
                    Sala = (string)reader["sala"],
                    Cena = Convert.ToDouble(reader["cena"]),
                   
                };
                karte.Add(k);
            }
            return karte;
        }

        public SqlParameter[] GetUpdateParameters()
        {
            return new SqlParameter[0];
        }

        public override string ToString()
        {
            return $"{NazivFilma} - {Sala} - {DatumVremeProjekcije.ToString("dd.MM.yyyy u HH:mm")}";
        }






    }
}
