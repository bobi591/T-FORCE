using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using T_FORCE.Processes;
using T_FORCE.Models;

namespace T_FORCE.Controllers
{
    public class UserController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> LoginAsync(string username, string password, string remember)
        {

            string viewbagMessage;

            Authenticate authProcess = new Authenticate();
            ClaimsPrincipal currentClaimsPrincipal = authProcess.GetClaimsPrincipal(username, password, out viewbagMessage);
            ViewBag.Message = viewbagMessage;

            if (currentClaimsPrincipal != null)
            {
                await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                currentClaimsPrincipal,
                new AuthenticationProperties
                {
                    ExpiresUtc = remember=="on"?
                                    DateTime.UtcNow.AddDays(1):
                                    DateTime.UtcNow.AddMinutes(20),
                    IsPersistent = true,
                    AllowRefresh = true
                });

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Register
            (string username, string password, string email, string firstName, string lastName, string passwordRepeat)
        {
            string viewbagMessage;

            if (password != passwordRepeat)
            {
                viewbagMessage = "Passwords do not match!";
                ViewBag.Message = viewbagMessage;
                return View();
            }
            else
            {
                ModelFactory modelFactory = new ModelFactory();

                User user = modelFactory.CreateUserObject
                    (UserOrganization.Open, username, password, email, firstName, lastName);

                RegistrationProcess registrationProcess = new RegistrationProcess();
                registrationProcess.Register(user, out viewbagMessage);

                ViewBag.Message = viewbagMessage;

                return View();
            }
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
