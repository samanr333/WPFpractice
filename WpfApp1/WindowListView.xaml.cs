using System;
using System.Collections.Generic;
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
            InitializeComponent();
        }
        void AddList(object sender, RoutedEventArgs e)
        {
            MyList.Items.Add(ListEntry.Text);
        }
        void ClearList(object sender, RoutedEventArgs e)
        {
            MyList.Items.Clear();
        }
        void DeleteList(object sender, RoutedEventArgs e)
        {
            int index = MyList.SelectedIndex;
            MyList.Items.RemoveAt(index);
        }
    }
}
