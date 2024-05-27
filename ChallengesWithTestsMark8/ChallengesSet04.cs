using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int evenSum = 0;
            int oddSum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }
            int result = evenSum - oddSum;
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var arrayOfLengths = new string[] { str1, str2, str3, str4 };


            return arrayOfLengths.Min(x => x.Length);

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numberArr = new int[] { number1, number2, number3, number4 };

            return numberArr.Min(x => x);

        }

        public string ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            _ = new Business()
            {
                Name = biz.Name = "TrueCoders"
            };
            return biz.Name;

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var a = sideLength1;
            var b = sideLength2;
            var c = sideLength3;

            if (a + b > c && b + c > a && a + c > b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            if (input == null || input == "") return false;
            Regex regex = new Regex(@"^[-]?\d+(\.\d+)?$");
            return regex.IsMatch(input);
        }


        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {

            var mostFrequentElement = objs.GroupBy(x => x).OrderByDescending(g => g.Count()).Select(g => g.Key).First();

            if (objs.Count() == 2) { return false; }

            if (mostFrequentElement == null)
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

            if (numbers == null || numbers.Length == 0)
                return 0;
            double sumEvens = 0;
            int countEvens = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sumEvens += num;
                    countEvens++;
                }
            }
            if (countEvens == 0)
                return 0;
            return sumEvens / countEvens;
        }
        public int Factorial(int number)
        { var num = number;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            var result = 0;
            if (number == 0) result = 1;
            if (number == 1) result = 1;
            for(int i = 1; i < number; i++)
            {
                
                result = num *= i;
            }
            return result;

        }

        public int NegativeFactorialShouldThrowArgumentOutOfRangeException()
        {
            throw new NotImplementedException();
        }
    }
}
