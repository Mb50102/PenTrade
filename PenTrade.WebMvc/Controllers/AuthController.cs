using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using PenTrade.Models;
using PenTrade.Repositories.Interfaces;
using PenTrade.ViewModels;
using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Linq;

namespace PenTrade.WebMvc.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }


        public IActionResult Register(RegisterModel register)
        {
            if(ModelState.IsValid)
            {
                _authRepo.Register(register);
                return RedirectToAction("Login");

            }
            return View(register);
        }

        [ActionName("Login")]
        public async System.Threading.Tasks.Task<IActionResult> LoginAsync(LoginModel login, string returnUrl = null)
        { 
            if(returnUrl != null)
            {
                TempData["redirectUrl"] = returnUrl;
            }
            if(ModelState.IsValid)
            {
                var signInUser = ValidateUser(login);
                if(signInUser != null)
                {
                    await PerformLoginAsync(signInUser);
                }
                else 
                {
                    return View(login);
                }

            }
            else
            {
                return View(login);
            }

            if (!TempData.ContainsKey("redirectUrl"))
                return RedirectToAction("Index", "Home");

            returnUrl = TempData["redirectUrl"] as string;
            TempData.Remove("redirectUrl");
            return LocalRedirect(returnUrl);

        }

        private async System.Threading.Tasks.Task PerformLoginAsync(ApplicationUser signInUser)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, signInUser.Email),
               
            };

            if(signInUser.Company != null)
            {
                claims.Add(new Claim("CompanyId", signInUser.CompanyId.ToString()));
                claims.Add(new Claim("CompanyName", signInUser.Company.Name));
            }

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

        }

        private ApplicationUser ValidateUser(LoginModel login)
        {
            var appUser = _authRepo.GetSingleByPredicate(user => user.Email.Equals(login.Email));
            if(appUser != null &&
                _authRepo.VerifyPasswordHash(login.Password, appUser.PasswordHash, appUser.PasswordSalt))
            {
                return appUser;
            }
            return null;

        }

        [Authorize]
        public IActionResult Details()
        {
            var appUser = _authRepo.GetSingleByPredicate(user => user.Email.Equals(
                User.Claims.SingleOrDefault(claim => claim.Type.Equals(ClaimTypes.Email)).Value));
            return View(appUser);
        }


        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

    }
}
