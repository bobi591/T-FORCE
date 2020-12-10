using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using T_FORCE.Models;
using T_FORCE.Processes;
using T_FORCE.Repositories;
using T_FORCE.UserInterfaceUtils;

namespace T_FORCE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
        {
            TaskRepository taskRepository = new TaskRepository();

            List<Models.Task> createdTasks = taskRepository.GetTasksCreatedByUsername(HttpContext.User.FindFirstValue(Authenticate.UsernameClaim));
            List<Models.Task> assignedTasks = taskRepository.GetAssignedTasksByUsername(HttpContext.User.FindFirstValue(Authenticate.UsernameClaim));

            Dictionary<string, List<Models.Task>> dictResult = new Dictionary<string, List<Models.Task>>();

            dictResult.Add(PredefinedViewBag.CreatedTasks, createdTasks);
            dictResult.Add(PredefinedViewBag.AssignedTasks, assignedTasks);

            return View(dictResult);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> CreateProject(string projectName, string projectCode, List<string> taskStatus)
        {
            ModelFactory modelFactory = new ModelFactory();
            ProjectRepository projectRepository = new ProjectRepository();

            int currentUserId = int.Parse(HttpContext.User.FindFirstValue(Authenticate.UserIdClaim));

            Project project = modelFactory.CreateProject(projectName, projectCode, currentUserId, DateTime.Now.ToUniversalTime(), taskStatus);

            ViewBag.Message = await projectRepository.SaveProject(project);

            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
