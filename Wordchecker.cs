using System;
using Anagram.Models;

namespace Wordcheck
{
    public class Wordchecker
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Anagram!");
            Console.WriteLine("An anagram is a word that you can rearrange the letters and it becomes a new word. \nFor example, 'bread' is an anagram of 'beard'.");
            Console.WriteLine("You will have a chance that you provide a word and two other words that you want to check for Anagrams with the word initially provided.");
            Console.WriteLine("");

            bool validAnswer = false;

            while(validAnswer == false)
            {
                Console.WriteLine("Would you like to play? Answer with this format [Y for yes / N for no]");
                string playerAnswer = Console.ReadLine().ToLower();

                if(playerAnswer == "y")
                {
                    validAnswer = true;
                    Play();
                }
                else if (playerAnswer == "n")
                {
                    validAnswer = true;
                    Console.WriteLine("Good Bye!");
                }
                else 
                {
                    Console.WriteLine("Invalid input. Please enter Y or N.");
                    validAnswer = false;
                }
            }
        }
        static void Play()
        {
            Console.WriteLine("Please input your word");
            string userInitialWord = Console.ReadLine();
            AnagramCheck anagramCheck = new AnagramCheck(userInitialWord);
            anagramCheck.userInitialAnagram();

            Console.WriteLine("Enter other word that you want to check it for Anagram");
            string userAnagram1 = Console.ReadLine();
            anagramCheck.UserAnagram(userAnagram1);
            anagramCheck.userPartialAnagram(userAnagram1);

            Console.WriteLine("Enter another word.");
            string userAnagram2 = Console.ReadLine();
            anagramCheck.UserAnagram(userAnagram2);
            anagramCheck.userPartialAnagram(userAnagram2);

            anagramCheck.AnagramChecker();

        }
    }
        
}
