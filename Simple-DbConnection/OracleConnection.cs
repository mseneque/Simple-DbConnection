using System;

namespace Simple_DbConnection
{
    public class OracleConnection : DbConnection
    {

        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public OracleConnection(string connectionString, TimeSpan timeout) : base(connectionString, timeout)
        {
        }

        public override void Open()
        {
            Console.WriteLine("OPEN the ORACLE connection: \"{0}\"", this.ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("CLOSE the ORACLE connection");
        }
    }
}
