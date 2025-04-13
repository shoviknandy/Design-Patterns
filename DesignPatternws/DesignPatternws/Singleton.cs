using DesignPatternws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternws
{
    public sealed class Singleton
    {
        private static Lazy<Singleton> _instance = new Lazy<Singleton>(()=>new Singleton());

        private Singleton()
        {
            // private Constructor
        }

        public static Singleton getInstance()
        {
            return _instance.Value;
        }

        public void DBConnection()
        {
            Console.WriteLine($"Connecting to DB : Thread ID {Thread.CurrentThread.ManagedThreadId} : HAshcode : {_instance.GetHashCode()}");
        }


    }
}


public static class ExecuteSingleton
{
    public static void Execute()
    {
        var thread1 = new Thread(() => Singleton.getInstance().DBConnection());
        var thread2 = new Thread(() => Singleton.getInstance().DBConnection());
        var thread3 = new Thread(() => Singleton.getInstance().DBConnection());

        thread1.Start();
        thread2.Start();
        thread3.Start();


        thread1.Join();
        thread2.Join();
        thread3.Join();
    }
}
