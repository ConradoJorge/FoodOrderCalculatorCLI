using System;
using System.Collections.Generic;

namespace FoodOrderCalculatorCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#=================================================#");
            Console.WriteLine("# Hello and welcome to the Food Order Calculator! #");
            Console.WriteLine("#       Please select your delivery service.      #");
            Console.WriteLine("#=================================================#\n");

            UserInterface.MainMenu();

        }
    }
}
