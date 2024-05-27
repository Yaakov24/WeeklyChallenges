using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Windows.Markup;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {


            bool containsFalse = vals.Contains(false);
            if (containsFalse)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            return numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;


        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            bool containsAll = password.Any(x => char.IsUpper(x)) && password.Any(x => char.IsLower(x)) && password.Any(x => char.IsNumber(x));
            return containsAll;

        }

        public char GetFirstLetterOfString(string val)
        {
            var firstChar = val.First();
            return firstChar;
        }

        public char GetLastLetterOfString(string val)
        {
            var lastChar = val.Last();
            return lastChar;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {

            if (divisor == 0)
            {
                return 0;
            }
            var result = dividend / divisor;
            return result;

        }

        public int LastMinusFirst(int[] nums)
        {
            var result = nums.Last() - nums.First();
            return result;
        }

        public int[] GetOddsBelow100()
        {
            var oddNumbers = Enumerable.Range(0, 100).Where(x => x % 2 != 0);
            return oddNumbers.ToArray();
        }

        public string[] ChangeAllElementsToUppercase(string[] word)
        {

            for (int i = 0; i < word.Length; i++)
            {
                word[i] = word[i].ToUpper();
            }
            return word;

        }

    }
}
