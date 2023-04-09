using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("hello
            byte number3 = 255;

            decimal dec = 10.4m;
            char character = 'a';
            long number2 = 1000000000000000000;
            var number7 = 10;
            Console.WriteLine((int)Days.friday);
            Console.WriteLine("number1 is {0}",number3);
            Console.ReadLine();
        }
    }
    enum Days
    {
        monday=12,tuesday=90,wednesday,thursday,friday,saturday
    }
}
