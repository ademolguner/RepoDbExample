using RepoDb;
using RepoDbExample.Core.DataAccess.RepoDb.DbConnectionOptions;
using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace RepoDbExample.Core.DataAccess.RepoDb
{
    public class QueryableRepositoryBase<TEntity, DbConnection> : IQueryableRepository<TEntity>
        where TEntity : class, IDto, new()
        where DbConnection : IDatabaseConnectionFactory, new()
    {
        public IEnumerable<TEntity> GetByExecuteTextQuery(string commandText, object param = null)
        {
            try
            {
                using var conn = new DbConnection().CreateConnection().EnsureOpen();
                var data = conn.ExecuteQuery<TEntity>(commandText, param, CommandType.Text);
                return data;
            }
            catch (SqlException odbcEx) { throw new Exception(GetSqlExceptionDetail(odbcEx)); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public IEnumerable<TEntity> GetByExecuteStoredProcedureQuery(string commandText, object param = null)
        {
            try
            {
                using var conn = new DbConnection().CreateConnection().EnsureOpen();
                var data = conn.ExecuteQuery<TEntity>(commandText, param, CommandType.StoredProcedure);
                return data;
            }
            catch (SqlException odbcEx) { throw new Exception(GetSqlExceptionDetail(odbcEx)); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        #region yardımcı metotlar

        private string GetSqlExceptionDetail(SqlException ex)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var data = conn.ExecuteQuery<TEntity>("", "", CommandType.TableDirect);
            StringBuilder errorMessages = new StringBuilder();
            for (int i = 0; i < ex.Errors.Count; i++)
            {
                errorMessages.Append("Index #" + i + "\n" +
                    "Message: " + ex.Errors[i].Message + "\n" +
                    "Error Number: " + ex.Errors[i].Number + "\n" +
                    "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                    "Source: " + ex.Errors[i].Source + "\n" +
                    "Procedure: " + ex.Errors[i].Procedure + "\n");
            }
            return errorMessages.ToString();
        }

        #endregion yardımcı metotlar
    }
}