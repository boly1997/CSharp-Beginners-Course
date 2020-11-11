using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = 1;
            Console.WriteLine("Please enter the number for the factorial Operation:");
            var factoralNumber = Int32.Parse(Console.ReadLine());
            for (var i = factoralNumber; i > 1; i--)
            {
                resultado = resultado * i;

            }
                Console.WriteLine(factoralNumber + "! =" + resultado);

               
            
        }
    }
}
