using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("908 W Daytime Dr","South Jordan","UT","USA");
        Customer customer1 = new Customer("Peter Parker",address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("AMV RYDEN 7 9800X3D 8-Core, 16-Thread Processor", "RX-983", 411.00, 1));
        order1.AddProduct(new Product("AMV Radian RX 9070XT Triple Fan 16GB", "XT-907", 959.99, 1));
        order1.AddProduct(new Product("ProFliew-INF 360mm ARGB AIO CPU Liquid Cooling", "PA-360", 104.49, 1));


        Address address2 = new Address("Santo Domingo 1470","Santiago","RM","Chile");
        Customer customer2 = new Customer("Thiago Almeida",address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Kingstong 1TB NVMe SSD | PCIe 4.0 Gen 4x4", "SD-600", 139.99, 1));
        order2.AddProduct(new Product("PC Power Button with 118 Desktop", "PP-118", 7.99, 2));
        order2.AddProduct(new Product("CORSOER Vengeance DDR4 RAM 32GB (2X16GB) 3200MHz", "CV-900", 249.99, 1));

        List<Order> orders = new List<Order> {order1, order2};

        foreach (Order order in orders)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"TOTAL PRICE: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}