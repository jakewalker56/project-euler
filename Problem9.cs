using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem9
    {
        public Int64 Execute()
        {
            /*
             A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

            a2 + b2 = c2
            For example, 32 + 42 = 9 + 16 = 25 = 52.

            There exists exactly one Pythagorean triplet for which a + b + c = 1000.
            Find the product abc.
             */
            Int64 result = 0;
            int limit = 1000;
            for (int i = 1; i < limit; i++)
            {
                for (int j = 1; j < limit - i; j++)
                {
                    int k = limit - i - j;
                    if (Utilities.IsPythagorean(i, j, k))
                    {
                        Console.WriteLine("Pythagorean triplet: " + i + ", " + j + ", " + k);
                         result = i * j * k;
                        Console.WriteLine("Pythagorean product: " + result);
                    }
                }
            }
            return result;
        }
    }
}
