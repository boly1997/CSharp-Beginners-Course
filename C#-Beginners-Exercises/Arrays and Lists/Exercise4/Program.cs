using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number or type quit to exit:");
                string numberString = Console.ReadLine();
                var listOfNumbers = new List<int>();

                if (numberString == "quit")
                {
                    foreach (var numero in listOfNumbers)
                    {
                        Console.WriteLine(numero);
                    }
                    break;
                } 
                else
                {
                    int number = Convert.ToInt32(numberString);
                    listOfNumbers.Add(number);
                    continue;
                }
            }
        }
    }
}
