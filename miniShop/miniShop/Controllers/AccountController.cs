using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using miniShop.Models;
using miniShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace miniShop.Controllers
{
    public class AccountController : Controller
    {
        private IUserService userService;

        public IActionResult Index()
        {
            return View();
        }
        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginModel userLoginModel)
        {
            var user = userService.ValidUser(userLoginModel.UserName, userLoginModel.Password);
            if (user != null)
            {
                // yetkilendir.1

                List<Claim> claims = new List<Claim>(); // şifre tutulmaz.
                claims.Add(new Claim(ClaimTypes.Name, user.Name));
                claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                                   
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal); // giriş
                return Redirect("/");
            }
                ModelState.AddModelError("hata","Kullanıcı adını veya parolayı yanlış!");
            return View();
            
            
        }
    }
}
