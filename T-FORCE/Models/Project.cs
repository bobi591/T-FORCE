using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace T_FORCE.Models
{
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public string KanbanBoards { get; set; }

        /// <summary>
        /// Gets a list of Kanban board Ids assigned to the project.
        /// </summary>
        public List<int> GetAssignedKanbanBoardsIds()
        {
            if (this.KanbanBoards != null)
            {
                return JsonConvert.DeserializeObject<List<int>>(this.KanbanBoards);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Adds a Kanban board to project.
        /// </summary>
        public void AddKanbanBoard(int kanbanBoardId)
        {
            if (KanbanBoards != null)
            {
                List<int> kanbanBoards = GetAssignedKanbanBoardsIds();
                kanbanBoards.Add(kanbanBoardId);
            }
            else
            {
                List<int> kanbanBoards = new List<int>();
                KanbanBoards = JsonConvert.SerializeObject(kanbanBoards);
            }
        }
    }
}
