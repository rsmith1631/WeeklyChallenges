using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                if (number % 2 != 0)
                {
                    sum -= number;
                }
            }
            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var total = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return total.Min();

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var number = new List<int>() { number1, number2, number3, number4 };
            return number.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";              
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3 &&
                sideLength3 + sideLength1 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out var number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;
            var count = 0;
            foreach (var num in objs)
            {
                if (objs == null)
                {
                    count++;
                }
                
            }
            if (count >= majority)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public double AverageEvens(int[] numbers)
        {
            var average = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    average += numbers[i];
                }
            }

            return average / numbers.Length;
        }

        public int Factorial(int number)
        {
            
        }
    }
}
