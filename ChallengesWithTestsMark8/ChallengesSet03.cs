using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
          for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var sum = numbers.Sum();
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
           
        }

        public char GetFirstLetterOfString(string val)
        {
           
        }

        public char GetLastLetterOfString(string val)
        {

            
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            
        }

        public int LastMinusFirst(int[] nums)
        {
            
        }

        public int[] GetOddsBelow100()
        {
           
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
           for (int i = 0; i < words.Length; i++)
            {
     
            }
            
        }

        public char FindMissingLetter(char[] array)
        {
            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            if (char.IsUpper(array[0]))
            {
                letters = "abcdefghijklmnopqrstuvwxyz".ToUpper().ToCharArray();
            }
            var place = 0;
            for (int j =0; j < letters.Length; j++)
            {
                if (array[0] == letters[j])
                {
                    place = j;
                    break;
                }
            }
            char missing = '_';
            for (int i = 0; i < letters.Length;i++)
            {
                if (array[i] != letters[place])
                {
                    missing = letters[place];
                    break;
                }
                place++;
            }
            return missing;
        }
    }
}