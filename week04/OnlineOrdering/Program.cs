using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    {
        Address a1 = new Address("10 Main St", "Abuja", "FCT", "USA");
        Customer c1 = new Customer("John Doe", a1);

        Order o1 = new Order(c1);
        o1.AddProduct(new Product("Laptop", 1, 500, 1));
        o1.AddProduct(new Product("Mouse", 2, 20, 2));

        Address a2 = new Address("22 King Rd", "Lagos", "LA", "Canada");
        Customer c2 = new Customer("Jane Smith", a2);

        Order o2 = new Order(c2);
        o2.AddProduct(new Product("Phone", 3, 300, 1));
        o2.AddProduct(new Product("Case", 4, 15, 3));

        Console.WriteLine("ORDER 1");
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine("Total: $" + o1.GetTotalPrice());

        Console.WriteLine("\nORDER 2");
        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine("Total: $" + o2.GetTotalPrice());
    }
}
    }
