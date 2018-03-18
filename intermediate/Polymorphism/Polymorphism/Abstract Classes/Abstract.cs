using System;

namespace Polymorphism.Abstract_Classes
{

    public class Abstract
    {
        public void Test()
        {
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }

    // the abstract keyword indicates that the class or a its members
    // is missing implementation.
    // if a member is declared abstract, the containing class needs to
    // be declared as abstract too.
    // Abstract classes cannot be instantiated.
    public abstract class Shape
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

    // derived classes must implement all abstract methods in the base abstract class.
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    // derived classes must implement all abstract methods in the base abstract class.
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
}
