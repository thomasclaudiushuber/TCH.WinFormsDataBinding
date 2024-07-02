using MvvmGen;
using MvvmGen.ViewModels;

namespace TCH.ViewModels
{
    [ViewModel]
    public partial class EmployeeViewModel : ViewModelBase
    {
        [Property] private string _firstName;
        [Property] private string _lastName;
        [Property] private string _saveMessage;

        [Command(CanExecuteMethod = nameof(CanSave))]
        public async Task Save()
        {
            var message = $"Saved {FirstName} {LastName}";
            SaveMessage = message;
            await Task.Delay(3000);
            if (SaveMessage == message)
            {
                SaveMessage = string.Empty;
            }
        }

        [CommandInvalidate(nameof(FirstName))]
        public bool CanSave()
        {
            return !string.IsNullOrWhiteSpace(FirstName);
        }
    }
}