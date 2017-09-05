using System;

namespace Simple_DbConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public SqlConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
        }

        public override void Open()
        {
            Console.WriteLine("OPEN the SQL Connection: \"{0}\"", this.ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("CLOSE the SQL Connection");
        }
    }
}