using Controllers;
using Microsoft.Practices.Unity;
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

            container = new UnityContainer();
            container.RegisterType<ISettings, ApplicationSettings>();
            container.RegisterType<ITaskService, TaskServiceAdo>();
            container.RegisterType<IObjectMapper, MapperAutoMapper>();
            container.RegisterType<TaskListController>();
            container.RegisterType<TaskListView>();

            MainWindow = container.Resolve<TaskListView>();
            MainWindow.Show();

            ((TaskListController)MainWindow.DataContext).OnLoad();
        }

        private void CreateMappings()
        {
            AutoMapper.Mapper.CreateMap<TaskDto, TaskViewModel>();
        }

        private IUnityContainer container;
    }
}
