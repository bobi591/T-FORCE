using System;
using System.Collections.Generic;
using System.Linq;
using T_FORCE.Models;

namespace T_FORCE.Repositories
{
    public class TaskRepository
    {
        private static IAppDbContextFactory IAppDbContextFactory = new AppDbContextFactory();
        private AppDbContext appDbContext = IAppDbContextFactory.CreateAppDbContext();

        /// <summary>
        /// Returns a list of tasks created by the username.
        /// </summary>
        public List<Task> GetTasksCreatedByUsername(string username)
        {
            int currentUserId = appDbContext.Users.Where(user => user.Username == username).First().Id;

            List<Task> tasksForUserId = appDbContext.Tasks.Where(task => task.CreatedBy == currentUserId).ToList();

            return tasksForUserId;
        }

        /// <summary>
        /// Returns a list of tasks assigned to the username.
        /// </summary>
        public List<Task> GetAssignedTasksByUsername(string username)
        {
            int currentUserId = appDbContext.Users.Where(user => user.Username == username).First().Id;

            List<Task> tasksForUserId = appDbContext.Tasks.Where(task => task.AssignedTo == currentUserId).ToList();

            return tasksForUserId;
        }

        public Task GetTaskById(int taskId)
        {
            Task task = appDbContext.Tasks.Where(task => task.Id == taskId).FirstOrDefault();
            return task;
        }

        /// <summary>
        /// Put assignee to the task.
        /// </summary>
        public void AssignTask(string username, int taskId)
        {
            Task task = GetTaskById(taskId);
            int userId = appDbContext.Users.Where(user => user.Username == username).First().Id;
            task.AssignedTo = userId;
            appDbContext.SaveChanges();
        }

        /// <summary>
        /// Save the passed Task object into the database.
        /// </summary>
        public void SaveTask(Task task)
        {
            appDbContext.Add(task);
            appDbContext.SaveChanges();
        }
    }
}
