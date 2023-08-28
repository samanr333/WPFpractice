using DragandDrop.Model;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Input;

namespace DragandDrop.ViewModel
{
    public class ToDoViewModel
    {
        public string? ToDoElement { get; set; }
        public ObservableCollection<ToDoModel> ToDoList{ get; set; }
        public ObservableCollection<ToDoModel> DoneList { get; set; }
        private ToDoModel? draggedItem;
        public ToDoViewModel()
        {
            ToDoList = new ObservableCollection<ToDoModel>()
            {
                new ToDoModel{ToDoElement = "Eat"},
                new ToDoModel{ToDoElement = "Sleep"},
                new ToDoModel{ToDoElement = "DeadLift"},
                new ToDoModel{ToDoElement = "Repeat"},
            };
        }

        public void ToDoListElementMouseDown(object sender, MouseButtonEventArgs e)
        {
            // Store the dragged item
            draggedItem = (e.OriginalSource as FrameworkElement)?.DataContext as ToDoModel;
        }

        public void ToDoListView_Drop(object sender, DragEventArgs e)
        {
            if (draggedItem != null)
            {
                // Remove the item from the source list
                ToDoList.Remove(draggedItem);

                // Add the item to the target list
                DoneList.Add(draggedItem);

                // Reset draggedItem
                draggedItem = null;
            }
        }

        public void DoneListView_Drop(object sender, DragEventArgs e)
        {
            if (draggedItem != null)
            {
                // Remove the item from the source list
                DoneList.Remove(draggedItem);

                // Add the item to the target list
                ToDoList.Add(draggedItem);

                // Reset draggedItem
                draggedItem = null;
            }
        }
    }
}
