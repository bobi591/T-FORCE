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
using T_FORCE.UI;
using Task = T_FORCE.Models.Task;

namespace T_FORCE.Controllers
{

    /// <summary>
    /// The main <c>KanbanController</c> class.
    /// Contains methods for performing requests related to Kanban Boards.
    /// </summary>
    public class KanbanController : Controller
    {


        /// <summary>
        /// Returns the Create Custom Board page.
        /// </summary>
        [Authorize]
        public IActionResult CreateCustomBoard()
        {
            return View();
        }

        /// <summary>
        /// HTTP Request - Create new Custom Kanban Board.
        /// </summary>
        /// <returns>
        /// Redirection to the Boards page.
        /// </returns>
        /// <param name="name">The desired Kanban Board name.</param>
        /// <param name="projectName">The desired project name of the Kanban Board (the project name should be existing).</param>
        /// <param name="columnNamesElements">List of the columns in the Kanban Board.</param>
        [Authorize][HttpPost]
        public async Task<IActionResult> CreateCustomBoard(string name, string projectName, List<string> columnNamesElements)
        {
            ModelFactory modelFactory = new ModelFactory();
            KanbanBoardRepository kanbanBoardRepository = new KanbanBoardRepository();

            int currentUserId = int.Parse(HttpContext.User.FindFirstValue(Authenticate.UserIdClaim));

            KanbanBoard board = modelFactory.CreateKanbanBoard(name, currentUserId, DateTime.UtcNow, columnNamesElements.Count, columnNamesElements, projectName, true);
            await kanbanBoardRepository.SaveKanbanBoard(board);

            return RedirectToAction("Boards");
        }

        /// <summary>
        /// HTTP Request - Create new Typical Kanban Board with three columns.
        /// </summary>
        /// <returns>
        /// Redirection to the Home Page.
        /// </returns>
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
        /// <summary>
        /// View all boards.
        /// </summary>
        /// <returns>
        /// Boards view with a model list of created boards.
        /// </returns>
        [Authorize]
        public IActionResult Boards()
        {
            KanbanBoardRepository kanbanBoardRepository = new KanbanBoardRepository();

            return View(kanbanBoardRepository.GetAll());
        }

        /// <summary>
        /// View a Kanban Board.
        /// </summary>
        /// <returns>
        /// Returns the board view with the kanban board model.
        /// </returns>
        /// <param name="id">ID of the Kanban Board to be shown.</param>
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

        /// <summary>
        /// HTTP Request - Moves a task from one column to another.
        /// </summary>
        /// <returns>
        /// Redirection to Board view with updated Kanban Board data as model.
        /// </returns>
        /// <param name="taskProjectCodeId">The Project Code ID of the task. (ex. SUP, CAT, etc..)</param>
        /// <param name="boardId">The Kanban Board ID.</param>
        /// <param name="columnDesc">The destination column name. (ex. In Progress, Resolved)</param>
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
            else //If the board is default, change the task status. The board swims will be refreshed automatically when the Kanban Board is opened next time.
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
