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
        public async Task<IActionResult> CreateTask(string name, string description, string projectName, string taskTypes, string expectedEndDate)
        {
            ModelFactory modelFactory = new ModelFactory();
            TaskRepository taskRepository = new TaskRepository();
            ProjectRepository projectRepository = new ProjectRepository();

            int currentUserId = int.Parse(HttpContext.User.FindFirstValue(Authenticate.UserIdClaim));
            DateTime endDate = DateTime.Parse(expectedEndDate);
            TaskType taskTypeEnum = (TaskType)Enum.Parse(typeof(TaskType), taskTypes);

            string projectCode = projectRepository.GetProjectByName(projectName).Code;

            Models.Task task = modelFactory.CreateTask(name, description, taskTypeEnum, currentUserId, DateTime.Now.ToUniversalTime(), endDate, projectCode,  null);
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

            task.TaskStatus = taskStatuses;
            await taskRepository.UpdateTask(task);

            return View("ViewTask", task);
        }

        [Authorize]
        public JsonResult GetTaskTypes(string projectName)
        {
            ProjectRepository projectRepository = new ProjectRepository();
            Project project = projectRepository.GetProjectByName(projectName);

            List<String> taskStatuses = new List<string>();

            foreach (string status in project.GetTaskStatuses())
            {
                taskStatuses.Add(status.ToString());
            }

            return Json(taskStatuses);
        }

        [Authorize]
        public JsonResult GetTaskStatuses(string projectCode)
        {
            ProjectRepository projectRepository = new ProjectRepository();
            Project project = projectRepository.GetProjectByCode(projectCode);

            List<String> taskStatuses = new List<string>();

            foreach (string status in project.GetTaskStatuses())
            {
                taskStatuses.Add(status.ToString());
            }

            return Json(taskStatuses);
        }

        [Authorize][HttpPost]
        public async Task<IActionResult> Comment(string taskId, string comment)
        {
            ModelFactory modelFactory = new ModelFactory();
            CommentRepository commentRepository = new CommentRepository();

            string userId = HttpContext.User.FindFirstValue(Authenticate.UserIdClaim);

            Comment commentObj = modelFactory.CreateComment(taskId, userId,DateTime.UtcNow, DateTime.UtcNow,comment);
            await commentRepository.SaveComment(commentObj);

            return RedirectToAction("ViewTask", new { id=taskId });

        }

    }
}
