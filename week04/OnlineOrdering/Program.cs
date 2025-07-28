using System;

class Program
{
    static void Main(string[] args)
    {
        // Endereço 1 nos EUA
        Address address1 = new Address("123 Maple Street", "Chicago", "IL", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book", "B001", 12.50, 2));
        order1.AddProduct(new Product("Pen", "P002", 1.25, 5));

        // Endereço 2 fora dos EUA
        Address address2 = new Address("456 Avenida Central", "Lisbon", "Lisboa", "Portugal");
        Customer customer2 = new Customer("Carlos Silva", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "N003", 20.00, 1));
        order2.AddProduct(new Product("Backpack", "B004", 35.00, 1));
        order2.AddProduct(new Product("Sticker Set", "S005", 3.50, 3));

        // Mostrar resultados do pedido 1
        Console.WriteLine("Order 1 - Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Order 1 - Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");

        // Mostrar resultados do pedido 2
        Console.WriteLine("Order 2 - Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Order 2 - Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}\n");
    }
}