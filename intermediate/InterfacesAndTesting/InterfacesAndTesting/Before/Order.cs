using System;

namespace InterfacesAndTesting.Before
{
    public class Order
    {
        public bool IsShipped { get; private set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }
        public DateTime DatePlaced { get; set; }
    }
}
