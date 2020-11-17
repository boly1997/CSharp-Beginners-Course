using System;

namespace Exercise_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter some words separated by space (e.g Hola israel como estas");
            string words = Console.ReadLine();
            
            string wordsLowers = words.ToLower(); // ("hola israel como estas")
            string[] wordsWithoutSpace = wordsLowers.Split(' '); // ["hola", "israel"....]

            var wordsWithoutSpaceUpper = firstCharToUpper(wordsWithoutSpace);

            string pascalCase = wordsWithoutSpaceUpper[0];

            for (int i = 1; i < wordsWithoutSpaceUpper.Length; i++)
            {
                pascalCase += wordsWithoutSpaceUpper[i]; 
            } // (HolaIsraelComoEstas)

            Console.WriteLine(pascalCase);
        }

        public static string[] firstCharToUpper (string[] wordsWithoutSpace)
        {
            for (int i = 0; i < wordsWithoutSpace.Length; i++)
            {
                string currentWord = wordsWithoutSpace[i]; // "hola"
                string firstChar = currentWord[0].ToString().ToUpper(); // "H"
                wordsWithoutSpace[i] = firstChar + currentWord.Substring(1);  // "H" + "ola" => "Hola"
            } //["Hola", "Como" ...]

            return wordsWithoutSpace;
        }    

    }
}
