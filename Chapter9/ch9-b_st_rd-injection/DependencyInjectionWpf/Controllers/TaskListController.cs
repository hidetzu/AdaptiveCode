using ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Controllers
{
    public class TaskListController : INotifyPropertyChanged
    {
        public TaskListController(ITaskService taskService, IObjectMapper mapper)
        {
            this.taskService = taskService;
            this.mapper = mapper;
        }

        public ObservableCollection<TaskViewModel> AllTasks
        {
            get
            {
                return allTasks;
            }
            set
            {
                allTasks = value;
                PropertyChanged(this, new PropertyChangedEventArgs("AllTasks"));
            }
        }

        public void OnLoad()
        {
            var taskDtos = taskService.GetAllTasks();
            AllTasks = new ObservableCollection<TaskViewModel>(mapper.Map<IEnumerable<TaskViewModel>>(taskDtos));
        }


        private readonly ITaskService taskService;
        private readonly IObjectMapper mapper;

        private ObservableCollection<TaskViewModel> allTasks;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }

}
