using MvvmGen;
using MvvmGen.ViewModels;
using System.Collections.ObjectModel;

namespace TCH.ViewModels
{
    [ViewModel]
    public partial class MainViewModel : ViewModelBase
    {
        [Property] private EmployeeViewModel _selectedEmployee;

        public ObservableCollection<EmployeeViewModel> Employees { get; } = [];

        public void Load()
        {
            Employees.Add(new() { FirstName = "Julia", LastName = "Rockstar" });
            Employees.Add(new() { FirstName = "Anna", LastName = "Russell" });
            Employees.Add(new() { FirstName = "Marc", LastName = "Smith" });
            Employees.Add(new() { FirstName = "Thomas", LastName = "Huber" });
            Employees.Add(new() { FirstName = "Sara", LastName = "Jackson" });
        }
    }
}