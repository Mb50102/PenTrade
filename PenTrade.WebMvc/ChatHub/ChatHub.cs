using System;
using Microsoft.AspNetCore.SignalR;
using PenTrade.Models;
using PenTrade.Repositories.Interfaces;
using PenTrade.ViewModels;

namespace PenTrade.WebMvc.ChatHub
{
    public class ChatHub : Hub
    {
        private INegotiationRepository _negotiationRepository;

        public ChatHub(INegotiationRepository negotiationRepository) : base()
        {
            _negotiationRepository = negotiationRepository;
        }

        public void SendMessage(NewMessageModel newMessage)
        {

            _negotiationRepository.AddMessageToNegotiation(newMessage);
            Clients.All.SendAsync("ReceiveMessage", newMessage);
        }

        public void SendNewOffer(NewOfferModel newOffer)
        {
            _negotiationRepository.AddOfferToNegotiation(newOffer);
            Clients.All.SendAsync("RecieveNewOffer", newOffer);
        }

        public void ModifyOffer(int offerId, bool newOfferStatus)
        {
            _negotiationRepository.ChangeOfferStatus(offerId, newOfferStatus);
            Clients.All.SendAsync("GetNotified", offerId, newOfferStatus);
        }
    }
}