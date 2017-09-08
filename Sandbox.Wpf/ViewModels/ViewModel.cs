using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace Sandbox.Wpf.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Customer> Customers { get; set; }
        public ICommand RemoveColumn { get; set; }

        public ViewModel()
        {
            Customers = new ObservableCollection<Customer> { new Customer("Bob", 1), new Customer("Bill", 3) };
            RemoveColumn = new CommandHandler(Foo, true);
        }

        public void Foo(object thing)
        {
            MessageBox.Show(thing.ToString());
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
