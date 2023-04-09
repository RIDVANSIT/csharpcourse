using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDonguKull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 994455558;
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0) { 
                    Console.WriteLine("asal değil {0} sayısına bölünüyor",i); }
               
            }
           

            Console.ReadLine();
        }
    }
}
