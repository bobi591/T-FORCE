using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using T_FORCE.Models;
using T_FORCE.Processes;
using T_FORCE.Repositories;

namespace T_FORCE.Controllers
{
    public class TasksController:Controller
    {
        [Authorize]
        public IActionResult CreateTask()
        {
            return View();
        }

        [Authorize][HttpPost]
        public IActionResult CreateTask(string name, string description, string taskTypes, string expectedEndDate)
        {
            ModelFactory modelFactory = new ModelFactory();
            TaskRepository taskRepository = new TaskRepository();

            int currentUserId = int.Parse(HttpContext.User.FindFirstValue(Authenticate.UserIdClaim));
            DateTime endDate = DateTime.Parse(expectedEndDate);
            TaskType taskTypeEnum = (TaskType)Enum.Parse(typeof(TaskType), taskTypes);

            Task task = modelFactory.CreateTask(name, description, taskTypeEnum, currentUserId, DateTime.Now.ToUniversalTime(), endDate, null);
            taskRepository.SaveTask(task);

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult CreatedTasks()
        {
            TaskRepository taskRepository = new TaskRepository();

            List<Task> createdTasks = taskRepository.GetTasksCreatedByUsername(HttpContext.User.FindFirstValue(Authenticate.UsernameClaim));

            return View(createdTasks);
        }

        [Authorize]
        public JsonResult GetTaskTypes()
        {
            List<String> taskTypes = new List<string>();

            foreach (TaskType type in (TaskType[])Enum.GetValues(typeof(TaskType)))
            {
                taskTypes.Add(type.ToString());
            }
            return Json(taskTypes);
        }
    }
}
