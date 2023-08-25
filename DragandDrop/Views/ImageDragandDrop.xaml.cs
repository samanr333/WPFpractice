using System.Windows;
using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Validation.Views
{
    public partial class ImageDragandDrop : Page
    {
        public ImageDragandDrop()
        {
            InitializeComponent();
        }
        private void ImageDropNow(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files.Length > 0)
                {
                    string imagePath = files[0];
                    DisplayImage(imagePath);
                }
            }
        }
        private void DisplayImage(string imagePath)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath);
            bitmap.EndInit();
            ShowImage.Source = bitmap;
        }
    }
}
