namespace DbConnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }
        public override void Open()
        {
            Console.WriteLine("oracle connection open");
        }
        public override void Close()
        {
            Console.WriteLine("oracle connection close");
        }

    }
}