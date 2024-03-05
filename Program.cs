using System;
using System.Collections.Generic;
/*
* Author:  Jacob Autrey
* Course:  COMP-003A-L01
* Purpose: Assignment 7
*/

namespace COMP003A.Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Array - CharacterCounter");
            Console.WriteLine("Please enter a letter");
            char letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please enter a workd");
            string word = Console.ReadLine();
            Console.WriteLine("There are " + CharacterCounter(letter, word) +  " " + letter + " in the word " +  word);

            SectionSeparator("Array - IsPalindrome");
            Console.WriteLine("Please enter a word to check if it is a palindrome");
            string isIt = Console.ReadLine();
            if (IsPalindrome(isIt) == true)
            {
                Console.WriteLine(isIt + " is a palindrome");
            }
            else
            {
                Console.WriteLine(isIt + "is not a palindrome");
            }
            

            SectionSeparator("List - Add");
            List<string> names = new List<string>();
            string action;
            do
            {
                Console.WriteLine("Please enter a name");
                names.Add(Console.ReadLine());
                Console.WriteLine("Press any key to add more or (e) to exit");
                action = Console.ReadLine();
            }
            while (action != "e");


            SectionSeparator("List - Traversal");
            TraverseList(names);

            SectionSeparator("List - Reverse Traversal");
            TraverseListReverse(names);
        }
        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(60, '*') + $"\n\t{section} Section \n" + "".PadRight(60, '*'));
        }

        static int CharacterCounter(char characterInput, string word)
        {
            int count = 0;
            characterInput = char.ToLower(characterInput);
            word = word.ToLower();
            foreach(char character in word)
            {
                if(characterInput == character)
                {
                    count++;
                }
            }

            return count;
        }

        
        static bool IsPalindrome(string word)
        {
            string drow = "";
            word = word.ToLower();
            for (int i = word.Length - 1; i>= 0; i--)
            {
                drow = drow + word[i];
            }
            if(drow == word)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        
        static void TraverseList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void TraverseListReverse(List<string> list)
        {
            for (int i = list.Count - 1; i>= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }
       

    }
}
