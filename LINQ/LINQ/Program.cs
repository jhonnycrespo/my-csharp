using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // the query variable itself only stores the query commands. The actual
            // execution of the query is deferred until you iterate over the query
            // variable in a foreach statement. This concept is referred to as deferred
            // execution and is demonstrated in the following example:
            var numQuery = from num in numbers
                where (num % 2) == 0
                select num;

            // To force immediate execution of any query and cache its results, you can
            // call the ToList or ToArray methods.
            var oddNumbers = (from num in numbers
                where (num % 2) == 0
                select num).ToList();

            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
        }
    }
}
