using System;

namespace dbConnectionDesign
{

    public abstract class DbConnection
    { 
        protected readonly string ConnectionString;
        protected TimeSpan Timeout;

        protected DbConnection(string connectionString)
        {
            if (IsEmpty(connectionString))
                throw new Exception("invalid string provided");
            ConnectionString = connectionString;

        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();


        private static bool IsEmpty(string myString)
        {
            return string.IsNullOrEmpty(myString) || myString.Length == 0 || myString.Trim().Length == 0;
        }

    }
}