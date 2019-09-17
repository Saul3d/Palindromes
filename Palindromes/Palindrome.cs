using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromes
{
    public class Palindrome
    {
        public bool checkIfPalindromeWord(string word)
        {
            var lowerCaseWord = word.ToLower();
            var removedSpacesLCW = lowerCaseWord.Replace(" ", "");
            var removedCommaLCW = removedSpacesLCW.Replace(",", "");
            var removedEMLCW = removedCommaLCW.TrimEnd('!');
            char[] charArray = removedEMLCW.ToCharArray();
            Array.Reverse(charArray);
            var reversedWord = new string (charArray);
            if (reversedWord == removedEMLCW)
            {
                return true;
            }

            return false;
        }
    }
}
