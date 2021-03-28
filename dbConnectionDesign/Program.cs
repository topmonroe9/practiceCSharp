using System;

namespace dbConnectionDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracleDbConnection = new OracleDbConnection("Url");
            var db1 = new DbCommand(oracleDbConnection);
            db1.Execute("OracleDB command");
            Console.WriteLine();
            var sqlConnection = new SqlConnection("url");
            var db = new DbCommand(sqlConnection);
            db.Execute("T-SQL language command");
        }
    }
}
