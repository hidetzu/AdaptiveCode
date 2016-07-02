using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AsyncDecorator
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel(IComponent component)
        {
            this.component = component;
            this.calculateCommand = new RelayCommand(Calculate);
        }

        public string Result
        {
            set
            {
                if (result != value)
                {
                    result = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Result"));
                }
            }
            get
            {
                return result;
            }
        }

        public ICommand CalculateCommand
        {
            get { return calculateCommand; }
        }

        private void Calculate(object parameter)
        {
            Result = "Processing...";
            component.Process();
            Result = "Finished!";
        }


        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private string result;
        private IComponent component;
        private RelayCommand calculateCommand;
    }
}
