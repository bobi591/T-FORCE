using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace T_FORCE.Tasks.Models
{
    public class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int TaskId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public DateTime TimeCreated { get; set; }
        [Required]
        public DateTime LastModified { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
