using System;
using System.Collections.Generic;


namespace Exercise_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write an English Word");
            string englishWord = Console.ReadLine();
            //var wordInList = new List <string>() { englishWord };

            int j = vocalCount(englishWord);
          

            Console.WriteLine("Your total of Vocals are: " + j);
        }

        public static int vocalCount(string englishWord)
        {
            int j = 0;
            for (var i = 0; i < englishWord.Length; i++)
            {
                if (englishWord[i] == 'a' || englishWord[i] == 'e' || englishWord[i] == 'i' || englishWord[i] == 'o' || englishWord[i] == 'u')
                {
                    j++;
                }
            }
            return j;
        }

    }

}
