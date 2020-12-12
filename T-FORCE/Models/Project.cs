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
        [Required]
        public string TaskStatuses { get; set; }

        /// <summary>
        /// Sets the available task statuses of the project.
        /// </summary
        public void SetTaskStatuses(List<string> statuses)
        {
            this.TaskStatuses = JsonConvert.SerializeObject(statuses);
        }
        /// <summary>
        /// Gets the available task statuses of the project.
        /// </summary
        public List<string> GetTaskStatuses()
        {
            return JsonConvert.DeserializeObject<List<string>>(this.TaskStatuses);
        }
    }
}
