using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
             foreach (bool val in vals)
            {
                if (!val)
                {
                    return true;
                }
            }
            return false;
            
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isNumber = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    isUpper = true;
                }
                else if (char.IsLower(c))
                {
                    isLower = true;
                }
                else if (char.IsDigit(c))
                {
                    isNumber = true;
                }
            }
            return isUpper && isLower && isNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.FirstOrDefault();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.LastOrDefault();
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
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddsList = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0) 
                {
                    oddsList.Add(i);
                }
            }
            return oddsList.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
