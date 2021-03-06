﻿using System;
using System.Collections.Generic;
using System.Linq;
using T_FORCE.Kanban.Models;

namespace T_FORCE.EntityFramework
{
    /// <summary>
    /// The main <c>KanbanBoardRepository</c> class.
    /// Contains methods for database related queries related to the KanbanBoard object.
    /// </summary>
    public class KanbanBoardRepository
    {
        private static readonly IAppDbContextFactory IAppDbContextFactory = new AppDbContextFactory();
        private readonly AppDbContext appDbContext = IAppDbContextFactory.CreateAppDbContext();

        /// <summary>
        /// Retrieves the kanban board by Id.
        /// </summary>
        public KanbanBoard GetKanbanBoardById(string kanbanBoardId)
        {
            KanbanBoard kanbanBoard = appDbContext.KanbanBoards.Where(board => board.Id == int.Parse(kanbanBoardId)).First();
            return kanbanBoard;
        }

        /// <summary>
        /// Retrieves all Kanban boards.
        /// </summary>
        public List<KanbanBoard> GetAll()
        {
            List<KanbanBoard> boards = appDbContext.KanbanBoards.ToList();
            return boards;
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
        /// Updates the kanban board into the database.
        /// </summary>
        public async System.Threading.Tasks.Task UpdateKanbanBoard(KanbanBoard kanbanBoard)
        {
            appDbContext.Update(kanbanBoard);
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
