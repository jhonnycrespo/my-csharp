using System;

namespace InterfacesAndTesting.Before
{
    public class OrderProcessor
    {
        private readonly ShippingCalculator shippingCalculator;

        public OrderProcessor()
        {
            shippingCalculator = new ShippingCalculator();
        }

        public void Process(Order order)
        {
            // defensive programming
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
