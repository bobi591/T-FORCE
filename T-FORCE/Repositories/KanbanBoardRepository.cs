using System;
using System.Collections.Generic;
using System.Linq;
using T_FORCE.Models;

namespace T_FORCE.Repositories
{
    public class KanbanBoardRepository
    {
        private static IAppDbContextFactory IAppDbContextFactory = new AppDbContextFactory();
        private AppDbContext appDbContext = IAppDbContextFactory.CreateAppDbContext();

        /// <summary>
        /// Retrieves the kanban board by Id.
        /// </summary>
        public KanbanBoard GetKanbanBoardById(string kanbanBoardId)
        {
            KanbanBoard kanbanBoard = appDbContext.KanbanBoards.Where(board => board.Id == int.Parse(kanbanBoardId)).First();
            return kanbanBoard;
        }

        /// <summary>
        /// Saves the kanban board into the database.
        /// </summary>
        public async System.Threading.Tasks.Task SaveKanbanBoard(KanbanBoard kanbanBoard)
        {
            await appDbContext.AddAsync(kanbanBoard);
            await appDbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Gets the Kanban boards created by the user.
        /// </summary>
        public List<KanbanBoard> GetKanbanBoardsCreatedBy(int userId)
        {
            List<KanbanBoard> kanbanBoards = appDbContext.KanbanBoards.Where(board => board.CreatedBy == userId).ToList();
            return kanbanBoards;
        }
    }
}
