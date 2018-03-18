using System.Collections;

namespace Generics.Inheritance
{
    class Node<T>
    {
        public T Data { get; set; }
    }

    class GenericArrayList<T> : IArrayList<T>, IEnumerable
    {
        private const int DefaultSize = 8;
        private T[] listArray;

        public GenericArrayList()
        {
            listArray = new T[DefaultSize];
        }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
