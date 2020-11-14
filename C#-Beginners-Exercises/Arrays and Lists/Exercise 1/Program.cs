using System;
using System.Collections.Generic;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter name:");
                var name = Console.ReadLine();
                var listOfNames = new List<string>();
                listOfNames.Add(name);

                if (name == "")
                {
                    /* for (var i=0; i<=listOfNames.Count; i++)
                    {
                        if (listOfNames[i] == "") 
                        {
                            listOfNames.Remove("");
                        }
                    } */

                    var numberOfNamesWithNothing = listOfNames.Count;
                    listOfNames.RemoveAt((numberOfNamesWithNothing - 1));
                    var numberOfNames = listOfNames.Count;

                    if (numberOfNames == 0)
                    {
                        Console.WriteLine("If no one likes your post, it doesn't display anything.");
                        break;
                    } 
                    else if (numberOfNames == 1)
                    {
                        Console.WriteLine( listOfNames[0] + " likes your post.");
                        break;
                    }
                    else if (numberOfNames == 2)
                    {
                        Console.WriteLine(listOfNames[0] + " and " + listOfNames[1] + " likes your post.");
                        break;
                    } 
                    else 
                    {
                        Console.WriteLine(listOfNames[0] + ", " + listOfNames[1] + " and " + (listOfNames.Count - 2) + " likes your post.");
                        break;
                    } 
                } 
            }

        }
    }
}
