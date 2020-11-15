using System;

namespace DateTime_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            var today = DateTime.Today;

            //Console.WriteLine(now.Hour);
           // Console.WriteLine(now.Minute);
            //Console.WriteLine(today);


           // var tomorrow = now.AddDays(1);
            //var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));


        }
    }
}
