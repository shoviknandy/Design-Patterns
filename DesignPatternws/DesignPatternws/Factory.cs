using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternws
{
    public interface ILogger
    {
        public void Log(string Message);
    }

    public class DBLogger:ILogger
    {
        public void Log(string Message)
        {
            Console.WriteLine($"Logged in DB {Message}");
        }
    }

    public class KibanaLogger : ILogger
    {
        public void Log(string Message)
        {
            Console.WriteLine($"Logged in KIbana: {Message}");
        }
    }
    public class Factory
    {
        public static ILogger GetLogger(Logger Instance)
        {
            return Instance switch
            {
                Logger.Kibana => new KibanaLogger(),
                Logger.DB=> new DBLogger(),
                _=> throw new ArgumentException($"{Instance} is not Supportde")

            };
        }
    }

}
