using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students =  { "rıdvan", "şevket", "hulusi" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            
            string[,] students2 = new string[5, 2]
            {
                {"ard","mo" },
                {"ard","yy" },
                {"ard","jj" },
                {"ard","bb" },
                {"ard","ff" },
            };
            for(int i = 0; i <= students2.GetUpperBound(0); i++) { 
            for(int j = 0; j <= students2.GetUpperBound(1); j++)
                {
                    Console.WriteLine(students2[i,j]);
                }
                Console.WriteLine("**********");
            }
            Console.ReadLine();
        }
    }
}
