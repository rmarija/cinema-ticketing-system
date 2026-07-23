using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Zajednicki.Domen
{
    public class StrucnaSprema : IEntity
    {
        public int IdStrucnaSprema { get; set; }
        public string Naziv { get; set; }
        public string StepenObrazovanja { get; set; }

        public string TableName => "StrucnaSprema";

        public string Values => "@naziv, @stepenObrazovanja";

        public string IdColumnName => "idStrucnaSprema";

        public object Columns => "naziv, stepenObrazovanja";

        public object UpdateValues => "naziv = @naziv, stepenObrazovanja = @stepenObrazovanja";

        public override bool Equals(object? obj)
        {
            if (obj is StrucnaSprema strucnaSprema)
                return IdStrucnaSprema == strucnaSprema.IdStrucnaSprema;

            return false;
        }

        public SqlParameter[] GetInsertParameters()
        {
            return new SqlParameter[] {
                new SqlParameter("@naziv", Naziv),
                new SqlParameter("@stepenObrazovanja", StepenObrazovanja)
            };
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> lista = new List<IEntity>();

            while (reader.Read())
            {
                StrucnaSprema ss = new StrucnaSprema
                {
                    IdStrucnaSprema = (int)reader["idStrucnaSprema"],
                    Naziv = (string)reader["naziv"],
                    StepenObrazovanja = (string)reader["stepenObrazovanja"]
                };
                lista.Add(ss);
            }
            return lista;
        }

        public SqlParameter[] GetUpdateParameters()
        {
            return new SqlParameter[] {
                new SqlParameter("@idStrucnaSprema", IdStrucnaSprema),
                new SqlParameter("@naziv", Naziv),
                new SqlParameter("@stepenObrazovanja", StepenObrazovanja)
            };
        }

        public override string ToString()
        {
            return $"{Naziv} ({StepenObrazovanja})";
        }
    }
}