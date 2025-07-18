using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("---------------------------------------------");
        //order 1 
        Address address1 = new Address ("123 Sesame Street.", "New York City", "NY", "USA");
        Customer customer1 = new Customer("Cookie Monster", address1);

        double order1ShippingCost = customer1.GetShippingCost();

        Product order1Product1 = new Product("Extra Large Choclate Chip Cookies", "1354", 1.50, 3);
        Product order1Product2 = new Product("2% Milk", "1300", 2.00, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(order1Product1);
        order1.AddProduct(order1Product2);
        double order1Subtotal = order1.CalculateSubtotal();
        double order1Total = order1.CalculateTotal();

        //display order 1
        order1.DisplayShippingLabel(); 
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();
        order1.DisplayCosts(order1Subtotal ,order1ShippingCost, order1Total);


        Console.WriteLine("---------------------------------------------");


        //order 2
        Address address2 = new Address("University View", "Rexburg", "Idaho", "USA");
        Customer customer2 = new Customer("Lucio", address2);

        double order2ShippingCost = customer2.GetShippingCost();

        Product order2Product1 = new Product("Bread Loaf", "2512", 2.00, 2);
        Product order2Product2 = new Product("Dubstep Remixer", "5200", 5.00, 4);
        Product order2Product3 = new Product("Papaya", "4010", 2.00, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(order2Product1);
        order2.AddProduct(order2Product2);
        order2.AddProduct(order2Product3);
        double order2Subtotal = order2.CalculateSubtotal();
        double order2Total = order2.CalculateTotal();


        //display order 2
        order2.DisplayShippingLabel(); 
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();
        order2.DisplayCosts(order2Subtotal, order2ShippingCost, order2Total);
        Console.WriteLine("---------------------------------------------");

    }   
}