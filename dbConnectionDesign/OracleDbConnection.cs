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

            Console.WriteLine($"timeout: {Timeout.Minutes} min");
            Console.WriteLine($"Connected to: {ConnectionString}");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing OracleDb connection");
        }
    }
}