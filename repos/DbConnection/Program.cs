namespace DbConnection
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "asdasda";
            DbConnection oracleConnection = new OracleConnection(connectionString);
            oracleConnection.Open();
            oracleConnection.Close();
        }
    }
}