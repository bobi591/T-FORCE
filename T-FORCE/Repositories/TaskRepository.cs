﻿using System;
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
        public async System.Threading.Tasks.Task AssignTask(string username, int taskId)
        {
            Task task = GetTaskById(taskId);
            int userId = appDbContext.Users.Where(user => user.Username == username).First().Id;
            task.AssignedTo = userId;
            await appDbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Save the passed Task object into the database.
        /// </summary>
        public async System.Threading.Tasks.Task SaveTask(Task task)
        {
            appDbContext.Add(task);
            await appDbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Update the passed Task object into the database.
        /// </summary>
        public async System.Threading.Tasks.Task UpdateTask(Task task)
        {
            appDbContext.Update(task);
            await appDbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Get task by id.
        /// </summary>
        public Task GetTaskById(string id)
        {

            Task task = appDbContext.Tasks.Where(task => task.Id == int.Parse(id)).First();

            return task;
        }
    }
}
