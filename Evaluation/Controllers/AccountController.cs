using Domain.Models;
using Evaluation.Models.ViewModels.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Evaluation.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly ILoginService _loginService;
    
        public AccountController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid) return View(loginViewModel);

            var login = new Login(loginViewModel.UserName, loginViewModel.Password);

            var existsUser = _loginService.FindExistsByUserName(login);

            if (existsUser)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, loginViewModel.UserName)
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                await HttpContext.SignInAsync(claimsPrincipal);

                if (string.IsNullOrEmpty(loginViewModel.ReturnUrl))
                    return RedirectToAction("Index", "Home");

                return Redirect(loginViewModel.ReturnUrl);
            }

            ModelState.AddModelError("", "UserName/password not found");
            return View(loginViewModel);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
