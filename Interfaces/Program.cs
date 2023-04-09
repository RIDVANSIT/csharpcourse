﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ICustomerDAL[] customerDALs = new ICustomerDAL[2] { new SqlServerDal(), new OracleServerDal()};
            foreach (var dal in customerDALs)
            {
                dal.Add();
            }
            //NewMethod();
            Console.ReadLine();

        }

        private static void NewMethod()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerDal());
           
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        class Customer:IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }
        class Student:IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }
        class PersonManager
        {
            public void Add( Customer customer)
            {
Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + customer.Id);
            }
        }
    }
}
