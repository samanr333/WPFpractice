using EFcrud.ViewModel;
using System;
using System.Windows.Input;

namespace EFcrud.Command
{
    public class RemoveCommand:ICommand
    {
        StudentViewModel RemoveButtonClick;
        public RemoveCommand(StudentViewModel studentViewModel)
        {
            RemoveButtonClick = studentViewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            RemoveButtonClick.Remove(parameter);
        }
    }
}
