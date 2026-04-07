using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private static string ApplicationName;
        private static string version;
        private ConfigurationManager()
        {
            ApplicationName = "My Application";
            version = "1.0.0";
        }

        public static ConfigurationManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ConfigurationManager();
            }
            return instance;
        }


    }
    internal class program5
    {
        static void Main()
        {
             var app1=ConfigurationManager.GetInstance();
            var app2 = ConfigurationManager.GetInstance();
            if (app1 == app2)
            {
                Console.WriteLine("Singleton Implemented");
            }
            else
            {
                Console.WriteLine("Singleton Not Implemented");
            }
        }
    }
}
