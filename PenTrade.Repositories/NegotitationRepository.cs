using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PenTrade.Models;
using PenTrade.Repositories.Interfaces;
using PenTrade.ViewModels;

namespace PenTrade.Repositories
{
    public class NegotitationRepository : CRUDRepository<Negotiation>, INegotiationRepository
    {
        public NegotitationRepository(ApplicationContext context) : base(context)
        {

        }

        public Message AddMessageToNegotiation(NewMessageModel newMessageModel)
        {
            var message = new Message
            {
                SenderId = newMessageModel.CompanySenderId,
                ReceiverId = newMessageModel.CompanyReceiverId,
                Content = newMessageModel.Content,
                TimeSent = newMessageModel.TimeSent
            };
            var negotiation = GetSingleByPredicate(n =>
                (n.Company1Id == newMessageModel.CompanySenderId 
                    && n.Company2Id == newMessageModel.CompanyReceiverId) ||
                (n.Company1Id == newMessageModel.CompanyReceiverId
                    && n.Company2Id == newMessageModel.CompanySenderId));

            negotiation.Messages.Add(message);
            _context.SaveChanges();

            return message;
        }

        public NewOfferModel AddOfferToNegotiation(NewOfferModel newOffer)
        {
            var offer = new Offer
            {
                SenderId = newOffer.SenderId,
                ReceiverId = newOffer.ReceiverId,
                Amount = newOffer.Amount,
                TimeSent = newOffer.TimeSent,
                PricePerUnit = newOffer.PricePerUnit,
                MerchandiseId = newOffer.MerchandiseId,
                IsOfferToBuy = newOffer.IsOfferToBuy
            };
            var negotiation = GetSingleByPredicate(n =>
                (n.Company1Id == newOffer.SenderId
                    && n.Company2Id == newOffer.ReceiverId) ||
                (n.Company1Id == newOffer.ReceiverId
                    && n.Company2Id == newOffer.SenderId));

            negotiation.Offers.Add(offer);
            _context.SaveChanges();
            newOffer.NewOfferId = offer.Id;
            return newOffer;

        }

        public void ChangeOfferStatus(int offerId, bool newOfferStatus)
        {
            var offer = _context.Offers.Find(offerId);
            offer.IsAccepted = newOfferStatus;
            _context.SaveChanges();
        }

        public Negotiation GetNegotiationDetails(int company1Id, int company2Id)
        {
            var negotiation = GetSingleByPredicate(
                n => (n.Company1Id == company1Id && n.Company2Id == company2Id) ||
                 (n.Company1Id == company2Id && n.Company2Id == company1Id));

            _context.Entry(negotiation).Collection(n => n.Offers).Query().Include(o => o.Merchandise).Load();
            _context.Entry(negotiation).Reference(n => n.Company1).Query().Include(c => c.CurrentStock).Load();
            _context.Entry(negotiation).Reference(n => n.Company2).Query().Include(c => c.CurrentStock).ThenInclude(s => s.Merchandise).Load();

            return negotiation;
        }   

        public IEnumerable<NegotiationViewModel> GetNegotitationsForCompany(int companyId)
        {
            var negotiations = _context.Negotiations.AsQueryable();
            negotiations = negotiations.Include(n => n.Company1);
            negotiations = negotiations.Include(n => n.Company2);
            negotiations = negotiations.Include(n => n.Messages);

            negotiations = negotiations.Where(n => n.Company1Id == companyId || n.Company2Id == companyId);

            return negotiations.Select(n => new NegotiationViewModel
            {
                OtherCompanyId = (n.Company1Id == companyId) ? n.Company2Id : n.Company1Id,
                OtherCompanyName = (n.Company1Id == companyId) ? n.Company2.Name : n.Company1.Name,
                LastMessageAt = n.Messages.Count != 0 ? n.Messages.OrderByDescending(m => m.TimeSent).First().TimeSent : DateTime.MinValue
            }).ToList();
        }

        public Negotiation InitiateNegotiation(int company1Id, int company2Id)
        {
            var negotiation = new Negotiation
            {
                Company1Id = company1Id,
                Company2Id = company2Id
            };

            return Add(negotiation);
        }
    }
}
