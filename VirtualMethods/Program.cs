using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySqlServer mysqlServer = new MySqlServer();
            mysqlServer.Add();
            Console.ReadLine();
        }
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("added");
        }
        public virtual void Update()
        {
            Console.WriteLine("updated");
        }
    }
    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("sql added");
            base.Add();
        }
    }
    class MySqlServer : Database
    {

    }
}
