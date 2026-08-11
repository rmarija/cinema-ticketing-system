using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Zajednicki.Domen
{
    public class Prodavac : IEntity
    {
        public int IdProdavac { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string TableName => "Prodavac";

        public string Values => "";

        public string IdColumnName => "idProdavac";

        public object Columns => "";

        public object UpdateValues => "";

        public override bool Equals(object? obj)
        {
            if (obj is Prodavac prodavac)
                return IdProdavac == prodavac.IdProdavac;

            return false;
        }

        public SqlParameter[] GetInsertParameters()
        {
            return new SqlParameter[0];
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> prodavci = new List<IEntity>();

            while (reader.Read())
            {
                Prodavac p = new Prodavac
                {
                    IdProdavac = (int)reader["idProdavac"],
                    Ime = (string)reader["ime"],
                    Prezime = (string)reader["prezime"],
                    Username = (string)reader["username"],
                    Password = (string)reader["password"]
                };
                prodavci.Add(p);
            }
            return prodavci;
        }

        public SqlParameter[] GetUpdateParameters()
        {
            return new SqlParameter[0];
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}