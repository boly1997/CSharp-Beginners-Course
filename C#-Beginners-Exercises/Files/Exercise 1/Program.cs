using System;
using System.IO;


namespace Exercise_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Exercise 1
            string path = @"C:\Users\boly1\Desktop\Prueba1.txt";
            int totalWords = numberOfWords(path);
            Console.WriteLine(totalWords);

            //Exercise 2

            string longest = longestWord(path);
            Console.WriteLine(longest);
        }

        public static int numberOfWords(string path)
        {
            string numberOfWords = File.ReadAllText(path);
            string[] numberOfWordsWithoutSpace = numberOfWords.Split(" ");
            int totalWords = numberOfWordsWithoutSpace.Length;
            return totalWords;
        }

        public static string longestWord(string path)
        {
            string numberOfWords = File.ReadAllText(path);
            string[] numberOfWordsWithoutSpace = numberOfWords.Split(" ");
            string longest = numberOfWordsWithoutSpace[0];
            foreach (string word in numberOfWordsWithoutSpace)
            {
                if (longest.Length < word.Length)
                    longest = word;
            }

            return longest ;
        }
    }
}
