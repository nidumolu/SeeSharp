using System;
namespace SeeSharp
{
    public class Customer
    {
        string name { get; set; }
        int age { get; set; }

        
    }

    public class OrderItem
    {
        string itemName { get; set; }
        int qty { get; set; }

    }

    public class Order
    {
        private readonly List<OrderItem> itemList = new List<OrderItem>();
        public string OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> Items { get { return itemList; } }

    }
}

