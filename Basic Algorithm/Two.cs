// Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Algorithm
{
    class Two
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st No: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd No: ");
            int b = int.Parse(Console.ReadLine());

            bool add()
            {
                return a == 30 || b == 30 || a + b == 30 ? true : false;
            }

            Console.WriteLine(add());


            Console.ReadKey();
        }
    }
}
