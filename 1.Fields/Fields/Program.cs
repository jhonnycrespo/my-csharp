using System;
using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        // readonly nos asegura que el field solo sera asignado una vez.
        // improves safety and robustness.
        // (1)
        public readonly List<Order> Orders = new List<Order>();

        public int Id;
        public string Name;

        // tendriamos que agregar la inicializacion de Orders a todos los constructores. Ese
        // es un problema, lo que podemos hacer es inicializarlo directo arriba. (1)
        // ahora podemos deshacernos de este constructor.
        //public Customer()
        //{
        //    Orders = new List<Order>();
        //}

        public Customer(int id)
        {
            this.Id = id;
        }

        // calling the above constructor.
        public Customer(int id, string name) : this(id)
        {
            Name = name;
        }

        public void Promote()
        {
            // no podemos reasignar Orders por que es readonly
            //Orders = new List<Order>();
        }
    }

    public class Order
    {
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            // we don't have a default constructor for Customer
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            //customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }
    }
}
