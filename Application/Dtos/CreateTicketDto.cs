namespace Application.Dtos
{
    public class CreateTicketDto
    {
        public DateTime StartDate { get; set; }
        public string? LicensePlate { get; set; }
        public int IdClient { get; set; }
        public string? typeBay { get; set; }
    }
}
