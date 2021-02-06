using ClosedXML.Excel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using T_FORCE.EntityFramework;
using T_FORCE.Kanban.Models;
using T_FORCE.Tasks.Models;
using T_FORCE.Users.Models;
using T_FORCE.Users.Processes;

namespace T_FORCE.API.Controllers
{
    /// <summary>
    /// The main <c>Base API</c> class.
    /// Contains methods for performing HTTP requests related to the TForce API.
    /// </summary>
    public class BaseAPI : Controller
    {
        [Route("API/Base/Authenticate")]
        [HttpPost]
        public async Task<IActionResult> Authenticate(string username, string password)
        {
            Authenticate authProcess = new Authenticate();
            Tuple<ClaimsPrincipal, string> authProcessResult = await authProcess.GetClaimsPrincipal(username, password);
            ClaimsPrincipal currentClaimsPrincipal = authProcessResult.Item1;

            if (currentClaimsPrincipal != null)
            {
                await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                currentClaimsPrincipal,
                new AuthenticationProperties
                {
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(10),
                    IsPersistent = true,
                    AllowRefresh = true
                });

                return Ok("You have been successfully authenticated. Your session will expire in 10 minutes!");
            }
            else
            {
                return StatusCode(401,"The provided credentials are wrong or are not existing.");
            }
        }

        [Route("API/Base/GetProjectTaskStatuses")]
        [Authorize]
        [HttpGet]
        public async Task<ActionResult> GetProjectTaskStatuses(string projectCode)
        {
            TaskRepository taskRepository = new TaskRepository();
            ProjectRepository projectRepository = new ProjectRepository();
            UserRepository userRepository = new UserRepository();

            Project project = projectRepository.GetProjectByCode(projectCode);

            DataTable result = new DataTable();
            result.Columns.Add("Task Code", typeof(string));
            result.Columns.Add("Task Name", typeof(string));
            result.Columns.Add("Assignee", typeof(string));
            result.Columns.Add("Status", typeof(string));


            if (project != null)
            {
                List<Tasks.Models.Task> tasksInProject = taskRepository.GetTasksInProject(project);

                foreach(Tasks.Models.Task task in tasksInProject)
                {
                    result.Rows.Add(projectCode + task.Id.ToString(), task.Name, task.GetAssigneeFirstLastName(), task.TaskStatus);
                }

                XLWorkbook resultExcel = new XLWorkbook();
                resultExcel.AddWorksheet(result, project.Name + " - Tasks");

                MemoryStream memoryStream = new MemoryStream();

                resultExcel.SaveAs(memoryStream);

                resultExcel.Dispose();

                result.Dispose();

                return File(memoryStream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", projectCode+"_export.xlsx");
            }
            else
            {
                return StatusCode(403, "No project with code " + projectCode + " was found.");
            }
        }

    }
}
