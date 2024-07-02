using MvvmGen;
using MvvmGen.ViewModels;
using System.Collections.ObjectModel;

namespace TCH.ViewModels
{
    [ViewModel]
    public partial class MainViewModel : ViewModelBase
    {
        [Property] private EmployeeViewModel _selectedEmployee;

        public ObservableCollection<EmployeeViewModel> Employees { get; } = new();

        public void Load()
        {
            Employees.Add(new() { FirstName = "Holger", LastName = "Schwichtenberg" });
            Employees.Add(new() { FirstName = "Rainer", LastName = "Stropek" });
            Employees.Add(new() { FirstName = "Christian", LastName = "Wenz" });
            Employees.Add(new() { FirstName = "Thomas", LastName = "Huber" });
            Employees.Add(new() { FirstName = "André", LastName = "Krämer" });
        }
    }
}