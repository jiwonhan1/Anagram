using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Wordcheck
{
    public class Wordchecker
    {
        // AnagramCheck anagramCheck = new AnagramCheck();
        static void Main()
        {
            // List<string> userAnagram = new List<string>() { };
            Console.WriteLine("Input your Word");
            string userinput = Console.ReadLine();
            AnagramCheck.Anagram(userinput);


            Console.WriteLine("Enter other word that you want to check it for Anagram");
            string userAnagram1 = Console.ReadLine();
            AnagramCheck.UserAnagram(userAnagram1);

            AnagramCheck.userAnagramList.Add(userAnagram1);
            Console.WriteLine("Enter another word.");
            string userAnagram2 = Console.ReadLine();
            AnagramCheck.userAnagramList.Add(userAnagram2);

            AnagramCheck.UserAnagram(userAnagram2);

            Console.WriteLine(AnagramCheck.result);

            AnagramCheck.AnagramChecker();
        //    Console.WriteLine(AnagramCheck.FinalChecker());

            // for(int i = 1; i < AnagramCheck.FinalCheck.Count; i++)
            // {
            //   if (AnagramCheck.FinalCheck[0] == AnagramCheck.FinalCheck[i])
            //   {
            //     Console.WriteLine('hi');
            //   }
            //   else
            //   {
            //     Console.WriteLine('hello');
            //   }
            }

        }

}
