using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using T_FORCE.EntityFramework;
using T_FORCE.EntityFramework.DataUtilities;
using T_FORCE.Home.Models;
using T_FORCE.Kanban.Models;
using T_FORCE.Tasks.Models;
using T_FORCE.UI;
using T_FORCE.Users.Processes;

namespace T_FORCE.Home.Controllers
{
    /// <summary>
    /// The main <c>HomeController</c> class.
    /// Contains methods for performing requests from the Home Page.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        /// <summary>
        /// Returns the T-Force home page.
        /// </summary>
        [Authorize]
        public IActionResult Index()
        {
            TaskRepository taskRepository = new TaskRepository();

            List<Tasks.Models.Task> createdTasks = taskRepository.GetTasksCreatedByUsername(HttpContext.User.FindFirstValue(Authenticate.UsernameClaim));
            List<Tasks.Models.Task> assignedTasks = taskRepository.GetAssignedTasksByUsername(HttpContext.User.FindFirstValue(Authenticate.UsernameClaim));

            Dictionary<string, List<Tasks.Models.Task>> dictResult = new Dictionary<string, List<Tasks.Models.Task>>();

            dictResult.Add(PredefinedViewBag.CreatedTasks, createdTasks);
            dictResult.Add(PredefinedViewBag.AssignedTasks, assignedTasks);

            return View(dictResult);
        }
        /// <summary>
        /// Returns the T-Force privacy page.
        /// </summary>
        public IActionResult Privacy()
        {
            return View();
        }


        /// <summary>
        /// HTTP Request - Create new Project.
        /// </summary>
        /// <returns>
        /// Redirection to the home page.
        /// </returns>
        /// <param name="projectName">The desired project name.</param>
        /// <param name="projectCode">The desired project code.</param>
        /// <param name="taskStatusesElements">List of the available task statuses for tasks assigned to the project.</param>
        public async Task<IActionResult> CreateProject(string projectName, string projectCode, List<string> taskStatusesElements)
        {
            ModelFactory modelFactory = new ModelFactory();
            ProjectRepository projectRepository = new ProjectRepository();

            int currentUserId = int.Parse(HttpContext.User.FindFirstValue(Authenticate.UserIdClaim));

            Project project = modelFactory.CreateProject(projectName, projectCode, currentUserId, DateTime.Now.ToUniversalTime(), taskStatusesElements);

            if (ObjectUniquenessCheck.ProjectIsUnique(project))
            {
                ViewBag.Message = await projectRepository.SaveProject(project);

                //Create default kanbanboard for the project (This board will not be custom!)
                KanbanBoard kanbanBoard = modelFactory.CreateKanbanBoard
                    (projectName, currentUserId, DateTime.Now, project.GetTaskStatuses().Count, project.GetTaskStatuses(), projectName, false);

                KanbanBoardRepository kanbanBoardRepository = new KanbanBoardRepository();
                await kanbanBoardRepository.SaveKanbanBoard(kanbanBoard);
            }
            else
            {
                ViewBag.Message = "A project with same code or name already exists!";
            }

            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
