using System;

/* --------------------------------------------------------------------
 * Below is some sample usage of the db connection and command classes.
 * The classes uses abstraction and polymorphism from the base class.
 * -------------------------------------------------------------------*/

namespace Simple_DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the connections
            var sqlConnection = new SqlConnection("my-sql-connection-string");
            var oracleConnection = new OracleConnection("my-oracle-connection-string", new TimeSpan(0, 3, 0));

            // Can't instantiate abstract class
            // var dbConnection = new DbConnection("some-db-connection-string");


            // Instantiate the commands, then execute them
            var sqlCommands = new DbCommand(sqlConnection, "SOME SQL COMMANDS");
            sqlCommands.Execute();

            var oracleCommands = new DbCommand(oracleConnection, "SOME ORACLE COMMANDS");
            oracleCommands.Execute();

        }
    }
}
