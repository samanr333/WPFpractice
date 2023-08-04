using System.Windows.Controls;

namespace WpfApp1
{
    public class FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public partial class MultiBinding : Page
    {
        public MultiBinding()
        {
            InitializeComponent();
        }
    }
}
