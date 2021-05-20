using System;

namespace PenTrade.ViewModels
{
    public class NewOfferModel
    {
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public int MerchandiseId { get; set; }
        public string MerchandiseName { get; set; }
        public bool IsOfferToBuy { get; set; }

        public int? NewOfferId { get; set; }
        public DateTime TimeSent { get; set; }
        public double PricePerUnit { get; set; }
        public double Amount { get; set; }

    }
}
