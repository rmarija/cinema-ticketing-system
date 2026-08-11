using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Zajednicki.Domen
{
    public class Kupac : IEntity
    {
        public int IdKupac { get; set; }
        public string Naziv { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public Mesto Mesto { get; set; }

        public string TableName => "Kupac";
        public string Values => "@naziv, @email, @telefon, @idMesto";
        public string IdColumnName => "idKupac";
        public object Columns => "naziv, email, telefon, idMesto";
        public object UpdateValues => "naziv = @naziv, email = @email, telefon = @telefon, idMesto = @idMesto";

        public override bool Equals(object? obj)
        {
            if (obj is Kupac kupac)
                return IdKupac == kupac.IdKupac;
            return false;
        }

        public SqlParameter[] GetInsertParameters()
        {
            return new SqlParameter[] {
                new SqlParameter("@naziv", Naziv),
                new SqlParameter("@email", Email),
                new SqlParameter("@telefon", Telefon),
                new SqlParameter("@idMesto", Mesto.IdMesto)
            };
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> kupci = new List<IEntity>();
            while (reader.Read())
            {
                Kupac k = new Kupac
                {
                    IdKupac = (int)reader["idKupac"],
                    Naziv = (string)reader["naziv"],
                    Email = (string)reader["email"],
                    Telefon = (string)reader["telefon"],

                    Mesto = new Mesto
                    {
                        IdMesto = (int)reader["idMesto"],
                        Naziv = reader["mestoNaziv"] as string,
                        PostanskiBroj = reader["postanskiBroj"] as string
                    }
                };
                kupci.Add(k);
            }
            return kupci;
        }

        public SqlParameter[] GetUpdateParameters()
        {
            return new SqlParameter[] {
                new SqlParameter("@id", IdKupac), 
                new SqlParameter("@naziv", Naziv),
                new SqlParameter("@email", Email),
                new SqlParameter("@telefon", Telefon),
                new SqlParameter("@idMesto", Mesto.IdMesto)
            };
        }

        public override string ToString()
        {
            return $"{Naziv}";
        }
    }
}