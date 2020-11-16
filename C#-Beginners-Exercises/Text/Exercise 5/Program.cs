using System;
using System.Collections.Generic;


namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write an English Word");
            string englishWord = Console.ReadLine();
            int count = englishWord.Length;
            int j = 0;
            //var wordInList = new List <string>() { englishWord };

            for (var i=0; i<count; i++)
            {
                if (englishWord[i] == 'a' || englishWord[i] == 'e' || englishWord[i] == 'i' || englishWord[i] == 'o' || englishWord[i] == 'u')
                {
                    j++;
                }
            }

            Console.WriteLine("Your total of Vocals are: " + j);
        }
    }
}
