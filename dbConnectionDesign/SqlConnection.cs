using System;

namespace dbConnectionDesign
{
    public class SqlConnection : DbConnection

    {

        public SqlConnection(string connectionString) : base(connectionString)
        {
            Timeout = TimeSpan.FromHours(1);
        }


        public override void OpenConnection()
        {
            Console.WriteLine("Opening sql connection");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing sql connection");
            Console.WriteLine(Timeout);
            Console.WriteLine(ConnectionString);
        }
    }
}