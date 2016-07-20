using Controllers;
using ServiceImplementations;
using ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UI;
using ViewModels;

namespace DependencyInjectionWpf
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private void OnApplicationStartup(object sender, StartupEventArgs e)
        {
            CreateMappings();

            var taskServiceAdo = new TaskServiceAdo();
            var mapper = new MapperAutoMapper();
            var controller = new TaskListController(taskServiceAdo, mapper, new ApplicationSettings());
            MainWindow = new TaskListView(controller);
            MainWindow.Show();

            controller.OnLoad();
        }

        private void CreateMappings()
        {
            AutoMapper.Mapper.CreateMap<TaskDto, TaskViewModel>();
        }
    }
}
