namespace AdminWebsiteApi.Models
{
    public class Companies
    {
        public int Id { get; set; }
        public required string CompanyName { get; set; }
        public required string Address { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Website { get; set; }
    }
}
