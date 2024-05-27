using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var result = 0;
            for(int i = startNumber +1;i <= startNumber + n;i++)
            {
               if(i % n == 0)
                {
                    result = i;
                    break;
                };
            }
            return result;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {  
            var result = false;
            foreach(int number in numbers)
            {
                if (number == null || number == 0 )
                {
                    result = false;
                }
                if (number >= number)
                { 
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var result = 0;
            for(var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result = numbers[i]++;
                }
            }
            return result;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
