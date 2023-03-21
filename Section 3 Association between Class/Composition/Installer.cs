namespace MyApp
{
    internal partial class Program
    {
        public class Installer
        {
            private readonly Logger _logger;

            public Installer(Logger logger)
            {
                _logger = logger;
            }

            public void Install()
            {
                Console.WriteLine("We are installing the application.");
            }
        }
    }
}