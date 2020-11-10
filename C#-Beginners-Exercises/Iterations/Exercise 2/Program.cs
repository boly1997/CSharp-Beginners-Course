using System;
using System.Diagnostics.CodeAnalysis;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 0;

            while (true)
            {
                Console.WriteLine("Write a number or tab ok:");
                var text = Console.ReadLine();
                if (text == "ok")
                {
                    Console.WriteLine(number);
                    break;
                }
                var newNumber = Int32.Parse(text);                
                number = newNumber + number;

            }

        }
    }
}
