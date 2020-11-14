using System;
using System.Linq;
using T_FORCE.Models;

namespace T_FORCE.Repositories
{
    public class UserRepository
    {
        private static IAppDbContextFactory IAppDbContextFactory = new AppDbContextFactory();
        private AppDbContext appDbContext = IAppDbContextFactory.CreateAppDbContext();

        /// <summary>
        /// Get user by username.
        /// </summary>
        public User GetUserByUsername(string username)
        {
            User user = appDbContext.Users.Where(user => user.Username == username).First();
            return user;
        }

        /// <summary>
        /// Get user by id.
        /// </summary>
        public User GetUserById(int id)
        {
            User user = appDbContext.Users.Where(user => user.Id == id).First();
            return user;
        }
    }
}
