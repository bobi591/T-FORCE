using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace T_FORCE.Models
{
    public class Task
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public TaskType Type { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public DateTime ExpectedEndDate { get; set; }

        public int AssignedTo { get; set; }
        public DateTime EndDate { get; set; }
        public int ParentTaskId { get; set; }
        public int ChildrenTasksId { get; set; }

    }
    public enum TaskType
    {
        Task,
        Issue,
        Epic
    }
}
