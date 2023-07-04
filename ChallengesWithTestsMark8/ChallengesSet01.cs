﻿using Microsoft.VisualBasic;
using System;
using System.Net.Security;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Add(int addend1, int addend2)
        {
            return addend1 + addend2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {

            {
                return number1 < number2 ? number1 : number2;
            }

        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }

        public string GetGreeting(string personName)
        {
            if (string.IsNullOrWhiteSpace(personName))
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {personName}!";
            }
        }

        public string GetHey()
        {
            string hey = "HEY!";
            Console.WriteLine(hey);
            return hey;

        }
    }
}

