using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Utilities
    {
        public Int64[,] Parse2DArrayFromString(string s)
        {
            string[] rows = s.Split('\n');
            Int64 rowCount = rows.Count();
            List<string[]> columns = new List<string[]>();
            int maxColumnsCount = 0;
            for(int i = 0; i < rowCount; i++)
            {
                columns.Add(rows[i].Split(' '));
                maxColumnsCount = Math.Max(maxColumnsCount, columns[i].Count());
            }
            Int64[,] result = new Int64[maxColumnsCount, rowCount];
            return result;
        }
        public static Boolean IsPythagorean(int a, int b, int c)
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                return true;
            }
            return false;
        }
        public static void PrintList(List<Int64> list, string listName = "list")
        {
            Console.WriteLine("Printing " + listName);
            foreach (Int64 item in list)
            {
                Console.WriteLine("\t item: " + item);
            }
            return;
        }
        public enum ListDiffMode
        { 
            FirstListOnly,
            EachList
        }
        public static List<Int64> ListDiff(List<Int64> list1, List<Int64> list2, ListDiffMode mode = ListDiffMode.EachList)
        {
            List<Int64> diff = new List<Int64>();
            foreach (Int64 item in list1.Distinct())
            {
                for (int i = 0; i < list1.Where(item1 => item1 == item).Count() -
                    list2.Where(item2 => item2 == item).Count(); i++)
                {
                    diff.Add(item);
                }
                if (mode == ListDiffMode.EachList)
                {
                    for (int i = 0; i < list2.Where(item2 => item2 == item).Count() -
                        list1.Where(item1 => item1 == item).Count(); i++)
                    {
                        diff.Add(item);
                    }
                }
            }
            return diff;
        }
        public static List<Int64> GetPrimeFactors(Int64 num)
        {
            List<Int64> primes = Utilities.FindPrimes(2, 1000);
            Int64 primeLevel = 1000;
            List<Int64> primeFactors = new List<Int64>();
            while (!Utilities.IsPrime(num))
            {
                bool foundPrimeFactor = false;
                for (int i = 0; i < primes.Count(); i++)
                {
                    if (num % primes[i] == 0 && primes[i] != 1)
                    {
                        primeFactors.Add(primes[i]);
                        num /= primes[i];
                        foundPrimeFactor = true;
                    }
                }
                if (!foundPrimeFactor)
                {
                    //We didn't find any prime factor, but we know num isn't a prime.  
                    //We are also gaurenteed that there are no more prime factors less than
                    //  our current highest found prime factor.  We can replace our primes list
                    //  without fear.
                    primes = Utilities.FindPrimes(primeLevel, primeLevel + 1000);
                }
            }
            primeFactors.Add(num);
            return primeFactors;
        }
        public static Int64 Multiply(List<Int64> numbers)
        {
            Int64 result = 1;
            foreach (Int64 i in numbers)
            {
                result *= i;
            }
            return result;
        }
        public static Int64 Sum(List<Int64> numbers)
        {
            Int64 result = 0;
            foreach (Int64 i in numbers)
            {
                result += i;
            }
            return result;
        }
        public static List<Int64> Square(List<Int64> numbers)
        {
            List<Int64> result = new List<Int64>();
            foreach (Int64 i in numbers)
            {
                result.Add(i*i);
            }
            return result;
        }
        public static Int64 Factorial(Int64 number, Int64 stopNumber = 1)
        {
            Int64 result = 1;
            for (Int64 i = number; i >= stopNumber; i--)
            {
                result *= i;
            }
            return result;
        }
        public static List<Int64> FindPrimes(Int64 startingNumber, Int64 endingNumber)
        {
            //implementing Sieve of Eratosthenes algorithm
            //this fails for large enough differences between startingNumber and endingNumber

            if (endingNumber < startingNumber)
            {
                return null;
            }
            List<Int64> factors = new List<Int64>();
            for (Int64 i = startingNumber; i < endingNumber; i++)
            {
                if (IsPrime(i))
                {
                    factors.Add(i);
                }
            } 
            return factors;
        }
        public static Boolean IsPrime(Int64 number)
        {
            //TODO: cash all this in a static hash table, so we don't have to recalculate
            //every time
            if (number == 1)
            {
                return true;
            }

            Int64 count = (Int64)Math.Pow(number, 0.5) + 1;
            for (Int64 i = 2; i < count; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
