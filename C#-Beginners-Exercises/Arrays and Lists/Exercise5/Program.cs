using System;
using System.Collections.Generic;
namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10)");
                var listOfNumbers = Console.ReadLine(); // ("5, 1, 9, 2, 10")

                string[] serialNumbersStrArray = listOfNumbers.Split(','); // => ["6","10","5","4"]

                int[] serialNumbersArray = new int[serialNumbersStrArray.Length]; // => [ , , , ]

                for (int i = 0; i < serialNumbersArray.Length; i++)
                {
                    serialNumbersArray[i] = Int32.Parse(serialNumbersStrArray[i]); // [6,10,5,4]
                }

                if (serialNumbersArray.Length < 5)
                {
                    Console.WriteLine("Invalid List, try again");
                } 
                else
                {
                    Array.Sort(serialNumbersArray);
                    var numbers = new List<int>() { 
                        serialNumbersArray[0], 
                        serialNumbersArray[1], 
                        serialNumbersArray[2] 
                    };
                    string result = String.Join(",", numbers);
                    Console.WriteLine(result);
                    break;
                }
                
            }
        }
    }
}
