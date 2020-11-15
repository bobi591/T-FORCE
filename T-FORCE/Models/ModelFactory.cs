using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_FORCE.Processes;

namespace T_FORCE.Models
{
    /// <summary>
    /// Creates model objects with mandatory attributes.
    /// </summary>
    public class ModelFactory
    {
        /// <summary>
        /// Creates user object with mandatory attributes.
        /// </summary>
        public User CreateUserObject
            (UserOrganization userOrganization, string username, string password, string email, 
            string firstName, string lastName)
        {
            User user = new User();

            user.UserOrganization = userOrganization;

            user.Username = username;
            user.Password = Utilities.Encrypt(password);
            user.Email = email;
            user.FirstName = firstName;
            user.LastName = lastName;

            user.LastLoginAttempt = DateTime.UtcNow;
            user.LoginAttempts = 0;
            user.IsBlocked = false;

            return user;
        }

        /// <summary>
        /// Creates task object with mandatory attributes.
        /// </summary>
        public Task CreateTask(string name, string description, TaskType type, int createdByUserId,
            DateTime dateCreated, DateTime expectedEndDate, int? parentTaskId)
        {
            Task task = new Task();

            task.Name = name;
            task.Description = description;
            task.Type = type;
            task.CreatedBy = createdByUserId;
            task.DateCreated = dateCreated;
            task.ExpectedEndDate = expectedEndDate;
            task.TaskStatus = TaskStatus.Created;

            if (parentTaskId.HasValue)
            {
                task.ParentTaskId = parentTaskId.Value;
            }

            return task;
        }

        /// <summary>
        /// Creates task object with mandatory attributes.
        /// </summary>
        public Task CreateTask(string name, string description, TaskType type, User createdBy,
            DateTime dateCreated, DateTime expectedEndDate, int? parentTaskId)
        {
            Task task = new Task();

            task.Name = name;
            task.Description = description;
            task.Type = type;
            task.CreatedBy = createdBy.Id;
            task.DateCreated = dateCreated;
            task.ExpectedEndDate = expectedEndDate;

            if (parentTaskId.HasValue)
            {
                task.ParentTaskId = parentTaskId.Value;
            }

            return task;
        }

        /// <summary>
        /// Creates Kanban Board object with mandatory attributes.
        /// </summary>
        public KanbanBoard CreateKanbanBoard(string name, int createdByUserId, DateTime dateCreated)
        {

            KanbanBoard kanbanBoard = new KanbanBoard();

            kanbanBoard.Name = name;
            kanbanBoard.NumberOfColumns = 0;
            kanbanBoard.Columns = "";
            kanbanBoard.Swims = "";
            kanbanBoard.CreatedBy = createdByUserId;
            kanbanBoard.DateCreated = dateCreated;

            return kanbanBoard;
        }

        /// <summary>
        /// Creates typical Kanban Board object with mandatory attributes.
        /// </summary>
        public KanbanBoard CreateTypicalKanbanBoard(string name, int createdByUserId, DateTime dateCreated)
        {

            KanbanBoard kanbanBoard = new KanbanBoard();

            kanbanBoard.Name = name;
            kanbanBoard.Swims = "";
            kanbanBoard.CreatedBy = createdByUserId;
            kanbanBoard.DateCreated = dateCreated;

            List<string> typicalColumns = new List<string>() { "Investigation", "In Progress", "Done" };
            kanbanBoard.SetColumns(typicalColumns);

            return kanbanBoard;
        }
    }
}
