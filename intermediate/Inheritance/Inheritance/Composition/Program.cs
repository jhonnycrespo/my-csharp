using System;

namespace Inheritance.Composition
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dbMigration = new DbMigrator(new Logger());

            var logger =  new Logger();

            var installer = new Installer(logger);

            dbMigration.Migrate();
            installer.Install();
        }
    }

    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("installing the application");
        }
    }

    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("we are migrating your database");
        }
    }

    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
