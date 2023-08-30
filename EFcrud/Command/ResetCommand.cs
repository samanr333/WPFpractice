using EFcrud.ViewModel;
using System;
using System.Windows.Input;

namespace EFcrud.Command
{
    public class ResetCommand:ICommand
    {
        StudentViewModel ResetButtonClick;
        public ResetCommand(StudentViewModel studentViewModel)
        {
            ResetButtonClick = studentViewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            ResetButtonClick.Reset();
        }
    }
}
