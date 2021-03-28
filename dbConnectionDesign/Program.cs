using System;

namespace dbConnectionDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracleDbConnection = new OracleDbConnection("Url");
            oracleDbConnection.OpenConnection();
            oracleDbConnection.CloseConnection();

            var sqlConnection = new SqlConnection("url");
            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();
        }
    }
}
