using DragandDrop.Model;
using System.Collections.ObjectModel;

namespace DragandDrop.ViewModel
{
    public class ToDoViewModel
    {
        public string? ToDoElement { get; set; }
        public ObservableCollection<ToDoModel> ToDo { get; set; }
        public ToDoViewModel()
        {
            ToDo = new ObservableCollection<ToDoModel>()
            {
                new ToDoModel{ToDoElement = "Eat"},
                new ToDoModel{ToDoElement = "Sleep"},
                new ToDoModel{ToDoElement = "DeadLift"},
                new ToDoModel{ToDoElement = "Repeat"},
            };
        }
    }
}
