namespace GithubPagesExample.Models
{
    public class Address
    {
        public string Street { get; set; } = string.Empty;
        public string Suite { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Zipcode { get; set; } = string.Empty;
        public object? Geo { get; set; } // You can replace 'object' with a more specific type if needed
    }
}
