using System;
using System.Collections.Generic;


namespace Text_Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            /* var fullName = "Mosh Hamedani ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Trim: '{0}'", fullName.ToUpper().Trim());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("FirstName: " + lastName);


            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("FirstName: " + names[1]);

            Console.WriteLine(fullName.Replace("Mosh", "Boly"));

            if (String.IsNullOrEmpty(fullName))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0")); */

            var sentence = "This is going to be a really really really really really really really really long tex.";
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);

        }


            
     }
}
