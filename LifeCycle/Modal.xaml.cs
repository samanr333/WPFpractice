using System;
using System.Windows;

namespace LifeCycle
{
    public partial class Modal : Window
    {
        public Modal()
        {
            InitializeComponent();
        }
        public void ConfirmClick(object sender, EventArgs e)
        {
            DialogResult = true;
            Close();
        }

        public void CancelClick(object sender, EventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
