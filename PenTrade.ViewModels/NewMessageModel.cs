using System;
namespace PenTrade.ViewModels
{
    public class NewMessageModel
    {
        public int CompanySenderId { get; set; }
        public int CompanyReceiverId { get; set; }
        public string Content { get; set; }
        public DateTime TimeSent { get; set; }
        public int HubConnectionId { get; set; }
    }
}
