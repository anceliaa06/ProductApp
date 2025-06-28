namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1= new Product(1, "Laptop", 1200.00, 10);
            Product product2 = new Product(2, "Smartphone", 800.00, 15);

            Console.WriteLine("Product Details:");
            Console.WriteLine(product1);
            Console.WriteLine(product2);
        }
    }
}
