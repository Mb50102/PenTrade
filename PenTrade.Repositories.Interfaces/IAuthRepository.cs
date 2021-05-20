using System;
using PenTrade.Models;
using PenTrade.ViewModels;

namespace PenTrade.Repositories.Interfaces
{
    public interface IAuthRepository : ICRUDRepository<ApplicationUser>
    {
        ApplicationUser Register(RegisterModel login);



        bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
        void DeleteCompany(int userId);
        void AddEmployee(int employeeId, int companyId);
    }
}
