using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Address for the first client
        Address address1 = new Address("Fake St 123", "Springfield", "Ohio", "USA");
        Customer customer1 = new Customer("Homer Simpson", address1);

        // Products for the first order
        Product product1 = new Product("Apples", 001, 1, 10);  // Precio unitario: 10
        Product product2 = new Product("Bananas", 002, 2, 5);  // Precio unitario: 5
        Product product3 = new Product("Oranges", 003, 1, 7);  // Precio unitario: 7

        List<Product> products1 = new List<Product> { product1, product2, product3 };

        // Order 1
        Order order1 = new Order(customer1, products1);

        Console.WriteLine("Order 1:");
        order1.Label();
        order1.Shipping();
        Console.WriteLine($"Total: ${order1.TotalPrice()}\n");

        // Address for the second client
        Address address2 = new Address("742 Evergreen Terrace", "Springfield", "Illinois", "USA");
        Customer customer2 = new Customer("Marge Simpson", address2);

        // Products for the second order
        Product product4 = new Product("Milk", 004, 2, 3);     
        Product product5 = new Product("Bread", 005, 1, 2);    
        Product product6 = new Product("Butter", 006, 12, 2);  

        List<Product> products2 = new List<Product> { product4, product5, product6 };

        // Order 2
        Order order2 = new Order(customer2, products2);

        Console.WriteLine("Order 2:");
        order2.Label();
        order2.Shipping();
        Console.WriteLine($"Total: ${order2.TotalPrice()}\n");

        // Order 3: International client
        Address address3 = new Address("Avenida Paulista 1578", "São Paulo", "São Paulo", "Brazil");
        Customer customer3 = new Customer("Carlos Silva", address3);
        List<Product> products3 = new List<Product>
        {
            new Product("Coffee Beans", 007, 1, 15),
            new Product("Sugar", 008, 2, 4),
            new Product("Chocolate", 009, 3, 5)
        };
        Order order3 = new Order(customer3, products3);

        Console.WriteLine("Order 3:");
        order3.Label();
        order3.Shipping();
        Console.WriteLine($"Total: ${order3.TotalPrice()}\n");
    }
}