using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem10
    {
        public Int64 Execute()
        {
            /*
             The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

             Find the sum of all the primes below two million.
             */
            Int64 result = Utilities.Sum(Utilities.FindPrimes(2, 2000000));
            Console.WriteLine(result);
            return result;
        }
    }
}
