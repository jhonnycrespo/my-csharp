using System;

namespace AccessModifiers
{
    // an access modifier is a way to control access to a class and/or its members.
    // We use it to create safety and improve robustness.

    // encapsulation/information hiding

    public class Person
    {
        // we can turn a field into a property like this.
        // this is called auto-property.
        private string Name { get; set; }

        // we can make the property readonly like this.
        //public string Name { get; private set; }

        // we can do this too to add some logic.
        //private string _name;

        //public string Name
        //{
        //    get { return _name; }
        //    set
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //            throw new ArgumentNullException();

        //        _name = value;
        //    }
        //}

        // this is a field. We use underscore for private fields.
        private int _age;

        // this is a property.
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthdate;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1983, 01, 18));

            Console.WriteLine(person.GetBirthDate());
        }
    }
}
