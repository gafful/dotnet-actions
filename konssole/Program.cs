// See https://aka.ms/new-console-template for more information


using Newtonsoft.Json;
using Action.Common;

namespace Konssole
{
    internal static class Program
    {
        private static int Main(string[] args)
        {
            if (args[0] == "soup")
                Console.WriteLine("not Not");

            Product product = new Product
            {
                Name = "Goo Hul",
                Expiry = new DateTime(2008, 12, 28),
                Sizes = new string[] { "Small" }
            };

            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine($"Wee-here...!: {json}");
            return 0;
        }
    }
}
