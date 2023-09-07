// See https://aka.ms/new-console-template for more information


using Newtonsoft.Json;
using Action.Common;

namespace Konssole
{
    internal static class Program
    {
        private static async Task<int> Main(string[] args)
        {
            if (args[0] == "soup")
                Console.WriteLine("not Not");

            Product product = new Product
            {
                Name = args[0],
                Expiry = new DateTime(2008, 12, 28),
                Sizes = new string[] { "Small" }
            };

            await File.WriteAllTextAsync($"{DateTime.Now:yyyy-MM-dd-HH-mm-ss}.json", JsonConvert.SerializeObject(product, Formatting.Indented));
            return 0;
        }
    }
}
