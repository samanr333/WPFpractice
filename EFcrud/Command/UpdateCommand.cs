using EFcrud.ViewModel;
using System;
using System.Windows;
using System.Windows.Input;

namespace EFcrud.Command
{
    public class UpdateCommand : ICommand
    {
        StudentViewModel UpdateButtonClick;
        public UpdateCommand(StudentViewModel studentViewModel)
        {
            UpdateButtonClick = studentViewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            UpdateButtonClick.UpdateList(); 
        }
    }
}
