using System;
using System.Text.Json;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your serial numbers separeted by a coma (example: 6,10,5,4):");
            // "6,10,5,4" -> ["6","10","5","4"] -> [6,10,5,4]

            string serialNumbersString = Console.ReadLine(); // => "6,10,5,4"
            string[] serialNumbersStrArray = serialNumbersString.Split(','); // => ["6","10","5","4"]
            int[] serialNumbersArray = new int[serialNumbersStrArray.Length]; // => [ , , , ]

            for (int i=0; i< serialNumbersArray.Length; i++)
            {
                serialNumbersArray[i] = Int32.Parse(serialNumbersStrArray[i]); // [6,10,5,4]
            }

            int maximum = serialNumbersArray[0]; 
            for (int j=0; j<serialNumbersArray.Length; j++)
            {
                if (maximum < serialNumbersArray[j])
                {
                    maximum = serialNumbersArray[j];
                }
            }
            Console.WriteLine(maximum);
        }
    }
}
