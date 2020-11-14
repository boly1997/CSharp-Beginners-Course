using System;
using System.Collections.Generic;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNumbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or type quit to exit:");
                string numberString = Console.ReadLine();

                if (numberString == "quit")
                {
                    var result = String.Join(",", listOfNumbers);
                    Console.WriteLine(result);
                    break;
                } 
                else
                {
                    int number = Convert.ToInt32(numberString);
                    if(!listOfNumbers.Contains(number))
                    {
                        listOfNumbers.Add(number);
                    }
                }
            }
        }
    }
}
