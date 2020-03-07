using System;
using System.Collections.Generic;

namespace Anagram.Models
{
    public class AnagramCheck
    {
        public static string InitialWord {get; set;}
        public static string Result {get; set;}
        public static List<string> OriginalAnagrams = new List<string>() {};
        public static List<string> ConvertedAnagrams = new List<string>() {};
        public AnagramCheck(string initialWord)
        {
          InitialWord = initialWord;
        }
        public void userInitialAnagram()
        {
            char [] InitialWordArray = InitialWord.ToCharArray();
            Array.Sort(InitialWordArray);
            Result = new string (InitialWordArray);
        }

        public void UserAnagram(string userAnagram)
        {
            OriginalAnagrams.Add(userAnagram);
            char [] anagramCheckArray = userAnagram.ToCharArray();
            Array.Sort(anagramCheckArray);
            string converted = new string (anagramCheckArray);
            ConvertedAnagrams.Add(converted);
        }
        public void AnagramChecker()
        {
          for (int i = 0; i < ConvertedAnagrams.Count; i++)
          {
            if (Result == ConvertedAnagrams[i])
            {
              Console.WriteLine($"{OriginalAnagrams[i]} is an Anagram for {InitialWord}");
            }
          }
        }
  }
}
