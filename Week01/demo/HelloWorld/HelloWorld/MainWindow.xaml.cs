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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnChangeImage_Click(object sender, RoutedEventArgs e)
        {
            string[] names = { "01", "02", "03", "04", "05", "06" };
            Random rng = new Random();
            int i = rng.Next() % names.Length;
            string name = names[i];

            var bitmap = new BitmapImage(
                new Uri($"/Images/avatar{name}.jpg", UriKind.Relative));
            imgAvatar.Source = bitmap;

            
        }
    }
}
