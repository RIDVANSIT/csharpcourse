using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NewMethod();
            List<string> list = new List<string>();
            list.Add("ssssss");
            list.Add("istanbul");
            
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }

        private static void NewMethod()
        {
            ArrayList cities = new ArrayList();
            cities.Add("ardahan");
            cities.Add("adana");
            cities.Add("ankara");
            foreach (var i in cities)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
