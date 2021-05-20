using System;

namespace PenTrade.Models
{
    public class Offer
    {
        public int Id { get; set; }

        public bool IsOfferToBuy { get; set; }

        public int SenderId { get; set; }
        public Company Sender { get; set; }

        public int ReceiverId { get; set; }
        public Company Receiver { get; set; }

        public int MerchandiseId { get; set; }
        public Merchandise Merchandise { get; set; }



        public DateTime TimeSent { get; set; }
        public double PricePerUnit { get; set; }
        public double Amount { get; set; }
        public bool? IsAccepted { get; set; }
    }
}
