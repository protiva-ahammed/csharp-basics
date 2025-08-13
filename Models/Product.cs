namespace practices_basics.Models
{
    public class Product
    {
        private string v;

        public Product(string v)
        {
            this.v = v;
        }

        public int Price { get; set; }
        public string? Name { get; set; }
        
    }
}