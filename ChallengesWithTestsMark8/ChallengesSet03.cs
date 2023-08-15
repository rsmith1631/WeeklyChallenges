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
            if ((numbers == null) || (numbers.Count() == 0))
            {
                return false;
            }
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
            var upper = false;
            var lower = false;
            var number = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    upper = true;
                }
                if (char.IsLower(password[i]))
                {
                    lower = true;
                }
                if (char.IsNumber(password[i]))
                {
                    number = true;
                }
            }
            if ((upper == true) && (lower == true) && (number == true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
            
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
           for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
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