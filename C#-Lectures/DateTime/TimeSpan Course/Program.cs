﻿using System;

namespace TimeSpan_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine(timeSpan2);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration:" + duration);

            // Properties
            Console.WriteLine("Minutes:" + timeSpan.Minutes);
            Console.WriteLine("Total Minutes:" + timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add example:" + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Add example:" + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString" + timeSpan.ToString());

            //Parse 
            Console.WriteLine("Parse" + TimeSpan.Parse("01:02:03"));


        }

    }
}
