
//Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference

using System;


namespace Basic_Algorithm
{
    class One
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = n - 51;

            if (n>51)
            {
                int b = a * 3;
                Console.WriteLine($"Triple: {b}");
            }
            else
                Console.WriteLine($"Subtract : {a}");
            Console.ReadKey();
        }
    }
}
