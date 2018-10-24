using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using ActiveMidia.Infra.Context.Interfaces;

namespace ActiveMidia.Infra.Context
{
    public class DapperContext : IDapperContext
    {

        private readonly string _connectionString;
        private IDbConnection _connection;


        public DapperContext()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        }


        public IDbConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new MySqlConnection(_connectionString);

                }
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
                return _connection;
            }
        }

        public void Dispose()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
                _connection.Close();
        }
    }
}
