using Controllers;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
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

            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            container = new UnityContainer().LoadConfiguration(section);

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
