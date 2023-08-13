using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02  
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
       
               if (vals.Length - 1 % 2 == 0)
                {
                return true; 
                }
               else
            {
                return false;
            }
            
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
           var answer = (num % 2 != 0) ? true : false;
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var strin1 = 0;
           for (int i = 0; i < str1.Length; i++)
            {
                strin1 = str1.Length;
            }
            var strin2 = 0;
           for (int i =0; i < str2.Length; i++)
            {
                strin2 = str2[i];
            }
           if (strin1 < strin2)
            {
                return strin1;
            }
           else
            {
                return strin2;
            }

        }

        public int Sum(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                return numbers[i];
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            var sumEvens = 0;
          for (int i = 0; i < numbers.Length; i++)
          {
                if (numbers[i] % 2 == 0)
                {
                    sumEvens = numbers[i];
                }
          }
            return sumEvens;
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            var sumOdd = new List<int>();
            var sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
          if (number == null)
            {
                return 0;
            }
            return number / 2;
        
        }
    }
}
