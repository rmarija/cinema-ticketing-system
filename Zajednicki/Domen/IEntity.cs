using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Zajednicki.Domen
{
    public interface IEntity
    {
        string TableName { get; }
        string Values { get; }
        string IdColumnName { get; }
        object Columns { get; }
        object UpdateValues { get; }

        SqlParameter[] GetInsertParameters();
        List<IEntity> GetReaderList(SqlDataReader reader);
        SqlParameter[] GetUpdateParameters();

    }
}
