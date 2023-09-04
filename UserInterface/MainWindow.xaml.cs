using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace UserInterface
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Task> TaskItems { get; set; } = new ObservableCollection<Task>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            TaskItems.Add(new Task { Title = "Eat", Description = "Eat your breakfast" });
        }
        private void AddClick(object sender, RoutedEventArgs e)
        {
            string title = TitleBox.Text;
            string description = DescBox.Text;
            if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(description))
            {
                TaskItems.Add(new Task { Title = title, Description = description });
            }
           
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null && button.DataContext is Task taskItem)
            {
                TaskItems.Remove(taskItem);
            }
        }


    }
}
