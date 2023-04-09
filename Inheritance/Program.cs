using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3]
            {
                new Customer{FirstName="rıdvan"},
                new Student{FirstName="rasdab"},
                new Person{FirstName="kasdar"}


            };
            foreach (Person p in person)
            {
                Console.WriteLine(p.FirstName);
            }
            Console.ReadLine();
        }
    }
        class Person
        {

            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }
        class Customer : Person {
            public string City { get; set; }
        }
        class Student : Person
        {
            public string Department { get; set; }
        }
    }
