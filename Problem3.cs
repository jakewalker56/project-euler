using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem3
    {
        public Int64 Execute()
        {
            /*
             The prime factors of 13195 are 5, 7, 13 and 29.
            What is the largest prime factor of the number 600851475143 ?
             */
            List<Int64> primeFactors = Utilities.GetPrimeFactors(600851475143);
            foreach (Int64 primeFactor in primeFactors)
            {
                Console.WriteLine("Found Prime Factor: " + primeFactor);
            }
            primeFactors.Sort();
            Int64 result = primeFactors.Max();
            return result;
        }
    }
}
