using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some words separated by space (e.g Hola israel como estas");
            string words = Console.ReadLine();
            
            string wordsLowers = words.ToLower(); // ("hola israel como estas")
            string[] wordsWithoutSpace = wordsLowers.Split(' '); // ["hola", "israel"....]
            int numWords = wordsWithoutSpace.Length;

            for (int i = 0; i < numWords; i++)
            {
                string currentWord = wordsWithoutSpace[i]; // "hola"
                string firstChar = currentWord[0].ToString().ToUpper(); // "H"
                wordsWithoutSpace[i] = firstChar+ currentWord.Substring(1);  // "H" + "ola" => "Hola"
            } //["Hola", "Como" ...]

            string pascalCase = wordsWithoutSpace[0];

            for (int i = 1; i < numWords; i++)
            {
                pascalCase += wordsWithoutSpace[i]; 
            } // (HolaIsraelComoEstas)

            Console.WriteLine(pascalCase);
        }
    }
}
