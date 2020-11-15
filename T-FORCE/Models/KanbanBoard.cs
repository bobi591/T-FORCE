using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

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
            if (Swims != null)
            {
                return JsonConvert.DeserializeObject<Dictionary<int, List<int>>>(this.Swims);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Puts the task to the column.
        /// </summary>
        public void AddSwim(int columnNumber, int taskId)
        {
            Dictionary<int, List<int>> swimValue = GetSwim();
            if (swimValue != null)
            {
                if (swimValue[columnNumber] == null)
                {
                    swimValue[columnNumber] = new List<int>();
                }

                swimValue[columnNumber].Add(taskId);
                this.Swims = JsonConvert.SerializeObject(swimValue);
            }
        }

    }
}
