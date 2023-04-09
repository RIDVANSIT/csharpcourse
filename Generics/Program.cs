using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.Buildlist<string>(
                "ardahan", "kars", "ığdır");
            foreach (var item in result) {
                Console.WriteLine(item);
            }
            List<Customer> result2 = utilities.Buildlist<Customer>(new Customer{FirstName= "rıdvan" }, new Customer { FirstName = "murat" });
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Utilities
    {
        public List<T> Buildlist<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }
    class Product
    {

    }
    interface IProductDal : IRepository<Product>
    {

    }
    class Customer
    {
        public string FirstName { get; set; }
    }
    interface ICustomerDal:IRepository<Customer> 
    {
    }
    interface IRepository<T>
    {

        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
