using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem7
    {
        public Int64 Execute()
        {
            /*
              By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

              What is the 10 001st prime number?
            */
            Int64 result = 1;
            Int64 primeCount = 0;
            Int64 primeStep = 1000;
            Int64 primeRangeMax = 2;
            Int64 primesToFind = 10001;
            while (primeCount < primesToFind)
            {
                primeRangeMax += primeStep;
                primeCount += Utilities.FindPrimes(primeRangeMax - primeStep, primeRangeMax).Count();
            }
            List<Int64> primeList = Utilities.FindPrimes(primeRangeMax - primeStep, primeRangeMax);
            Console.WriteLine(primeCount);
            Console.WriteLine(primeRangeMax);
            Utilities.PrintList(primeList);
            Console.WriteLine(primesToFind + "th prime is " +  primeList[primeList.Count() - (int)(primeCount - primesToFind) - 1]);

            return result;
        }
    }
}
