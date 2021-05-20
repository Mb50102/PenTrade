using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PenTrade.Models;
using PenTrade.Repositories.Interfaces;
using PenTrade.ViewModels;

namespace PenTrade.Repositories
{
    public class CompanyRepository : CRUDRepository<Company>, ICompanyRepository
    {
        private INegotiationRepository _negotiationRepository;

        public CompanyRepository(ApplicationContext context, INegotiationRepository negotiationRepository) : base(context)
        {
            _negotiationRepository = negotiationRepository;
        }

        public void AddMerchandise(int companyId, string merchandiseName, MeasurmentUnit me)
        {
            var company = GetCompanyDetails(companyId);
            Merchandise merch = _context.Merchandises.SingleOrDefault(m => m.Name.Equals(merchandiseName) && m.MesaurmentUnit == me);
            if(merch == null)
            {
                merch = new Merchandise
                {
                    Name = merch.Name,
                    MesaurmentUnit = merch.MesaurmentUnit
                };
                _context.Merchandises.Add(merch);

            }
            company.CurrentStock.Add(new CurrentStock
            {
                MerchandiseId = merch.Id,
                AmountOfMerchandise = 0
            });
            _context.SaveChanges();

        }

        public void DeleteMerchandise(int currentStockId)
        {
            _context.CurrentStocks.Remove(_context.CurrentStocks.Find(currentStockId));
            _context.SaveChanges();
        }

        public void EditBasicData(Company company)
        {
            var companyDb = GetSingleByPredicate(c => c.Id == company.Id);
            companyDb.Name = company.Name;
            companyDb.Adress = company.Adress;
            _context.SaveChanges();
        }

        public IEnumerable<CompanyListView> FilterCompanies(CompanyFilter companyFilter)
        {

            var companies = _context.Companies.AsQueryable();

            companies = companies.Include(company => company.CurrentStock);
            companies = companies.Include(company => company.Representatives);

            if (companyFilter.Product != null)
            {
                companies = companies.Where(
                    company =>
                    company.CurrentStock
                    .SingleOrDefault(stock => stock.Merchandise.Name.StartsWith(companyFilter.Product, StringComparison.Ordinal)) != null);
            }
            if (companyFilter.CompanyName != null)
            {
                companies = companies.Where(company => company.Name.StartsWith(companyFilter.CompanyName, StringComparison.Ordinal));
            }



            return companies.Select(company => new CompanyListView
            {
                CompanyId = company.Id,
                CompanyName = company.Name,
                Representatives = company.Representatives,
                HasNegotiation = false
            }).ToList();


        }

        public Company GetCompanyDetails(int companyId)
        {
            var companyDetails = GetSingleByPredicate(company => company.Id == companyId);

            _context.Entry(companyDetails).Collection(company => company.CurrentStock).Query().Include(cs => cs.Merchandise).Load();

            companyDetails.Negotiations = _negotiationRepository.GetNegotitationsForCompany(companyId);

            return companyDetails;
        }

        public Company RegisterCompany(CreateCompanyModel companyModel) => throw new NotImplementedException();


    }
}
