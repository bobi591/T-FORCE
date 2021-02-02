using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using T_FORCE.EntityFramework;
using T_FORCE.Users.Models;

namespace T_FORCE.Tasks.Models
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
        public string TaskStatus { get; set; }
        [Required]
        public string ProjectCode { get; set; }

        public int AssignedTo { get; set; }
        public DateTime EndDate { get; set; }
        public int ParentTaskId { get; set; }
        public int ChildrenTasksId { get; set; }


        /// <summary>
        /// Gets the user First + Last name. (ex. John Andersson)
        /// </summary>
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
                return "Unassigned";
            }
        }

        /// <summary>
        /// Gets the comments for the current task.
        /// </summary>
        public List<Comment> GetComments()
        {
            CommentRepository commentRepository = new CommentRepository();
            return commentRepository.GetCommentsForTask(Convert.ToString(this.Id));
        }

    }
    public enum TaskType
    {
        Task,
        Issue,
        Epic
    }
}
