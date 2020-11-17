using System;
using System.Collections.Generic;


namespace Exercise_1
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter your numbers separated by a Hypehn:");
            
            string numbersWithHyphen = Console.ReadLine(); //("5-6-7-8")

            List <int> arrayOfNumbers = convertNumStrToList(numbersWithHyphen);

            for (int i = 0; i < ((arrayOfNumbers.Count)-1); i++) //[1,2,3]
            {
                if ((arrayOfNumbers[i+1] - arrayOfNumbers[i]) == 1 || (arrayOfNumbers[i] - arrayOfNumbers[i+1]) == 1)
                {
                    if (i == (arrayOfNumbers.Count - 2))
                    {
                        Console.WriteLine("Your numbers ARE Consecutive");
                        
                    }
                    continue;
                } 
                else
                {
                    Console.WriteLine("Your numbers are not Consecutive");
                    break;
                }
            }
        }

        public static List<int> convertNumStrToList (string numbersWithHyphen)
        {
            string[] arrayOfNumbersString = numbersWithHyphen.Split("-"); //["5","6","7","8"]

            int size = arrayOfNumbersString.Length;

            // int[] arrayofNumbers = new int[size]; 
            var arrayOfNumbers = new List<int>();

            for (int i = 0; i < size; i++)
            {
                arrayOfNumbers.Add(Int32.Parse(arrayOfNumbersString[i]));
                //arrayofNumbers[i] = Int32.Parse(arrayOfNumbersString[i]);
            }

            return arrayOfNumbers;
        }


    }
}
