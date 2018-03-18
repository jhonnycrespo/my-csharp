using System;

// where T : IComparable
// where T : Product (or any of its subclasses)
// where T : struct (if T should be a value type)
// where T : class (if T should be a reference type)
// where T : new() (if T is an object that has a default constructor)

namespace Generics.Constraints
{
    class Utilities
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // generic method inside non-generic class
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    // this works too
    class Utilities2<T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // generic method inside non-generic class
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    public class Product
    {
        public float Price { get; set; }
        public string Title { get; set; }
    }

    public class Book : Product
    {
        public string Isbn { get; set; }
    }

    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price - 10;
        }
    }
}
