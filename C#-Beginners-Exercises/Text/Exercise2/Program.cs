using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your numbers separated by a Hypehn:");

            string numbersWithHyphen = Console.ReadLine(); //("5-6-7-8")

            if (numbersWithHyphen == "")
            {
                Console.WriteLine("ITS OVER");
            }
            else
            {
                List<int> arrayOfNumbers = convertNumStrToList(numbersWithHyphen);

                for (var i=1; i<(arrayOfNumbers.Count); i++)
                {
                    if (arrayOfNumbers[i] == arrayOfNumbers[0])
                    {
                        Console.WriteLine("Your List have a duplicate");
                        break;
                    }

                    else
                        if (i == (arrayOfNumbers.Count - 1))
                    {
                        Console.WriteLine("Your list DOESNT HAVE A DUPLICATE");
                    }
                    else
                        continue;
                }
            }

        }
        public static List<int> convertNumStrToList(string numbersWithHyphen)
        {
            string[] arrayOfNumbersString = numbersWithHyphen.Split("-"); //["5","6","7","8"]

            var arrayOfNumbers = new List<int>();

            for (int i = 0; i < arrayOfNumbersString.Length; i++)
            {
                arrayOfNumbers.Add(Int32.Parse(arrayOfNumbersString[i]));
            }

            return arrayOfNumbers;
        }
    }
    
}
