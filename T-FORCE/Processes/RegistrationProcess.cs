using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_FORCE.Models;
using T_FORCE.UserInterfaceUtils;

namespace T_FORCE.Processes
{
    /// <summary>
    /// Implements the complete registration process of the application.
    /// Register() performs the whole process.
    /// </summary>
    public class RegistrationProcess
    {
        private static IAppDbContextFactory IAppDbContextFactory = new AppDbContextFactory();
        private AppDbContext appDbContext = IAppDbContextFactory.CreateAppDbContext();

        /// <summary>
        /// Performs the whole registration process.
        /// </summary>
        public void Register(User user, out string viewbagMessage)
        {
            if (IsUsernameUnique(user.Username))
            {
                if (IsEmailUnique(user.Email))
                {
                    if (IsValidEmail(user.Email))
                    {
                        appDbContext.Add(user);
                        appDbContext.SaveChanges();
                        viewbagMessage = PredefinedViewBag.RegisterSuccess;
                    }
                    else
                    {
                        viewbagMessage = PredefinedViewBag.BadEmailFormat;
                    }
                }
                else
                {
                    viewbagMessage = PredefinedViewBag.EmailNotUnique;
                }
            }
            else
            {
                viewbagMessage = PredefinedViewBag.UsernameNotUnique;
            }
        }

        private bool IsUsernameUnique(string username)
        {
            IQueryable<User> queryables = appDbContext.Users.Where(user => user.Username == username);
            if (queryables.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsEmailUnique(string email)
        {
            IQueryable<User> queryables = appDbContext.Users.Where(user => user.Email == email);
            if (queryables.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
