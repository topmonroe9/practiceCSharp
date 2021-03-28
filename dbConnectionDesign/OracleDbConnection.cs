using System;

namespace dbConnectionDesign
{
    public class OracleDbConnection : DbConnection

    {
        public OracleDbConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening OracleDb connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing OracleDb connection");
            Console.WriteLine(Timeout);
            Console.WriteLine(ConnectionString);
        }
    }
}