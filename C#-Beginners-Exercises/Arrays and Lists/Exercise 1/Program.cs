using System;
using System.Collections.Generic;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfNames = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter name:");
                var name = Console.ReadLine();

                if (name == "")
                {
                    break;
                }

                listOfNames.Add(name);
            }

            var numberOfNamesWithNothing = listOfNames.Count;
            listOfNames.RemoveAt((numberOfNamesWithNothing - 1));
            var numberOfNames = listOfNames.Count;

            if (numberOfNames == 0)
            {
                Console.WriteLine("If no one likes your post, it doesn't display anything.");
            } 
            else if (numberOfNames == 1)
            {
                Console.WriteLine( listOfNames[0] + " likes your post.");
            }
            else if (numberOfNames == 2)
            {
                Console.WriteLine(listOfNames[0] + " and " + listOfNames[1] + " likes your post.");
            } 
            else 
            {
                Console.WriteLine(listOfNames[0] + ", " + listOfNames[1] + " and " + (listOfNames.Count - 2) + " likes your post.");
            } 

            // switch(numberOfNames)
            // {
            //     case 0:
            //         Console.WriteLine("If no one likes your post, it doesn't display anything.");
            //         break;
            //     case 1:
            //         Console.WriteLine( listOfNames[0] + " likes your post.");
            //         break;
            //     case 2:
            //         Console.WriteLine(listOfNames[0] + " and " + listOfNames[1] + " likes your post.");
            //         break;
            //     default:
            //         Console.WriteLine(listOfNames[0] + ", " + listOfNames[1] + " and " + (listOfNames.Count - 2) + " likes your post.");
            // }

        }
    }
}
