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
using System.Xml.Linq;

namespace WpfApp1
{
    public partial class WindowAvengers : Window
    {
        public WindowAvengers()
        {
            InitializeComponent();
        }
        void AvengerName(object sender, RoutedEventArgs e)
        {
            string[] nameArray = { "CAPTAIN AMERICA", "IRON MAN", "HAWKEYE", "DR STRANGE", "LOKI", "THOR", "HULK", "BLACK WIDOW", "SPIDERMAN"};
            Random random = new Random();
            int i = random.Next(0, nameArray.Length);
            string avengername = nameArray[i];
            string yourname = yourName.Text;
            displayName.Text = $"{yourname} you are {avengername}";
        }
    }
}
