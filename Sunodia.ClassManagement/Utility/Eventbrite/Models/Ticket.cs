using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunodia.ClassManagement.Utility.Eventbrite.Models
{
    public class Ticket
    {
        public long Id;
        public string Name;
        public string Description;
        public TicketType Type;
        public string Currency;
        public decimal Price;
        public DateTime? StartDateTime;
        public DateTime EndDateTime;
        public int? QuantityAvailable;
        public int? QuantitySold;
    }
    public enum TicketType
    {
        FixedPrice,
        Donation
    }
}