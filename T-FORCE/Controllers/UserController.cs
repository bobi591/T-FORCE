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
    /// <summary>
    /// The main <c>UserController</c> class.
    /// Contains methods for performing requests related to Users.
    /// </summary>
    public class UserController : Controller
    {
        /// <summary>
        /// HTTP Request - Login user. The methods checks if the user is eligible for authentication and generates its claims principals.
        /// </summary>
        /// <returns>
        /// Redirection to the Home page.
        /// </returns>
        /// <param name="username">Username of the user to be logged in.</param>
        /// <param name="password">Password of the user to be logged in.</param>
        /// <param name="remember">Remember me flag. (1 or 0)</param>
        [HttpPost]
        public async Task<IActionResult> LoginAsync(string username, string password, string remember)
        {
            Authenticate authProcess = new Authenticate();
            Tuple<ClaimsPrincipal,string> authProcessResult = await authProcess.GetClaimsPrincipal(username, password);
            ClaimsPrincipal currentClaimsPrincipal = authProcessResult.Item1;
            ViewBag.Message = authProcessResult.Item2;

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


        /// <summary>
        /// HTTP Request - Register new user. The methods checks if the user is eligible for registration and the required properties are unique.
        /// </summary>
        /// <returns>
        /// Redirection to the Home page.
        /// </returns>
        /// <param name="username">Username of the user to be registered.</param>
        /// <param name="password">Password of the user to be registered.</param>
        /// <param name="email">Email of the user to be registered.</param>
        /// <param name="firstName">First name the user to be registered.</param>
        /// <param name="lastName">Last name the user to be registered.</param>
        /// <param name="passwordRepeat">Second password for confirmation.</param>
        [HttpPost]
        public async Task<IActionResult> Register
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
                viewbagMessage = await registrationProcess.Register(user);

                ViewBag.Message = viewbagMessage;

                return View();
            }
        }
        /// <summary>
        /// Returns the Login page.
        /// </summary
        public IActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// Returns the Register page.
        /// </summary
        public IActionResult Register()
        {
            return View();
        }
    }
}
