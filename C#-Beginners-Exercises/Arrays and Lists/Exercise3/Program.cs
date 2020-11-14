using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            while  (true)
            {
                Console.WriteLine("Enter a number:");
                string numero = Console.ReadLine();
                var number = Convert.ToInt32(numero);
                var numbers = new List<int>();

                if (numbers.Contains(number))
                {
                    Console.WriteLine("ERROR, number already typed, please retry");
                    continue;
                } 
                else if (numbers.Count == 5)
                {
                    numbers.Sort();
                    foreach (var numberOnTheList in numbers)
                    {
                        Console.WriteLine(numberOnTheList);
                        break;
                    }
                }
                else
                {
                    numbers.Add(number);
                    Console.WriteLine(numbers.Count);
                    continue;
                }
            }
        }
    }
}
