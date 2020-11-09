using System; 

namespace Conditionals
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your speed limit");
            var number = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter your speed of car");
            var number2 = Convert.ToDouble (Console.ReadLine());

            if (number >=number2)
            {
                Console.WriteLine("OK");
            } 
            else if (number2>number)
            {
                var demeritPoints = (number2 - number) / 5;
                if (demeritPoints >12)
                {
                    Console.WriteLine("Licensed Suspended");
                }
                else
                {
                    Console.WriteLine("You have :" + demeritPoints + "on your License");
                }
                
            } else
            {
                Console.WriteLine("Something went wrong");
            }
            

        }
    }
}
