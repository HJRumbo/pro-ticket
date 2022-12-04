using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ticket
    {
        [Key]
        public int IdTicket { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? LicensePlate { get; set; }
        public double TotalPay { get; set; }
        public int IdClient { get; set; }
    }
}
