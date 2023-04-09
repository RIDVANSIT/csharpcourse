using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(20);
            customerManager.Add();
            Console.ReadLine();

        }
    }
    class CustomerManager
    {
        private int _ozel;
        public CustomerManager(int ozel) { 
            _ozel = ozel;
        }
        public void Add() {
            Console.WriteLine("added {0} items",_ozel);
        }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logged to file");
        }
    }
    class EmployeeManager : ILogger
    {
        public void Log()
        {
            throw new NotImplementedException();
        }
    }
}
