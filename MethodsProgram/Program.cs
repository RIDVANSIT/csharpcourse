﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 10;
            ;
            Console.WriteLine(Add(number1, number2,3,4,5));
            Console.ReadLine();
        }
        static int Add(params int[] numbers) {
           
            return numbers.Sum();
        }
    }
}
