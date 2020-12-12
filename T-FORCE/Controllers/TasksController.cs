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
    /// <summary>
    /// The main <c>TasksController</c> class.
    /// Contains methods for performing requests related to Tasks.
    /// </summary>
    public class TasksController : Controller
    {
        /// <summary>
        /// Returns the Create Task page.
        /// </summary
        [Authorize]
        public IActionResult CreateTask()
        {
            return View();
        }
        /// <summary>
        /// HTTP Request - Create new Task.
        /// </summary>
        /// <returns>
        /// Redirection to the Home page.
        /// </returns>
        /// <param name="name">The name of the task.</param>
        /// <param name="description">The description of the task.</param>
        /// <param name="projectName">The name of the parent project.</param>
        /// <param name="taskTypes">The task type. (ex. EPIC, ISSUE, TASK)</param>
        /// <param name="expectedEndDate">Expected date when the task should be finished.</param>
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

        /// <summary>
        /// View a task.
        /// </summary>
        /// <returns>
        /// Redirection to the View Task page.
        /// </returns>
        /// <param name="taskId">The ID of the task that should be opened.</param>
        [Authorize][HttpGet]
        public IActionResult ViewTask(string taskId)
        {
            TaskRepository taskRepository = new TaskRepository();
            Models.Task requestedTask = taskRepository.GetTaskById(taskId);
            return View(requestedTask);
        }

        /// <summary>
        /// HTTP Request - Assigns a task to the current that calls this action.
        /// </summary>
        /// <returns>
        /// Redirection to the View Task page with updated task entity as model.
        /// </returns>
        /// <param name="taskId">The ID of the task that should be assigned to the current user.</param>
        [Authorize][HttpGet]
        public async Task<IActionResult> AssignToMe(string taskId)
        {
            TaskRepository taskRepository = new TaskRepository();

            Models.Task requestedTask = taskRepository.GetTaskById(taskId);
            requestedTask.AssignedTo = int.Parse(HttpContext.User.FindFirstValue(Authenticate.UserIdClaim));
            await taskRepository.UpdateTask(requestedTask);
            return View("ViewTask",requestedTask);
        }

        /// <summary>
        /// HTTP Request - Change the status of a task.
        /// </summary>
        /// <returns>
        /// Redirection to the View Task page with updated task entity as model.
        /// </returns>
        /// <param name="taskStatuses">The new status of the task.</param>
        /// <param name="taskId">The ID of the task that should be assigned to the current user.</param>
        [Authorize][HttpPost]
        public async Task<IActionResult> ChangeTaskStatus(string taskStatuses, string taskId)
        {
            TaskRepository taskRepository = new TaskRepository();

            Models.Task task = taskRepository.GetTaskById(taskId);

            task.TaskStatus = taskStatuses;
            await taskRepository.UpdateTask(task);

            return View("ViewTask", task);
        }

        /// <summary>
        /// HTTP Request - Retrieve the list of available task statuses in the project.
        /// </summary>
        /// <returns>
        /// JSON array with a list of available task statuses in the Project.
        /// </returns>
        /// <param name="projectCode">The Project Code.</param>
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

        /// <summary>
        /// HTTP Request - Add comment in the task.
        /// </summary>
        /// <returns>
        /// Redirection to the View Task page with updated task entity as model.
        /// </returns>
        /// <param name="taskId">The Task ID of the task that should be commented.</param>
        /// <param name="comment">The comment that should be added to the task.</param>
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
