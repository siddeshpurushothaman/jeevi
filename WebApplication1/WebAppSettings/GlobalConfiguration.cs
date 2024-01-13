using System.Security.Cryptography.X509Certificates;

namespace WebAppSettings
{
    public class GlobalConfiguration
    {
        public Environment Environment { get; set; }
    }

    public class Environment
    {
        public string username { get; set; }
        public string password { get; set; }
        public string connectionString { get; set; }


    }
}