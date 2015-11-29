using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem6
    {
        public Int64 Execute()
        {
            /*
           The sum of the squares of the first ten natural numbers is,

            12 + 22 + ... + 102 = 385
             
            The square of the sum of the first ten natural numbers is,

            (1 + 2 + ... + 10)2 = 552 = 3025
             
            Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

            Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
             * */
            Int64 result = 1;
            Int64 num = 100;
            List<Int64> list = new List<Int64>();
            foreach (int item in Enumerable.Range(1, (int)num).ToList())
            {
                list.Add((Int64)item);
            }
            Console.WriteLine(Math.Pow((double)Utilities.Sum(list), 2) - Utilities.Sum(Utilities.Square(list)));


            return result;
        }
    }
}
