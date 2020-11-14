using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            var arrayName = new string[1] { name };
            Array.Reverse(arrayName);

            foreach(var nombre in arrayName)
            {
                Console.WriteLine(nombre);
            }

            string reverseName = arrayName[0];
            Console.WriteLine(reverseName);


        }
    }
}
