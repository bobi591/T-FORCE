﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
            User user = new User
            {
                UserOrganization = userOrganization,

                Username = username,
                Password = Utilities.Encrypt(password),
                Email = email,
                FirstName = firstName,
                LastName = lastName,

                LastLoginAttempt = DateTime.UtcNow,
                LoginAttempts = 0,
                IsBlocked = false
            };

            return user;
        }

        /// <summary>
        /// Creates task object with mandatory attributes.
        /// </summary>
        public Task CreateTask(string name, string description, TaskType type, int createdByUserId,
            DateTime dateCreated, DateTime expectedEndDate, string projectCode,  int? parentTaskId)
        {
            Task task = new Task
            {
                Name = name,
                Description = description,
                Type = type,
                CreatedBy = createdByUserId,
                DateCreated = dateCreated,
                ExpectedEndDate = expectedEndDate,
                ProjectCode = projectCode,
                TaskStatus = TaskStatus.Created
            };

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
            Task task = new Task
            {
                Name = name,
                Description = description,
                Type = type,
                CreatedBy = createdBy.Id,
                DateCreated = dateCreated,
                ExpectedEndDate = expectedEndDate
            };

            if (parentTaskId.HasValue)
            {
                task.ParentTaskId = parentTaskId.Value;
            }

            return task;
        }

        /// <summary>
        /// Creates Kanban Board object with mandatory attributes.
        /// </summary>
        public KanbanBoard CreateKanbanBoard(string name, int createdByUserId, DateTime dateCreated, int numberOfColumns, List<string> columnNames)
        {

            KanbanBoard kanbanBoard = new KanbanBoard
            {
                Name = name,
                NumberOfColumns = numberOfColumns,
                Columns = JsonConvert.SerializeObject(columnNames),
                Swims = "",
                CreatedBy = createdByUserId,
                DateCreated = dateCreated
            };

            return kanbanBoard;
        }

        [Obsolete("This method is obsolete and made for experimental purposes only.", false)]
        /// <summary>
        /// Creates typical (Investigation, In Progress, Done) Kanban Board object with mandatory attributes.
        /// </summary>
        public KanbanBoard CreateTypicalKanbanBoard(string name, int createdByUserId, DateTime dateCreated)
        {

            KanbanBoard kanbanBoard = new KanbanBoard
            {
                Name = name,
                Swims = "",
                CreatedBy = createdByUserId,
                DateCreated = dateCreated
            };

            List<string> typicalColumns = new List<string>() { "Investigation", "In Progress", "Done" };
            kanbanBoard.SetColumns(typicalColumns);

            return kanbanBoard;
        }

        /// <summary>
        /// Creates Project object with mandatory attributes.
        /// </summary>
        public Project CreateProject(string name, string code, int createdByUserId, DateTime dateCreated)
        {
            Project project = new Project
            {
                Name = name,
                Code = code,
                CreatedBy = createdByUserId,
                DateCreated = dateCreated,
                KanbanBoards = ""
            };

            return project;
        }

        /// <summary>
        /// Creates Comment object with mandatory attributes.
        /// </summary>
        public Comment CreateComment(string taskId, string userId, DateTime timeCreated, DateTime lastModified, string content)
        {
            Comment comment = new Comment
            {
                TaskId = Int32.Parse(taskId),
                UserId = Int32.Parse(userId),
                TimeCreated = timeCreated,
                LastModified = lastModified,
                Content = content
            };

            return comment;
        }
    }
}
