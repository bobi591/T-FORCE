using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace T_FORCE.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public UserOrganization UserOrganization { get; set; }
        [Required]
        public int LoginAttempts { get; set; }
        [Required]
        public DateTime LastLoginAttempt { get; set; }
        [Required]
        public bool IsBlocked { get; set; }

        /// <summary>
        /// Get contatenation of first and last name of the current User.
        /// </summary
        public string GetFirstNameLastName()
        {
            return this.FirstName + " " + this.LastName;
    }
    }

    public enum UserOrganization
    {
        Enterprise,
        Personal,
        Open
    }
}
