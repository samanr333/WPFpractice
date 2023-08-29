using EFcrud.ViewModel;
using System;

namespace EFcrud.Command
{
    public class ResetCommand
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
