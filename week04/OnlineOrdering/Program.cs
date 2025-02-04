

class Program
{
    static void Main()
    {
        var _address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        var _customer1 = new Customer("John Doe", _address1);

        var _address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
        var _customer2 = new Customer("Jane Smith", _address2);

        Product product1 = new Product ("Laptop","A123", 999.99, 1);
        Product product2 = new Product ("Mouse","B456", 49.99, 2);
        Product product3 = new Product ("Keyboard","C789", 79.99, 1);

        Order order1 = new Order(_customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(_customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Order 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Order 1 Total Cost: {order1.GetTotalCost():C}");

        Console.WriteLine();

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Order 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Order 2 Total Cost: {order2.GetTotalCost():C}");
    }
}