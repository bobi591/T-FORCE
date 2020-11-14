using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_FORCE.Repositories;

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
        [Required]
        public TaskStatus TaskStatus { get; set; }

        public int AssignedTo { get; set; }
        public DateTime EndDate { get; set; }
        public int ParentTaskId { get; set; }
        public int ChildrenTasksId { get; set; }



        public string GetAssigneeFirstLastName()
        {
            if (AssignedTo != 0)
            {
                UserRepository userRepository = new UserRepository();
                User assignee = userRepository.GetUserById(AssignedTo);
                return assignee.FirstName + " " + assignee.LastName;
            }
            else
            {
                return "Unknown";
            }
        }

    }
    public enum TaskType
    {
        Task,
        Issue,
        Epic
    }
    public enum TaskStatus
    {
        Created,
        Investigation,
        Ongoing,
        Finished,
        Archived
    }
}
