using AsyncDecorator;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private void OnApplicationStartup(object sender, StartupEventArgs e)
        {
#if false
            MainWindow = new MainWindow(new MainWindowViewModel(new SlowComponent()));
#else
            MainWindow = new MainWindow(new MainWindowViewModel(
                new AsyncComponent(
                    new SlowComponent()
                    )
                    )
                );
#endif
            MainWindow.Show();
        }
    }
}
