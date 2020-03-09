using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Models
{
    public class AnagramCheck
    {
        public static string InitialWord {get; set;}
        public static string Result {get; set;}
        public static List<string> OriginalAnagrams = new List<string>() {};

        public static List<string> ConvertedAnagrams = new List<string>() {};
        public static List<string> ConvertedAnagrams2 = new List<string>() {};

        public static string trimedAnagram;
        public AnagramCheck(string initialWord)
        {
          InitialWord = initialWord;
        }
        public void userInitialAnagram()
        {
            char [] InitialWordArray = InitialWord.ToCharArray();
            Array.Sort(InitialWordArray);
            Result = new string (InitialWordArray);
            Result = Result.ToLower();
        }

        public void UserAnagram(string userAnagram)
        {
            OriginalAnagrams.Add(userAnagram);
            char [] anagramCheckArray = userAnagram.ToCharArray();
            Array.Sort(anagramCheckArray);
            string converted = new string (anagramCheckArray);
            converted = converted.ToLower();
            ConvertedAnagrams.Add(converted);
        }
        public void AnagramChecker()
        {
          for (int i = 0; i < ConvertedAnagrams.Count; i++)
          {
            if (Result == ConvertedAnagrams[i])
            {
              Console.WriteLine($"'{OriginalAnagrams[i]}' is an Anagram for '{InitialWord}'");
            }
            else if (Result == ConvertedAnagrams2[i]) {
              Console.WriteLine($"'{OriginalAnagrams[i]} is a partially Anagram for '{InitialWord}'");
            } else {
              Console.WriteLine($"No match for '{OriginalAnagrams[i]}'");
            }
          }
        }

        public void userPartialAnagram(string userAnagram)
        {   
            string converted = "";
              for (int x = 0; x <userAnagram.Length; x++)
              {
                if (!( Result.Contains(userAnagram[x])))
                {
                  userAnagram = userAnagram.Replace(userAnagram[x],' ').Trim();
                  char [] partialAnagramCheck = userAnagram.ToCharArray();
                  Array.Sort(partialAnagramCheck);
                  converted = new string(partialAnagramCheck);
                  converted = converted.ToLower();
            
                }
              }
              ConvertedAnagrams2.Add(converted);
           }

        public void PartialAnagramChecker()
        {
          for (int i = 0; i <ConvertedAnagrams2.Count; i++)
          {
            if (Result == ConvertedAnagrams2[i])
            {
              Console.WriteLine($"'{OriginalAnagrams[i]} is a partial Anagram for '{InitialWord}'");
            }
          }
        }
  }
}
