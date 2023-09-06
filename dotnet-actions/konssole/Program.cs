// See https://aka.ms/new-console-template for more information


using Newtonsoft.Json;

namespace Konssole
{
    internal static class Program
    {
        private static int Main(string[] args)
        {
            if (args[0] == "soup")
                Console.WriteLine("not Not");

            Product product = new Product();
            product.Name = "Goo Hul";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new string[] { "Small" };

            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine($"Wee-here...!: {json}");
            return 0;
        }
    }

    internal class Product
    {
        public string Name { get; set; }
        public DateTime Expiry { get; set; }
        public string[] Sizes { get; set; }
    }
}
