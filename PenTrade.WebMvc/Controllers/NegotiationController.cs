using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PenTrade.Repositories.Interfaces;

namespace PenTrade.WebMvc.Controllers
{
    public class NegotiationController : Controller
    {
        private INegotiationRepository _negotiationRepository;

        public NegotiationController(INegotiationRepository negotiationRepository)
        {
            _negotiationRepository = negotiationRepository;
        }

        [Authorize]
        public IActionResult Index()
        {
            var companyId = int.Parse(User.Claims.SingleOrDefault(claim => claim.Type.Equals("CompanyId")).Value);
            return View(_negotiationRepository.GetNegotitationsForCompany(companyId));
        }

        [Authorize]
        public IActionResult InitiateNegotiation(int companyId)
        {
            var userCompanyId = int.Parse(User.Claims.SingleOrDefault(claim => claim.Type.Equals("CompanyId")).Value);

            _negotiationRepository.InitiateNegotiation(userCompanyId, companyId);

            return RedirectToAction("Details", new { companyId });
        }

        [Authorize]
        public IActionResult Details(int companyId)
        {
            var userCompanyId = int.Parse(User.Claims.SingleOrDefault(claim => claim.Type.Equals("CompanyId")).Value);


            var negotiation = _negotiationRepository.GetNegotiationDetails(userCompanyId, companyId);

            return View(negotiation);
        }

    }
}
