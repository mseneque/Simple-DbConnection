using System;

namespace Simple_DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("my-sql-connection-string");
            sqlConnection.Open();
            sqlConnection.Close();

            var oracleConnection = new OracleConnection("my-oracle-connection-string", new TimeSpan(0, 3, 0));
            oracleConnection.Open();
            oracleConnection.Close();

            // Can't instantiate abstract class
            // var dbConnection = new DbConnection("some-db-connection-string");


        }
    }
}
