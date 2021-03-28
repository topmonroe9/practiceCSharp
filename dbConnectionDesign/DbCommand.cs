using System;

namespace dbConnectionDesign
{
    public class DbCommand
    {
        private readonly DbConnection _database;
        public DbCommand(DbConnection database)
        {
            if (database == null)
                return;
            _database = database;

        }

        public void Execute(string command)
        {
            _database.OpenConnection();
            Console.WriteLine(command);
            _database.CloseConnection();
        }
    }
}