using System;

namespace InterfacesAndTesting.After
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            this.shippingCalculator = shippingCalculator;
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
