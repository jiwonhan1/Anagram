using System;
using System.Collections.Generic;

namespace Anagram.Models
{
    public class AnagramCheck
    {
        public static char[] Initialwordarray;
        public static string result;

        public static List<string> userAnagram = new List<string>() { };
        public static List<string> FinalCheck = new List<string>() { };

        public static void AnagramChecker(string userinput)
        {
            Initialwordarray = userinput.ToCharArray();

            for (int i = 0; i < userinput.Length; i++)
            {
                Console.WriteLine(Initialwordarray[i]);
            }

            Array.Sort(Initialwordarray);
            result = new string(Initialwordarray);
            Console.WriteLine(result);
            FinalCheck.Add(result);
            for (int i = 0; i < FinalCheck.Count; i++)
            {
                Console.WriteLine(FinalCheck[i]);
            }

        }



    }
}