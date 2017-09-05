using System;

namespace Simple_DbConnection
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        // Constructor
        public DbCommand(DbConnection dbConnection, string instruction)
        {
            _dbConnection = dbConnection;
            _instruction = instruction;
            if (dbConnection == null)
                throw new Exception("You must pass an instance of DbConnection to create a DbCommand.");
        }

        // Methods
        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine("Execute: {0}", _instruction);
            _dbConnection.Close();
        }
    }

}