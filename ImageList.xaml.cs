using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace HandsOnLab1
{
    /// <summary>
    /// Interaction logic for ImageList.xaml
    /// </summary>

    public partial class ImageList : System.Windows.Controls.UserControl
    {
        private ObservableCollection<String> _images = new ObservableCollection<string>();

        public ImageList()
        {
            InitializeComponent();
            List<String> images = HandsOnLab1.ServiceAgents.ImageAgent.GetImages();
            foreach (string image in images)
            {
                Images.Add(image);
            }
            DataContext = this;
        }

        public ObservableCollection<String> Images
        {
            get { return _images; }
        }

        
    }
}