using System;

namespace Simple_DbConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        // First signature, takes one manditory 'connectionString' parameter. Default 'timeout' of 30 seconds.
        protected DbConnection(string connectionString)
        {
            this.ConnectionString = connectionString ?? throw new Exception("Connection string must not be null");
            this.Timeout = new TimeSpan(0, 0, 30);
        }

        // Second signature, takes 'connectionString' and 'timeout' parameters.
        protected DbConnection(string connectionString, TimeSpan timeout)
        {
            this.ConnectionString = connectionString ?? throw new Exception("Connection string must not be null");
            this.Timeout = timeout;
        }

        // Like using 'virtual' for polymorphism, but 'abstract' makes sure 
        // the implementation is handled by the derived class.
        public abstract void Open();
        public abstract void Close();

    }
}