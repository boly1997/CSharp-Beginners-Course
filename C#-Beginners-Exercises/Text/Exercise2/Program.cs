using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your numbers separated by a Hypehn:");

            string numbersWithHyphen = Console.ReadLine(); //("5-6-7-8")

            if (numbersWithHyphen == "")
            {
                Console.WriteLine("ITS OVER");
            }
            else
            {
                string[] arrayOfNumbersString = numbersWithHyphen.Split("-"); //["5","6","7","8"]

                int size = arrayOfNumbersString.Length;

                var arrayOfNumbers = new List<int>();

                for (int i = 0; i < size; i++)
                {
                    arrayOfNumbers.Add(Int32.Parse(arrayOfNumbersString[i]));
                }

                int reference = arrayOfNumbers[0];

                for(var i=1; i<(size); i++)
                {
                    if (arrayOfNumbers[i] == reference)
                    {
                        Console.WriteLine("Your List have a duplicate");
                        break;
                    }

                    else
                        if (i == (size - 1))
                    {
                        Console.WriteLine("Your list DOESNT HAVE A DUPLICATE");
                    }
                    else
                        continue;
                }
            }

        }
    }
}
