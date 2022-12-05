using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Ticket
    {
        [Key]
        public int IdTicket { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? LicensePlate { get; set; }
        public int IdClient { get; set; }
        public Client? Client { get; set; }
        public int IdTariff { get; set; }
        public double CostHour { get; set; }
        public double TotalPay { get; set; }
    }
}
