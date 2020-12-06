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
using Task = T_FORCE.Models.Task;

namespace T_FORCE.Controllers
{
    public class KanbanController : Controller
    {

        [Authorize]
        public IActionResult CreateBoard()
        {
            return View();
        }

        [Authorize][HttpPost]
        public async Task<IActionResult> CreateBoard(string name, string projectName, List<string> columnName)
        {
            ModelFactory modelFactory = new ModelFactory();
            KanbanBoardRepository kanbanBoardRepository = new KanbanBoardRepository();

            int currentUserId = int.Parse(HttpContext.User.FindFirstValue(Authenticate.UserIdClaim));

            KanbanBoard board = modelFactory.CreateKanbanBoard(name, currentUserId, DateTime.UtcNow, columnName.Count, columnName, projectName);
            await kanbanBoardRepository.SaveKanbanBoard(board);

            return RedirectToAction("Boards");
        }

        [Obsolete("This method is obsolete and made for experimental purposes only.", false)]
        [Authorize]
        public async Task<IActionResult> CreateTypicalBoard()
        {
            string name = "DEBUG";

            ModelFactory modelFactory = new ModelFactory();
            KanbanBoardRepository kanbanBoardRepository = new KanbanBoardRepository();

            int currentUserId = int.Parse(HttpContext.User.FindFirstValue(Authenticate.UserIdClaim));
            KanbanBoard board = modelFactory.CreateTypicalKanbanBoard(name, currentUserId, DateTime.UtcNow);

            await kanbanBoardRepository.SaveKanbanBoard(board);

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult Boards()
        {
            KanbanBoardRepository kanbanBoardRepository = new KanbanBoardRepository();

            return View(kanbanBoardRepository.GetAll());
        }

        [Authorize]
        public IActionResult Board(string id)
        {
            KanbanBoardRepository kanbanBoardRepository = new KanbanBoardRepository();

            return View(kanbanBoardRepository.GetKanbanBoardById(id));
        }

        [Authorize][HttpPost]
        public async Task<IActionResult> AddTask(string taskProjectCodeId, int boardId, string columnDesc)
        {
            KanbanBoardRepository kanbanBoardRepository = new KanbanBoardRepository();
            TaskRepository taskRepository = new TaskRepository();

            KanbanBoard kanbanBoard = kanbanBoardRepository.GetKanbanBoardById(Convert.ToString(boardId));
            int columnNumber = kanbanBoard.GetColumnNumber(columnDesc);
            Task task = taskRepository.GetTaskByProjectCodeId(taskProjectCodeId);

            if (task != null)
            {
                kanbanBoard.AddSwim(columnNumber, task.Id);
                await kanbanBoardRepository.UpdateKanbanBoard(kanbanBoard);
            }

            return RedirectToAction("Board", new { id = kanbanBoard.Id });
        }
    }
}
