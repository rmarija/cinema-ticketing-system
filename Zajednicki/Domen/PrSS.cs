using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki.Domen
{
    public class PrSS : IEntity
    {
        public Prodavac Prodavac { get; set; }
        public StrucnaSprema StrucnaSprema { get; set; }
        public DateTime DatumSticanja { get; set; }

        public string TableName => "PrSS";

        public string Values => "@idProdavac, @idStrucnaSprema, @datumSticanja";

        public string IdColumnName => "";

        public object Columns => "idProdavac, idStrucnaSprema, datumSticanja";

        public object UpdateValues => "";

        public SqlParameter[] GetInsertParameters()
        {
            return new SqlParameter[] {
                new SqlParameter("@idProdavac", Prodavac.IdProdavac),
                new SqlParameter("@idStrucnaSprema", StrucnaSprema.IdStrucnaSprema),
                new SqlParameter("@datumSticanja", DatumSticanja)
            };
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            return new List<IEntity>();
        }

        public SqlParameter[] GetUpdateParameters()
        {
            return new SqlParameter[0];
        }
    }
}