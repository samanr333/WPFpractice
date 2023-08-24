using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Validation.ViewModel;

namespace Validation.Command
{
    public class RelayCommand: ICommand
    {
            StudentViewModel AddButtonClick;
            public RelayCommand(StudentViewModel studentViewModel)
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
                AddButtonClick.OnExecute();
            }
        }
    }


