using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using T_FORCE.Models;
using T_FORCE.UserInterfaceUtils;

namespace T_FORCE.Processes
{

    /// <summary>
    /// Implements the complete authentication process of the application.
    /// GetClaimsPrincipal() method returns a ClaimsPrincipal used in the User controller for authentication.
    /// </summary>

    public class Authenticate
    {
        private static IAppDbContextFactory IAppDbContextFactory = new AppDbContextFactory();
        private AppDbContext appDbContext = IAppDbContextFactory.CreateAppDbContext();

        public readonly static string EmailClaim = "email";
        public readonly static string UsernameClaim = "username";
        public readonly static string UserIdClaim = "userId";


        /// <summary>
        /// Returns a ClaimsPrincipal used in the User controller for authentication and output for viewbag messages
        /// </summary>
        public ClaimsPrincipal GetClaimsPrincipal(string username, string password, out string viewbagMessage)
        {

            User user = RetrieveUserObject(username);

            if (user == default)
            {
                viewbagMessage = PredefinedViewBag.NoSuchUserFound;
                return null;
            }
            else
            {
                if(IsValidPassword(password, user))
                {
                    if (IsUserNotLocked(user))
                    {
                        viewbagMessage = PredefinedViewBag.LoginSuccess;
                        ResetBadAttemptsOnAuthSuccess(ref user);
                        return GetClaimsPrincipal(user);
                    }
                    else
                    {
                        viewbagMessage = PredefinedViewBag.UserIsBlocked;
                        return null;
                    }
                }
                else
                {
                    viewbagMessage = PredefinedViewBag.BadLoginAttempt;
                    BadAttemptProcess(ref user);
                    return null;
                }
            }

        }

        private User RetrieveUserObject(string username)
        {
            IQueryable<User> queryables = appDbContext.Users.Where(user => user.Username == username);

            return queryables.FirstOrDefault();
        }

        private bool IsValidPassword(string password, User user)
        {
            if (user.Password == Utilities.Encrypt(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsUserNotLocked(User user)
        {
            if (user.IsBlocked)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BadAttemptProcess(ref User user)
        {
            if(user.LastLoginAttempt.AddMinutes(2) > DateTime.UtcNow && user.LoginAttempts == 3)
            {
                user.IsBlocked = true;
            }
            else
            {
                user.LastLoginAttempt = DateTime.UtcNow;
                user.LoginAttempts++;
            }

            appDbContext.SaveChanges();
        }

        private ClaimsPrincipal GetClaimsPrincipal(User user)
        {
            var claims = new List<Claim>();

            claims.Add(new Claim(EmailClaim, user.Email));
            claims.Add(new Claim(UsernameClaim, user.Username));
            claims.Add(new Claim(UserIdClaim, user.Id.ToString()));

            ClaimsIdentity userIdentity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            userIdentity.AddClaims(claims);

            ClaimsPrincipal userPrincipal = new ClaimsPrincipal(userIdentity);

            return userPrincipal;

        }

        private void ResetBadAttemptsOnAuthSuccess(ref User user)
        {
            user.LoginAttempts = 0;
            appDbContext.SaveChanges();
        }
    }
}
