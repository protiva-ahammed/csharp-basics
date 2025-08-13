namespace practices_basics.Models
{
    public class Review
    {
        public string Content;

        public Review(string v)
        {
            this.Content = v;
        }

        public int? Rating { get; set; }
        
    }
}