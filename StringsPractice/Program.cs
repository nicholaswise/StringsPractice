﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Nick";
            //int lengthOfName = firstName.Length;
            //Console.WriteLine(firstName);
            //Console.WriteLine(lengthOfName);
            //string myFavoriteQuote = "\"I want to go to there\" - Liz Lemon";
            //Console.WriteLine(myFavoriteQuote);

            //string escapeString = "I want a tab after this line \t I want a new line without WriteLine \nHi";
            //string escapeString2 = "I want to show a backslash here \\ Hey what's that noise? \a";
            //Console.WriteLine(escapeString);
            //Console.WriteLine(escapeString2);

            //Console.WriteLine("User one, please type something");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User two, please type something");
            //string userTwoInput = Console.ReadLine();

            //if (userOneInput.Equals(userTwoInput))
            //{
            //    Console.WriteLine("User two is a copy cat!");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original!");
            //}

            //string startOfSentence = "My best friend's name is ";
            //string endOfSentence = "Brittany.";

            //Console.WriteLine(startOfSentence + endOfSentence);

            //Console.WriteLine("My Friend " + endOfSentence + " has a cute kid.");

            //Console.WriteLine("This is a tab \t\nThis is a backslash \\\nThis is a bell sound \a");

            //string firstName = "Nick";
            //int lengthOfName = firstName.Length;
            //Console.WriteLine(firstName + " is " + lengthOfName + " letters long.");

            //string lastName = "Wise";
            //int lengthLastName = lastName.Length;
            //Console.WriteLine(lastName + " is " + lengthLastName + " letters long.");

            //if (lengthOfName == lengthLastName)
            //{
            //    Console.WriteLine("Samesies!");
            //}
            
            //Name equality
            string nameName = "Nick";
            string otherName = "Mick";

            Console.WriteLine(nameName + otherName);

            if (nameName.Equals(otherName))
            {
                Console.WriteLine("These names are the same");
            }            
            else if (nameName != otherName)
            {
                Console.WriteLine("Not the same");
            }
            //Concatenation next ->

        }
    }
}
