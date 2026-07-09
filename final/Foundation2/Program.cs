using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize Products, Customers and Orders

        Product productA1 = new Product("Industrial Crane",  1102, 184.36, 1);
        Product productA2 = new Product("Birdseed packet", 0043, 3.49, 5);
        Product productA3 = new Product("Acme Missile", 3028, 69.99, 12);
        List<Product> productsA = new List<Product>(){productA1, productA2, productA3};
        Address addressA = new Address("43 IHateRoadrunners Way", "Phoenix", "Arizona", "USA");
        Customer customerA = new Customer("Wile E. Coyote", addressA);
        Order orderA = new Order(productsA, customerA);
        
        Product productB1 = new Product("Assorted Droid Parts", 2099, 250.75, 1);
        Product productB2 = new Product("Troop Rations", 3792, 25.77, 20);
        Product productB3 = new Product("Coruscant Snack Surprise Box", 0249, 15.52, 2);
        List<Product> productsB = new List<Product>(){productB1, productB2, productB3};
        Address addressB = new Address("The Resolute", "Sector 3762-2", "Deep Space", "GR");
        Customer customerB = new Customer("Anakin Skywalker", addressB);
        Order orderB = new Order(productsB, customerB);

        Product productC1 = new Product("Cauldron (Pewter)", 0329, 8.99, 1);
        Product productC2 = new Product("Wizard's Robes", 0043, 36.49, 3);
        Product productC3 = new Product("Holly Wand", 3028, 15.99, 1);
        List<Product> productsC = new List<Product>(){productC1, productC2, productC3};
        Address addressC = new Address("The Cupboard Under the Stairs, 4 Privet Dr.", "Little Winging", "Surrey", "GB");
        Customer customerC = new Customer("Harry Potter", addressC);
        Order orderC = new Order(productsC, customerC);

        List<Order> orders = new List<Order>(){orderA,orderB,orderC};

        foreach (Order order in orders)
        {
            // Get Packing Label
            order.AssignShippingCost();
            order.DisplayPackingLabel();
            // Get Shipping Label
            order.DisplayShippingLabel();
            Console.WriteLine();
            // Get Total Price
            Console.WriteLine($"Total: {order.CalculateTotalPrice()}");
            Console.WriteLine();
        }
        
    }
}