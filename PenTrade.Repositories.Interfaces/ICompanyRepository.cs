using System;
using System.Collections.Generic;
using PenTrade.Models;
using PenTrade.ViewModels;

namespace PenTrade.Repositories.Interfaces
{
    public interface ICompanyRepository : ICRUDRepository<Company>
    {
        Company RegisterCompany(CreateCompanyModel companyModel);

        IEnumerable<CompanyListView> FilterCompanies(CompanyFilter companyFilter);

        Company GetCompanyDetails(int companyId);

        void EditBasicData(Company company);
        void AddMerchandise(int companyId, string merchandiseName, MeasurmentUnit me);
        void DeleteMerchandise(int currentStockId);
    }
}
