using System;

namespace dbConnectionDesign
{
    public class SqlConnection : DbConnection

    {

        public SqlConnection(string connectionString) : base(connectionString)
        {
            
        }


        public override void OpenConnection()
        {
            Console.WriteLine("Opened sql connection");

            Console.WriteLine($"timeout: {Timeout.Minutes} min");
            Console.WriteLine($"Connected to: {ConnectionString}");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closed sql connection");

        }
    }
}