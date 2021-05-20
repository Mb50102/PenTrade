using System;
using System.Collections.Generic;
using PenTrade.Models;
using PenTrade.ViewModels;

namespace PenTrade.Repositories.Interfaces
{
    public interface INegotiationRepository : ICRUDRepository<Negotiation>
    {
        IEnumerable<NegotiationViewModel> GetNegotitationsForCompany(int companyId);

        Negotiation InitiateNegotiation(int company1Id, int company2Id);

        Negotiation GetNegotiationDetails(int company1Id, int company2Id);

        Message AddMessageToNegotiation(NewMessageModel newMessageModel);
        NewOfferModel AddOfferToNegotiation(NewOfferModel newOffer);
        void ChangeOfferStatus(int offerId, bool newOfferStatus);
    }
}
