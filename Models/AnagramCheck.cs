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

        public static List<string> ConsecutiveAnagram = new List<string>() {};
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
          Console.WriteLine(ConsecutiveAnagram[0]);
          Console.WriteLine(ConsecutiveAnagram[1]);

          for (int i = 0; i < ConvertedAnagrams.Count; i++)
          {
            if (Result == ConvertedAnagrams[i])
            {
              Console.WriteLine($"'{OriginalAnagrams[i]}' is an Anagram for '{InitialWord}'");
            }
            else if (Result == ConvertedAnagrams2[i]) 
            {
              Console.WriteLine($"'{OriginalAnagrams[i]} is a partially Anagram for '{InitialWord}'");
            } 
            else if (ConsecutiveAnagram[i] == "true")
            {
              Console.WriteLine($"'{OriginalAnagrams[i]} is a partially Anagram for '{InitialWord}'");
            }
            else 
            {
              Console.WriteLine($"No match for '{OriginalAnagrams[i]}'");
            }
          }
        }

        public void userPartialAnagram(string userAnagram)
        {   
            
            List<int> userCharIndexNumbers = new List<int>(){};
            List<int> anagramCharIndexNumbers = new List<int>(){};
            int userCharIndex = 0;
            int anagramCharIndex = 0;
            int userAnagramLength = 0;

            char[] arrayUserAnagram = userAnagram.ToCharArray();
            Array.Sort(arrayUserAnagram);
            string sortedUserAnagram = new string(arrayUserAnagram);
              
              for (int i = 1; i < Result.Length; i++)
                 
                { if(Result[i-1] == Result[i])
                  userCharIndex++;
                } userCharIndexNumbers.Add(userCharIndex);

              for (int y = 1; y < sortedUserAnagram.Length; y++ )
                   { if(sortedUserAnagram[y-1] == sortedUserAnagram[y])
                     anagramCharIndex++;
                   } anagramCharIndexNumbers.Add(anagramCharIndex);

              for (int z = 0; z < userAnagram.Length; z++)
                    {
                      if(Result.Contains(userAnagram[z]))
                      userAnagramLength++;
                    }
              string converted = "";

              for (int x = 0; x <userAnagram.Length; x++)
              {
                if (!(Result.Contains(userAnagram[x])))
                {
                  userAnagram = userAnagram.Replace(userAnagram[x],' ').Trim();
                  char [] partialAnagramCheck = userAnagram.ToCharArray();
                  Array.Sort(partialAnagramCheck);
                  converted = new string(partialAnagramCheck);
                  converted = converted.ToLower();
                }
              }ConvertedAnagrams2.Add(converted);             

              if (userAnagramLength == userAnagram.Length && anagramCharIndex > userCharIndex)
                {
                  ConsecutiveAnagram.Add("true");
                }          
              else if (!(userAnagramLength == userAnagram.Length && anagramCharIndex > userCharIndex))
                {
                  ConsecutiveAnagram.Add("false");
                }
           }
  }
}
