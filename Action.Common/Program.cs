// See https://aka.ms/new-console-template for more information

namespace Action.Common
{
    public record Product
    {
        public string Name { get; set; }
        public DateTime Expiry { get; set; }
        public string[] Sizes { get; set; }
    }
}