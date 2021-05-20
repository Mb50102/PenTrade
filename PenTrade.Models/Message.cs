using System;

namespace PenTrade.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime TimeSent { get; set; }

        public int SenderId { get; set; }
        public Company Sender { get; set; }
        public int ReceiverId { get; set; }
        public Company Receiver { get; set; }

    }
}
