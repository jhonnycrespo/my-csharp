using System;

namespace Generics.Constrains
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value ? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            var number2 = new Nullable<int>();
            Console.WriteLine("Has Value ? " + number2.HasValue);
            Console.WriteLine("Value: " + number2.GetValueOrDefault());
        }
    }
}
