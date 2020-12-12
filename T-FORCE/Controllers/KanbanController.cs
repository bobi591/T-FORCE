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
        public IActionResult CreateCustomBoard()
        {
            return View();
        }

        [Authorize][HttpPost]
        public async Task<IActionResult> CreateCustomBoard(string name, string projectName, List<string> columnName)
        {
            ModelFactory modelFactory = new ModelFactory();
            KanbanBoardRepository kanbanBoardRepository = new KanbanBoardRepository();

            int currentUserId = int.Parse(HttpContext.User.FindFirstValue(Authenticate.UserIdClaim));

            KanbanBoard board = modelFactory.CreateKanbanBoard(name, currentUserId, DateTime.UtcNow, columnName.Count, columnName, projectName, true);
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

            KanbanBoard kanbanBoardToShow = kanbanBoardRepository.GetKanbanBoardById(id);

            if (!kanbanBoardToShow.IsCustomBoard())
            {
                kanbanBoardToShow.RefreshBoardContent(); //If the board is not custom board, refresh the Board content before opening!
            }

            return View(kanbanBoardRepository.GetKanbanBoardById(id));
        }

        [Authorize][HttpPost]
        public async Task<IActionResult> TaskColumnSwitch(string taskProjectCodeId, int boardId, string columnDesc)
        {
            KanbanBoardRepository kanbanBoardRepository = new KanbanBoardRepository();
            TaskRepository taskRepository = new TaskRepository();

            KanbanBoard kanbanBoard = kanbanBoardRepository.GetKanbanBoardById(Convert.ToString(boardId));
            Task task = taskRepository.GetTaskByProjectCodeId(taskProjectCodeId);

            if (kanbanBoard.IsCustomBoard()) //If the board is custom, do not change the actual task status.
            {
                int columnNumber = kanbanBoard.GetColumnNumber(columnDesc);
                kanbanBoard.AddSwim(columnNumber, task.Id);
                await kanbanBoardRepository.UpdateKanbanBoard(kanbanBoard);
            }
            else //If the board is default, change the task status. The board swims will be refreshed automatically on next board view.
            {
                if (task != null)
                {
                    task.TaskStatus = columnDesc;
                    await taskRepository.UpdateTask(task);
                }
            }

            return RedirectToAction("Board", new { id = kanbanBoard.Id });
        }
    }
}
