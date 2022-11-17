// See https://aka.ms/new-console-template for more information

using SeeSharp;

Console.WriteLine("Hello, World 1!");

var fp = new FirstProgram();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Counter =" + fp.GetNextValue());
}

var customer = new Customer();
customer.name = "Jon";
customer.age = 21;

var item1 = new OrderItem();
item1.itemCode = "abcd123";
item1.itemName = "Shampoo";
item1.qty = 1;





var order = new Order();
order.OrderId = "xyz";
order.Customer = customer;
order.Items.Add(item1);
//order.Items.Add(item2);

foreach (OrderItem item in order.Items)
{
    Console.WriteLine(" Customer Order :\n{0}\n {1}\n  {2} ", item.itemName, item.itemCode, item.qty);
} 