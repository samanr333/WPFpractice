using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class WindowListView : Window
    {
        public WindowListView()
        {
            DataContext = this;
            entries = new ObservableCollection<String>();
            InitializeComponent();
        }
        private ObservableCollection<string> entries;

        public ObservableCollection<string> Entries
        {
            get { return entries; }
            set { entries = value; }
        }

        void AddList(object sender, RoutedEventArgs e)
        {
            /*MyList.Items.Add(ListEntry.Text);*/
            Entries.Add(ListEntry.Text);
        }
        void ClearList(object sender, RoutedEventArgs e)
        {
            /*MyList.Items.Clear();*/
            Entries.Clear();
        }
        void DeleteList(object sender, RoutedEventArgs e)
        {
            /*object items = MyList.SelectedItems;*/

            /*var items = MyList.SelectedItems;
            var result = MessageBox.Show($"Are you sure you want to delete {items.Count} items?", "!", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                var itemlist = new ArrayList (items);
                foreach(var item in itemlist)
                {
                    MyList.Items.Remove(item);
                }
            }*/
            string selectedItem = (string)MyList.SelectedItem;
            Entries.Remove(selectedItem);
        }
        void UpdateList(object sender, RoutedEventArgs e)
        {
            int selectedIndex = MyList.SelectedIndex;
            string updatedText = ListEntry.Text;
            Entries[selectedIndex] = updatedText;
            }
        }

    }
}
