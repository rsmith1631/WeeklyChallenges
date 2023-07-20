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
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }

        }

        public long Multiply(long factor1, long factor2)
        {
            return (long) factor1 * factor2;
        }

        public string GetGreeting(string personName)
        {
            if(personName != "")
            {
                return $"Hello,  {personName}!";
            }
            else
            {
                return "Hello!";
            }
        }

        public string GetHey()
        {
            return "Hey!";

        }
    }
}

