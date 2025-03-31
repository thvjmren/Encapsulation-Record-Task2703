namespace Encapsulation_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("      apPLe", "    13   pro     MAX", 2222.2m, 222.22m, 2);

            Console.WriteLine("satisdan evvel:");
            product.GetInfo();
            Console.WriteLine("                                                               ");

            product.Sale(1);
            Console.WriteLine("                                                               ");

            Console.WriteLine("satisdan sonra:");
            product.GetInfo();
        }
    }
}