namespace AdminWebsiteApi.Models
{
    public class FreeTrialForm
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public required string EmailId { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Country { get; set; }
        public DateTime FormDate { get; set; }
    }
}
