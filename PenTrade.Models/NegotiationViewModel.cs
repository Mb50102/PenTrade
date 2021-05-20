using System;
namespace PenTrade.Models
{
    public class NegotiationViewModel
    {
        public int OtherCompanyId { get; set; }
        public string OtherCompanyName { get; set; }
        public DateTime LastMessageAt { get; set; }
    }
}
