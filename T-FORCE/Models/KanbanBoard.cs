using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Newtonsoft.Json;
using T_FORCE.Repositories;

namespace T_FORCE.Models
{
    public class KanbanBoard
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int NumberOfColumns { get; set; }
        [Required]
        public string Columns { get; set; }

        public string Swims { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public string Project { get; set; }
        [Required]
        public int CustomBoard { get; set; }

        /// <summary>
        /// Returns true if the board is custom board.
        /// </summary>
        public bool IsCustomBoard()
        {
            if (CustomBoard == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Checks the board's project and aligns the board column content properly.
        /// </summary>
        public async void RefreshBoardContent()
        {

            if (!this.IsCustomBoard()) //If custom board, do not refresh
            {
                ProjectRepository projectRepository = new ProjectRepository();
                Project currentProject = projectRepository.GetProjectByName(this.Project);

                TaskRepository taskRepository = new TaskRepository();
                List<Task> tasksInCurrentProject = taskRepository.GetTasksInProject(currentProject);

                foreach (Task task in tasksInCurrentProject)
                {
                    int column = this.GetColumnNumber(task.TaskStatus);
                    this.AddSwim(column, task.Id);
                }

                KanbanBoardRepository kanbanBoardRepository = new KanbanBoardRepository();
                await kanbanBoardRepository.UpdateKanbanBoard(this);
            }

        }


        //The property here is used for data transfer between Kaban Controller and the CreateBoard view.
        [NotMapped]
        public List<string> ColumnsList = new List<string>();

        /// <summary>
        /// Creates columns with in the kanban board.
        /// </summary>
        public void SetColumns(List<string> columnNames)
        {
            this.NumberOfColumns = columnNames.Count;
            this.Columns = JsonConvert.SerializeObject(columnNames);
        }

        /// <summary>
        /// Retrieves the names of the columns in the kanban board.
        /// </summary>
        public List<string> GetColumns()
        {
            return JsonConvert.DeserializeObject<List<string>>(this.Columns);
        }

        /*
         
         */
        /// <summary>
        /// Gets a dictionary with column number as key and list of task IDs in the column as value.
        /// </summary>
        public Dictionary<int,List<int>> GetSwim()
        {
            if (Swims != "")
            {
                return JsonConvert.DeserializeObject<Dictionary<int, List<int>>>(this.Swims);
            }
            else
            {
                return new Dictionary<int, List<int>>();
            }
        }

        /// <summary>
        /// Puts the task to the column.
        /// </summary>
        public void AddSwim(int columnNumber, int taskId)
        {
            Dictionary<int, List<int>> swimValue = GetSwim();

            //Check if the added task is already existing in another column and cleanup duplicates.
            foreach(int key in swimValue.Keys.ToList())
            {
                foreach(int listValue in swimValue[key].ToList())
                {
                    if (listValue == taskId)
                    {
                        swimValue[key].Remove(listValue);
                    }
                }
            }

            //Check if the column is declared in the empty Dictionary when adding a first record in the column.
            if (!swimValue.ContainsKey(columnNumber))
            {
                swimValue.Add(columnNumber, new List<int>());
            }

            swimValue[columnNumber].Add(taskId);
            this.Swims = JsonConvert.SerializeObject(swimValue);
        }

        /// <summary>
        /// Finds the column number by providing the column text.
        /// </summary>
        public int GetColumnNumber(string columnText)
        {
            return this.GetColumns().
                FindIndex(c => c == columnText) + 1;
        }

    }
}
