using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class TicketDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? LicensePlate { get; set; }
        public double TotalPay { get; set; }
        public int IdClient { get; set; }
    }
}
