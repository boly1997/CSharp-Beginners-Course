using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var randomFrom1To10 = random.Next(1, 10);
            Console.WriteLine(randomFrom1To10);

            var i = 1;
            while(i<=4)
            {
                Console.WriteLine("Guess the number between 1-10, type your number:");
                var guessedNumber = Int32.Parse(Console.ReadLine());

                if (guessedNumber == randomFrom1To10)
                {
                    break; 
                } else
                {
                    Console.WriteLine("Try again, you have: " + (4-i) + "Attempts left");
                    i++;
                    continue; 
                }
            }
            if (i <= 4)
            {
                Console.WriteLine("Congrats you WON!");
            } else 
            Console.WriteLine("Sorry, better luck next time, YOU LOST");
        }
    }
}
