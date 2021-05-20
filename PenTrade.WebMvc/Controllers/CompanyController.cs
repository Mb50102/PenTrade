using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PenTrade.Models;
using PenTrade.Repositories.Interfaces;
using PenTrade.ViewModels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using System.Linq;
using System.Security.Claims;
using System.Collections.Generic;

namespace PenTrade.WebMvc.Controllers
{
    public class CompanyController : Controller
    {
        private ICompanyRepository _companyRepository;

        private IAuthRepository _authRepository;

        private INegotiationRepository _negotiationRepository;

        public CompanyController(ICompanyRepository companyRepository, IAuthRepository authRepository, INegotiationRepository negotiationRepository)
        {
            _companyRepository = companyRepository;
            _authRepository = authRepository;
            _negotiationRepository = negotiationRepository;
        }

        [Authorize]
        public IActionResult Create(Company companyModel)
        {
            if (!ModelState.IsValid)
            {
                return View(companyModel);
            }

            var email = User.Claims.FirstOrDefault(claim => claim.Type.Equals(ClaimTypes.Email)).Value;
            var user = _authRepository.GetSingleByPredicate(appUser => appUser.Email.Equals(email));
            companyModel.Representatives = new List<ApplicationUser>
            {
                user
            };
            companyModel = _companyRepository.Add(companyModel);

            return RedirectToAction("Details", new { companyId = companyModel.Id });
        }



        public IActionResult Details(int companyId)
        {
            var companyDetails = _companyRepository.GetCompanyDetails(companyId);
            return View(companyDetails);
        }

        public IActionResult Find([Bind("CompanyName", "Product")] CompanyFilter companyFilter)
        {
            var companies = _companyRepository.FilterCompanies(companyFilter);
            if (User.Claims.SingleOrDefault(claim => claim.Type.Equals("CompanyId")) != null)
            {
                var companyId = int.Parse(User.Claims.SingleOrDefault(claim => claim.Type.Equals("CompanyId")).Value);
                companies = companies.Where(company => company.CompanyId != companyId).ToList();
                var companyIds = _negotiationRepository.GetNegotitationsForCompany(companyId)
                    .Select(n => n.OtherCompanyId);
                companies = companies.Select(c => new CompanyListView
                {
                    CompanyId = c.CompanyId,
                    CompanyName = c.CompanyName,
                    HasNegotiation = companyIds.Contains(c.CompanyId),
                    Representatives = c.Representatives

                }).ToList();
            }

            return View(companies);
        }

        [Authorize]
        public IActionResult MyCompany()
        {
            var companyId = int.Parse(User.Claims.SingleOrDefault(claim => claim.Type.Equals("CompanyId")).Value);

            return RedirectToAction("Details", new { companyId });
        }

        [Authorize]
        public IActionResult Edit(int companyId)
        {
            var companyDetails = _companyRepository.GetCompanyDetails(companyId);
            return View(companyDetails);
        }

        [Authorize]
        public IActionResult EditData(Company company)
        {
            _companyRepository.EditBasicData(company);
            return RedirectToAction("Edit", new { companyId = company.Id });
        }

        [Authorize]
        public IActionResult AddRepresentative([Bind("RepresentativeId")]int representativeId, [Bind("CompanyId")]int companyId)
        {
            _authRepository.AddEmployee(representativeId, companyId);
            return RedirectToAction("Details", new { companyId });
        }

        [Authorize]
        public IActionResult RemoveRepresentative(int employeeId, int companyId)
        {
            _authRepository.DeleteCompany(employeeId);
            return RedirectToAction("Edit", new { companyId });
        }


        [Authorize]
        public IActionResult AddMerchandise([Bind("CompanyId")] int companyId, [Bind("MerchandiseName")] string merchandiseName, [Bind("Unit")] MeasurmentUnit unit)
        {
            _companyRepository.AddMerchandise(companyId, merchandiseName, unit);

            return RedirectToAction("Details", new { companyId });
        }

        [Authorize]
        public IActionResult DeleteMerchandise(int currentStockId, int companyId)
        {
            _companyRepository.DeleteMerchandise(currentStockId);

            return RedirectToAction("Details", new { companyId });
        }
    }
}
