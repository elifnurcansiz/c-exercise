namespace Extensibility.cs
{
    
        public class DbMigrator
    {
        private ILogger1 _logger;

        public DbMigrator(ILogger1 logger)
        {
            _logger = logger;
        } 
         
        public void Migrate()

        {
            _logger.LogInfo("Migrationg started at {0}" DateTime.Now);
         
            //Details of migrating the datebase
           _logger.LogInfo("Migrationg finished at {0}", DateTime.Now);
        }
    }
    class Program { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}