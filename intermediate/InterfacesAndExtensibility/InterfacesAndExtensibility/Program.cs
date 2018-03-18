using System;

namespace InterfacesAndExtensibility
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }

    class DbMigrator
    {
        private readonly ILogger logger;

        public DbMigrator(ILogger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {
            logger.LogInfo("migration started at " + DateTime.Now);
            logger.LogInfo("migration finished at " + DateTime.Now);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigrator = new DbMigrator(new FileLogger(@"D:\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
