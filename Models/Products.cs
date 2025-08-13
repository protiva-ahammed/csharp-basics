namespace csharp_basics.Models
{
    public class Products
    {
        public string Name { get; set; }

        public Products(string name)
        {
            Name = name;
        }
    }

public class Review
{
    public string Content { get; set; }

    public Review(string content)
    {
        Content = content;
    }
}
}