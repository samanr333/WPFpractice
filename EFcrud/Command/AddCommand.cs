using System;
using System.Windows.Input;
using EFcrud.ViewModel;

namespace EFcrud.Command
{
    public class AddCommand: ICommand
    {
        StudentViewModel AddButtonClick;
        public AddCommand(StudentViewModel studentViewModel)
        {
            AddButtonClick = studentViewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            AddButtonClick.Add();
        }
    }
}


