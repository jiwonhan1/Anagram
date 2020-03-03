using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Wordcheck
{
    public class Wordchecker
    {

        static void Main()
        {
            // List<string> userAnagram = new List<string>() { };
            Console.WriteLine("Input your Word");
            string userinput = Console.ReadLine();
            AnagramCheck.AnagramChecker(userinput);


            Console.WriteLine("Enter other word that you want to check it for Anagram");
            string userAnagram1 = Console.ReadLine();
            AnagramCheck.AnagramChecker(userAnagram1);

            AnagramCheck.userAnagram.Add(userAnagram1);
            Console.WriteLine("Enter another word.");
            string userAnagram2 = Console.ReadLine();
            AnagramCheck.userAnagram.Add(userAnagram2);

            AnagramCheck.AnagramChecker(userAnagram2);

            //Console.WriteLine("List" + AnagramCheck.userAnagram[0]);

        }
    }
}