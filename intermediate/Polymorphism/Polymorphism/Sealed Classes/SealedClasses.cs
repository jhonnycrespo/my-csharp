using System;

namespace Polymorphism.Sealed_Classes
{
    internal abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // abstract methods don't include implementation.
        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copying shape into clipboard");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape");
        }
    }

    // the sealed modifier prevents derivation of classes or overriding of methods.
    internal sealed class Circle : Shape
    {
        // si declaramos la clase como sealed no es necesario declarar los metodos
        // como sealed.
        public sealed override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    class SealedClasses
    {
    }
}
