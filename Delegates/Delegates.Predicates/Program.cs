using System;
using System.Collections.Generic;

// In .NET 2.0 came this concept of predicates delegates. It is a really
// powerful concept which makes it easy to write searching algorithms and
// collections.

// What is a predicate? A predicate is a delegate with the following signature:
// Return type: bool
// Argument type: generic

// Why use a predicate delegate? The most common use of a predicate delegate
// is for searching items in a collection.

namespace Delegates.Predicates
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }

        public Employee(string firstName, string lastName, string designation)
        {
            FirstName = firstName;
            LastName = lastName;
            Designation = designation;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Anshu", "Dutta", "SSE");
            Employee emp2 = new Employee("John", "Doe", "Manager");
            Employee emp3 = new Employee("Jane", "Doe", "Assistant");

            List<Employee> employees = new List<Employee> { emp1, emp2, emp3 };

            // Method 1: The traditional way

            Predicate<Employee> predicate = new Predicate<Employee>(SearchEmployee);

            // The Find() method internally iterates through each item in the list
            // and calls the function SearchEmployee, passing each item from
            // the list as an argument one by one.
            Employee foundEmployee = employees.Find(predicate);

            Console.WriteLine("Employee Found: {0}", foundEmployee.FirstName);


            // Method 2: Using anonymous functions.

            // The functionality here is the same, but instead of declaring a
            // separate predicate delegate and manually pointing it to an
            // external function, we use an anonymous function.
            Employee foundEmployee2 = employees.Find(delegate(Employee employee)
            {
                return employee.FirstName == "Anshu";
            });

            Console.WriteLine("Employee Found: {0}", foundEmployee2.FirstName);

            // Method 3: Using a lambda expression.

            // The lines of code can be further reduced by using => or lambda expressions.
            // The Find() method still takes a predicate delegate. ()=> is used to invoke a
            // delegate with an anonymous function.
            // Note that intellisense already expects an object of type Employee when typing
            // the Lambda expression. This is because, we are performing a search operation
            // on a generic list of type Employee
            Employee foundEmployee3 = employees.Find((employee) => employee.FirstName == "Anshu");

            Console.WriteLine("Employee Found: {0}", foundEmployee3.FirstName);


            // Searching a list of employees

            var foundEmployees = employees.FindAll((employee) => employee.LastName == "Doe");

            Console.WriteLine("List of employess with LastName Doe: ");

            foreach (Employee employee in foundEmployees)
            {
                Console.WriteLine("{0},{1}", employee.FirstName, employee.LastName);
            }

            // Index search

            int index = employees.FindIndex(0, 2, (e) => e.FirstName.Contains("J"));
            Console.WriteLine("Index returned {0}", index);
        }

        // Method 1: The traditional way
        public static bool SearchEmployee(Employee employee)
        {
            return employee.FirstName == "Anshu";
        }
    }
}
