using System;
using System.Collections.Generic;

namespace PenTrade.Models
{
    public class Negotiation
    {
        public int Id { get; set; }

        public int Company1Id { get; set; }
        public Company Company1 { get; set; }

        public int Company2Id { get; set; }
        public Company Company2 { get; set; }
        public ICollection<Offer> Offers { get; set; }
        public ICollection<Message> Messages { get; set; }

    }
}
