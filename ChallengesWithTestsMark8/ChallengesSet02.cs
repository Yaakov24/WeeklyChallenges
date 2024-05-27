using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

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
            if (vals.Length % 2 == 0)
            {
                return true;

            }
            else if (vals.Length % 2 != 0)
            {
                return false;
            }
            else
            {
                return true;
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
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            if (numbers.Count() == null)
            {
                return 0;
            }
            var num = numbers.Where(x => x % 2 == 0).Sum();
            return num;
        }


        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var numSum = numbers.Sum();
            if (numSum % 2 != 0)
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
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }



        }
    }
}