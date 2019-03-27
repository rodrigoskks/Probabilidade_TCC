using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Probabilidade.Data.DB
{
    public class DBSqlConnection
    {

        #region Atributos da conexão 
        private SqlConnection  _sqlConnection;
        private SqlCommand     _sqlCommand;
        private SqlDataAdapter _sqlAdapter;
        private SqlTransaction _sqlTransaction;
        private string _stringConnection;
        #endregion

        #region String de conexão
        public string StringConnection
        {
            get { return this._stringConnection;  }
            set { this._stringConnection = value; }
        }
        #endregion

        #region Construtor vazio
        public DBSqlConnection()
        {
        }
        #endregion

        #region Recebe string de conexão
        public DBSqlConnection(string stringConnection)
        {
            this._stringConnection = stringConnection;
        }
        #endregion

        #region Abre conexão com o banco
        private SqlConnection GetConnection()
        {
            try
            {
                _sqlConnection = new SqlConnection(this._stringConnection);
                if (_sqlConnection != null)
                {
                    if (_sqlConnection.State == ConnectionState.Closed)
                    {
                        _sqlConnection.Open();                        
                    }
                }
                else
                {
                    throw new Exception("Conexão é null");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return _sqlConnection;
        }
        #endregion

        #region Retorna dados
        public DataSet GetDataSet(string query)
        {
            DataSet data = new DataSet();
            try
            {
                _sqlCommand = new SqlCommand(query, GetConnection());
                if (_sqlCommand != null)
                {
                    _sqlAdapter = new SqlDataAdapter(_sqlCommand);
                    _sqlAdapter.Fill(data);
                }
                else
                {
                    throw new Exception("Comando é null");
                }
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message, ex);
            }

            finally
            {
                if (_sqlConnection.State == ConnectionState.Open)
                {
                    _sqlConnection.Close();
                }
            }
            return data;
        }
        #endregion

        public bool ExecutaQuery(string query)
        {
            SqlConnection con = GetConnection();

            _sqlTransaction = con.BeginTransaction();

            try
            {
                _sqlCommand = con.CreateCommand();
                _sqlCommand.Transaction = _sqlTransaction;
                _sqlCommand.CommandText = query;
                _sqlCommand.ExecuteNonQuery();
                _sqlTransaction.Commit();

                return true;
            }

            catch (Exception ex)
            {
                _sqlTransaction.Rollback();
                throw new Exception(ex.Message);
            }

            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
