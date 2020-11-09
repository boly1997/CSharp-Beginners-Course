using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = 0;
            for (var i=1; i<101; i++)
            {
                if (i % 3 == 0)
                {
                    j++;
                }
            }
            Console.WriteLine("The amount is:" + " " + j);
        }

    }
}
