using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem5
    {
        public Int64 Execute()
        {
            /*
            2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
             */
            Int64 num = 20;
            Int64 result = 1;
            List<Int64> usedDigits = new List<Int64>();
            for (Int64 i = num; i > 0; i--)
            {
                List<Int64> primeFactors = Utilities.GetPrimeFactors(i);
                List<Int64> listDiff = Utilities.ListDiff(primeFactors, usedDigits, Utilities.ListDiffMode.FirstListOnly);
                
                result *= Utilities.Multiply(listDiff); 
                usedDigits.AddRange(listDiff);
            }

            Console.WriteLine(result);
            return result;
        }
    }
}
