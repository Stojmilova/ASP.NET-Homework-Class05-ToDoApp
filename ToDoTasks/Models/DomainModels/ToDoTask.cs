﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoTasks.Models.Enums;

namespace ToDoTasks.Models.DomainModels
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TypePriority Priority { get; set; }  
        public TypeStatus Status { get; set; }
        public TypeOfTask TaskType { get; set; }
        public List<SubTask> SubTasks { get; set; }

        public ToDoTask()
        {
            SubTasks = new List<SubTask>();
        }
    }
}
