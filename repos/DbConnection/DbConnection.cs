using System.Reflection.Metadata.Ecma335;

namespace DbConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }    
        public int Timeout { get; set; }

        public DbConnection(string connectionString) {

            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentException("Connection string cannot be null or empty.");

            this.ConnectionString = connectionString;
        }

        public abstract void Open();

        public abstract void Close();

    }
}