using System;
using System.Linq;
using System.Text;
using PenTrade.Models;
using PenTrade.Repositories.Interfaces;
using PenTrade.ViewModels;

namespace PenTrade.Repositories
{
    public class AuthRepository : CRUDRepository<ApplicationUser>, IAuthRepository
    {
        public AuthRepository(ApplicationContext context) : base(context)
        {
        }

        public void AddEmployee(int employeeId, int companyId)
        {
            var user = GetSingleByPredicate(u => u.Id == employeeId);
            user.CompanyId = companyId;
            _context.SaveChanges();
        }

        public void DeleteCompany(int userId)
        {
            var user = GetSingleByPredicate(u => u.Id == userId);
            user.Company = null;
            _context.SaveChanges();
        }

        public ApplicationUser Register(RegisterModel login)
        {
            byte[] passwordHash;
            byte[] passwordSalt;

            CreatePasswordHash(login.Password, out passwordHash, out passwordSalt);
            var user = new ApplicationUser
            {
                FirstName = login.FirstName,
                LastName = login.LastName,
                Email = login.Email,
                PhoneNumber = login.PhoneNumber,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };

            Add(user);

            return user;
        }

        public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hash = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }

        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hash = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hash.Key;
                passwordHash = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

        }
    }
}
