using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number:");
                string numero = Console.ReadLine();
                var number = Convert.ToInt32(numero);

                if (numbers.Contains(number))
                {
                    Console.WriteLine("ERROR, number already typed, please retry");
                } 
                else
                {
                    numbers.Add(number);
                    if (numbers.Count == 5)
                    {
                        numbers.Sort(); // [1, 2, 3, 4, 5] => "1, 2, 3, 4, 5"
                        string sortedNumbers = String.Join(",", numbers);
                        // foreach (var numberOnTheList in numbers)
                        // {
                        //     sortedNumbers += numberOnTheList.ToString() + ", ";
                        // }
                        Console.WriteLine(sortedNumbers);
                        break;
                    }
                }
            }
        }
    }
}
