﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.DAL.DTO
{
    public class TaskDTO
    {
        public int ID { get; set; }
        public string Task { get; set; }
        public int TaskState { get; set; }
    }
}
