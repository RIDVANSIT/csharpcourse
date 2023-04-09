using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase2 = new Oracle();
            dataBase2.Remove();
            DataBase dataBase = new SqlServer();
            dataBase.Remove();
            Console.ReadLine();
        }
    }
    abstract class DataBase
    {
        public void Add() {
            Console.WriteLine("added");
        }
        public abstract void Remove();
    }
    class SqlServer : DataBase
    {
        public override void Remove()
        {
            Console.WriteLine("deleted by sql");
        }
    }
    class Oracle : DataBase
    {
        public override void Remove()
        {
            Console.WriteLine("deleted by oracle");
        }
    }
}
