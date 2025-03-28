namespace Encapsulation_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Apple", "13 Pro Max", 2222.2m, 222.22m, 200);

            product.BrandName = "        appLE ";
            product.Model = "  16 PRO maX      ";
            product.Price = 3333.3m;
            product.Cost = 333.33m;
            product.Count = 1;

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
