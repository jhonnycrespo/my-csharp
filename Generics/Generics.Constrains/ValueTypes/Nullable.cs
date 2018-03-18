// where T : IComparable
// where T : Product (or any of its subclasses)
// where T : struct (if T should be a value type)
// where T : class (if T should be a reference type)
// where T : new() (if T is an object that has a default constructor)

namespace Generics.Constrains.ValueTypes
{
    // value types cannot be null
    // we can use this class to give our value types the ability to be nullable
    public class Nullable<T> where T : struct
    {
        // boxing
        private object _value;

        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                // unboxing
                return (T)_value;
            }

            return default(T);
        }
    }
}
