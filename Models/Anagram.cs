using System;
using System.Collections.Generic;

namespace Anagram.Models
{
    public class AnagramCheck
    {
        public static char[] Initialwordarray;
        public static string result;

        public static List<string> userAnagramList = new List<string>() { };
        public static List<string> Anagrams = new List<string>() {};

        public static void Anagram(string userinput)
        {
            Initialwordarray = userinput.ToCharArray(0, userinput.Length);
            Array.Sort(Initialwordarray);
            result = new string (Initialwordarray);

        }

        public static void UserAnagram(string userInput)
        {
            char [] anagramCheckArray = userInput.ToCharArray();
            Array.Sort(anagramCheckArray);
            string converted = new string (anagramCheckArray);
            Anagrams.Add(converted);
        }

        public static void AnagramChecker()
        {
          for (int i = 0; i < Anagrams.Count; i++)
          {
            if (result == Anagrams[i])
            {
              Console.WriteLine(Anagrams[i]);
            }
          }
        }


        // public static void FinalChecker()
        // {
        //   for(int i = 1; i < FinalCheck.Count; i++)
        //   {
        //       if (FinalCheck[0] == FinalCheck[i]);
        //       {
        //         Anagram.Add(FinalCheck[i]);
        //       }
        //   }
        //
        // }
  }
}
