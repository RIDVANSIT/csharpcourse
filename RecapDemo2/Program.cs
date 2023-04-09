using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {
        public ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new FileLogger();
            Console.ReadLine(); 
        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }
        public void Add()
        {
           
            Logger.Log();
            Console.WriteLine("added");
        }
    }
    class DatabaseLogger:ILogger
    {
        public void Log() {
            Console.WriteLine("logged");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged");
        }
    }
    interface ILogger
    {
        void Log();
    }
}
