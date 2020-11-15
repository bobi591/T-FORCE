using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
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
        public async Task<IActionResult> CreateTask(string name, string description, string taskTypes, string expectedEndDate)
        {
            ModelFactory modelFactory = new ModelFactory();
            TaskRepository taskRepository = new TaskRepository();

            int currentUserId = int.Parse(HttpContext.User.FindFirstValue(Authenticate.UserIdClaim));
            DateTime endDate = DateTime.Parse(expectedEndDate);
            TaskType taskTypeEnum = (TaskType)Enum.Parse(typeof(TaskType), taskTypes);

            Models.Task task = modelFactory.CreateTask(name, description, taskTypeEnum, currentUserId, DateTime.Now.ToUniversalTime(), endDate, null);
            await taskRepository.SaveTask(task);

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult CreatedTasks()
        {
            TaskRepository taskRepository = new TaskRepository();

            List<Models.Task> createdTasks = taskRepository.GetTasksCreatedByUsername(HttpContext.User.FindFirstValue(Authenticate.UsernameClaim));

            return View(createdTasks);
        }


        [Authorize][HttpGet]
        public IActionResult ViewTask(string id)
        {
            TaskRepository taskRepository = new TaskRepository();
            Models.Task requestedTask = taskRepository.GetTaskById(id);
            return View(requestedTask);
        }

        [Authorize][HttpGet]
        public async Task<IActionResult> AssignToMe(string id)
        {
            TaskRepository taskRepository = new TaskRepository();

            Models.Task requestedTask = taskRepository.GetTaskById(id);
            requestedTask.AssignedTo = int.Parse(HttpContext.User.FindFirstValue(Authenticate.UserIdClaim));
            await taskRepository.UpdateTask(requestedTask);
            return View("ViewTask",requestedTask);
        }

        [Authorize][HttpPost]
        public async Task<IActionResult> ChangeTaskStatus(string taskStatuses, string taskId)
        {
            TaskRepository taskRepository = new TaskRepository();

            Models.Task task = taskRepository.GetTaskById(taskId);
            Models.TaskStatus taskStatusEnum = (Models.TaskStatus)Enum.Parse(typeof(Models.TaskStatus), taskStatuses);

            task.TaskStatus = taskStatusEnum;
            await taskRepository.UpdateTask(task);

            return View("ViewTask", task);
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

        [Authorize]
        public JsonResult GetTaskStatuses()
        {
            List<String> taskStatuses = new List<string>();

            foreach (Models.TaskStatus status in (Models.TaskStatus[])Enum.GetValues(typeof(Models.TaskStatus)))
            {
                taskStatuses.Add(status.ToString());
            }

            return Json(taskStatuses);
        }
    }
}
