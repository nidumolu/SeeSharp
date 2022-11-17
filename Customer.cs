using System;
namespace SeeSharp
{
    public class Customer
    {
        public string name { get; set; }
        public int age { get; set; }

        
    }

    public class OrderItem
    {
        public string itemCode { get; set; }
        public string itemName { get; set; }
        public int qty { get; set; }

    }

    public class Order
    {
        private readonly List<OrderItem> itemList = new List<OrderItem>();
        public string OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> Items { get { return itemList; } }

    }
}

