using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            int x = name.Length;

            // char[] letters = name.toCharArray();
            char[] letters = new char[x]; 
            for (var i=0; i<x; i++)
            {
                letters[i] = name[i];
            }
            Array.Reverse(letters);

            // string reversed = new string(letters);
            string reversed = "";
            for (var i = 0; i < x; i++)
            {
                reversed += letters[i];
            }
            
            Console.WriteLine(reversed);
        }
    }
}
