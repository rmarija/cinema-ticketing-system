using Microsoft.Data.SqlClient;
using System.Data.Common;
using System.Security.Principal;
using Zajednicki.Domen;

namespace DBBroker
{
    public class Broker
    {
        private DBConnection connection;

        public Broker()
        {
            connection = new DBConnection();
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }

        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void Rollback()
        {
            connection.Rollback();
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from {entity.TableName}";
            using SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = entity.GetReaderList(reader);
            command.Dispose();
            return list;
        }

        public List<IEntity> GetByQuery(IEntity entity, string query)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            using SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = entity.GetReaderList(reader);
            command.Dispose();
            return list;
        }

        public void Add(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"insert into {entity.TableName} values ({entity.Values})";
            cmd.Parameters.AddRange(entity.GetInsertParameters());
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public int AddWithId(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"insert into {entity.TableName} ({entity.Columns}) output inserted.{entity.IdColumnName} values ({entity.Values})";
            cmd.Parameters.AddRange(entity.GetInsertParameters());
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            return id;
        }

        public IEntity GetById(IEntity entity, int id)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from {entity.TableName} where {entity.IdColumnName} = @id";
            command.Parameters.AddWithValue("@id", id);
            using SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = entity.GetReaderList(reader);
            command.Dispose();
            return list.Count > 0 ? list[0] : null;
        }

        public void Update(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"update {entity.TableName} set {entity.UpdateValues} where {entity.IdColumnName} = @id";
            cmd.Parameters.AddRange(entity.GetUpdateParameters());
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public void Delete(IEntity entity, int id)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"delete from {entity.TableName} where {entity.IdColumnName} = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public int ExecuteScalar(string query)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}