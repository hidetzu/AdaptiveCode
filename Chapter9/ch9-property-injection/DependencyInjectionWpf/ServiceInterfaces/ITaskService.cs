﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterfaces
{
    public interface ITaskService
    {
        ISettings Settings {set;get;}

        IEnumerable<TaskDto> GetAllTasks();
    }
}
