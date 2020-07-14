using System;
using System.Collections.Generic;
using System.Linq;

namespace WeeklyChallenges
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Count() % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 == 1 || num % 2 == -1;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null) return 0;
            if (!numbers.Any()) return 0;
            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length > str2.Length ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) return 0;
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            var evens = numbers.Where(x => x % 2 == 0);
            return evens.Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) return false;
            return numbers.Sum() % 2 == 1 || numbers.Sum() % 2 == -1;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number > 0) return number / 2;
            return 0;
        }
    }
}
