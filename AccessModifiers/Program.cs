using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        public string Name;

    }
    class Employee
    {
        public void Save() { 
        Customer customer = new Customer();
            customer.Name = "wwww";
        }

    }
}
