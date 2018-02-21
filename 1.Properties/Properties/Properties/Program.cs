using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Person
    {
        // Fields are normal variable members of a class. Generally, you should declare your fields as
        // private, then use Properties to get and set their values. This is a common practice, since
        // having public members violates the Encapsulation concept in OOP.
        private int id;
        private string name;
        private string lastName;
        private DateTime birthDate;

        // Properties ca be used as if they are public data members, but they are actually special methods
        // called "accessors". They are called this way because they offer a way to get and set a field.
        // the get and set keywords are called "property accessors"
        public int Id
        {
            get { return id; }
            // the "value" keyword refers to the assigned value.
            set { id = value; }
        }

        // In Java, We need to declare getters and setters methods, But, In C#, You can defined a property
        // for each field.
        // Properties can be used to read-only or write-only other fields. This can be done by declaring only
        // either get or set.
        public string Name
        {
            get { return name; }
        }
        
        // Also they can have access modifiers, like private, so you can only get or set their values
        // inside their class.
        public DateTime BirthDate
        {
            get { return birthDate; }
            private set { birthDate = value; }
        }

        // we can also use properties to compute the value of a private field.
        // Property accessors often consist of single-line statements that just assign or return
        // the result of an expression. You can implement these properties as expression-bodied members.
        // Expression body definitions consist of the => symbol followed by the expression to assign to or
        // retrieve from the property.

        // Starting with C# 6, read-only properties can implement the "get" accessor as an expression-bodied
        // member. In this case, neither the get accessor keyword nor the return keyword is used.
        public string FullName => $"{name} {lastName}";

        // Starting with C# 7, both the get and set accessors can be implemented as expression-bodied. In this case,
        // the get and set keywords must be present.
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        // Auto-implemented Properties
        // In some cases, property get and set accessors just assign a value to or retrieve a value from a backing
        // field without including any additional logic. By using auto-implemented properties, you can simplify your
        // code while having the C# compiler transparently provide the backing field for you.
        public int Phone { get; set; }
    }

    public class SaleItem
    {
        string name;
        decimal cost;

        public SaleItem(string name, decimal cost)
        {
            this.name = name;
            this.cost = cost;
        }

        // Starting with C# 7, both the get and set accessors can be implemented as expression-bodied. In this case,
        // the get and set keywords must be present.
        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal Price
        {
            get => cost;
            set => cost = value;
        }
    }

    public class SaleItem2
    {
        // You define an auto-implemented property by using the get and set keywords without providing any implementation.
        // The following example repeats the previous one, except that Name and Price are auto-implemented properties. Note
        // that the example also removes the parameterized constructor, so that SaleItem objects are now initialized with a
        // call to the default constructor and an object initializer.
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
