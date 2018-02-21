using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Extension methods enable you to add methods to existing 
// types without creating a new derived type, recompiling, or 
// otherwise modifying the original type.

// Extension methods are a special kind of static method, but they
// are called as if they were instance methods on the extended type.

namespace ExtensionMethod
{
    public static class MyExtension
    {
        // An extension method is a static method of a static class, where 
        // the "this" modifier is applied to the first parameter. The type 
        // of the first parameter will be the type that is extended.
        public static string GetLastLetter(this string str)
        {
            return str.Substring(str.Length - 1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str = "foo";
            Console.WriteLine(str.GetLastLetter());

            // The most common extension methods are the LINQ standard query operators
            // that add query functionality to the existing System.Collections.IEnumerable
            // and System.Collections.Generic.IEnumerable<T> types.

            IEnumerable<int> list = new List<int>() {8, 2, 12, 4, 5};

            // sort in ascending order
            var result = list.OrderBy(g => g);

            foreach (var n in result)
            {
                Console.WriteLine(n + " ");
            }
        }
    }
}
