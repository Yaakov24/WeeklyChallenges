using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
            var result = true;
            int? prevNum = null;
            if (numbers == null || numbers.Length == 0) return false;
             
            foreach(int number in numbers)
            {
               if(prevNum == null) 
                { 
                    prevNum = number;
                    continue;
                }
               if(number <  prevNum)
                {
                    return false;
                }
                else
                {
                    prevNum = number;
                }
            }
            return result;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var result = 0;
            if(numbers == null || numbers.Length == 0) return result;
            
            for(var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result += numbers[i + 1];
                }
            }
            return result;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string str = "";
            if(words ==  null || words.Length == 0) { return str; }
           for(var i = 0; i < words.Length; i++)
            { if (words[i].Trim() == "")
                {
                    continue;
                }
                var separator = i == words.Length - 1 ? "." : " ";
                str += words[i].Trim() + separator;
                
            }
           return str;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            var fourthE = new List<double>();
            for(var i = 3; i < elements.Count; i += 4)
            {
                    fourthE.Add(elements[i]);
            }
            return fourthE.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        { 
            for(var i = 0;i < nums.Length;i++) 
            {
                for(var j = i + 1;j < nums.Length;j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
           return false;
        }
    }
}
