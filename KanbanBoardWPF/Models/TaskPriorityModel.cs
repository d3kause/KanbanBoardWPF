﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoardWPF.Models
{
    internal class TaskPriorityModel
    {
        public int PriorityId { get; set; }
        public int PriorityLevel { get; set; }
        public string PriorityName { get; set; }
    }
}
