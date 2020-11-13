using System;

namespace Course_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            // Length 
            Console.WriteLine(numbers.Length);
            // IndexOf()
            int index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);

            // Clear()
            Array.Clear(numbers, 0, 2);

            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            // Sort()
            Array.Sort(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Reverse()
            Array.Reverse(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }



    }
}
