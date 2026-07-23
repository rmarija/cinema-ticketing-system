using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Zajednicki.Domen
{
    public class Mesto : IEntity
    {
        public int IdMesto { get; set; }
        public string Naziv { get; set; }
        public string PostanskiBroj { get; set; }

        public string TableName => "Mesto";
        public string Values => "@naziv, @postanskiBroj";
        public string IdColumnName => "idMesto";
        public object Columns => "naziv, postanskiBroj";
        public object UpdateValues => "naziv = @naziv, postanskiBroj = @postanskiBroj";

        public override bool Equals(object? obj)
        {
            if (obj is Mesto mesto)
                return IdMesto == mesto.IdMesto;
            return false;
        }

        public SqlParameter[] GetInsertParameters()
        {
            return new SqlParameter[] {
                new SqlParameter("@naziv", Naziv),
                new SqlParameter("@postanskiBroj", PostanskiBroj)
            };
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> mesta = new List<IEntity>();
            while (reader.Read())
            {
                Mesto m = new Mesto
                {
                    IdMesto = (int)reader["idMesto"],
                    Naziv = (string)reader["naziv"],
                    PostanskiBroj = (string)reader["postanskiBroj"]
                };
                mesta.Add(m);
            }
            return mesta;
        }

        public SqlParameter[] GetUpdateParameters()
        {
            return new SqlParameter[] {
                new SqlParameter("@id", IdMesto),
                new SqlParameter("@naziv", Naziv),
                new SqlParameter("@postanskiBroj", PostanskiBroj)
            };
        }

        public override string ToString()
        {
            return $"{Naziv} ({PostanskiBroj})";
        }
    }
}