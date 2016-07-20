using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceInterfaces
{
    public class TaskDto
    {
        public int ID
        {
            set;
            get;
        }

        public string Description
        {
            set;
            get;
        }

        public string Priority
        {
            get;
            set;
        }

        public DateTime DueDate
        {
            get;
            set;
        }

        public bool Completed
        {
            get;
            set;

        }
    }
}
