using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        //In your WordSmith class, you will create a method(IsAPalindrome) 
        //that will take a parameter of type string and return a value of type bool.  
        //If the given input is a palindrome – return true, else return false. 
        public bool IsAPalindrome(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            var reversed = new string(charArray);

            if (reversed == word)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
