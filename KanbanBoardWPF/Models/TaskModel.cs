using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoardWPF.Models
{
    internal class TaskModel
    {
        public int TaskId { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskDeadline { get; set; }
        public TaskCategoryModel TaskCategory { get; set; }
        public TaskPriorityModel TaskPriority { get; set; }
    }
}
