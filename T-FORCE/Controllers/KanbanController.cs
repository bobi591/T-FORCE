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
    public class KanbanController : Controller
    {
        [Authorize][HttpPost]
        public async Task<IActionResult> CreateBoard(string name)
        {
            ModelFactory modelFactory = new ModelFactory();
            KanbanBoardRepository kanbanBoardRepository = new KanbanBoardRepository();

            int currentUserId = int.Parse(HttpContext.User.FindFirstValue(Authenticate.UserIdClaim));
            KanbanBoard board = modelFactory.CreateKanbanBoard(name, currentUserId, DateTime.UtcNow);

            await kanbanBoardRepository.SaveKanbanBoard(board);

            return RedirectToAction("Index", "Home");
        }


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
        public IActionResult MyBoards()
        {
            KanbanBoardRepository kanbanBoardRepository = new KanbanBoardRepository();
            int currentUserId = int.Parse(HttpContext.User.FindFirstValue(Authenticate.UserIdClaim));

            List<KanbanBoard> kanbanBoards = kanbanBoardRepository.GetKanbanBoardsCreatedBy(currentUserId);

            return View("Board",kanbanBoards.First());
        }

        [Authorize][HttpPost]
        public IActionResult AddTask(int taskId, int boardId, string columnSelector)
        {
            return null;
        }
    }
}
