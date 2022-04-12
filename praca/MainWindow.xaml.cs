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

namespace praca
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

        private void redCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (redCheckBox.IsChecked == true){
                redBox.Visibility = Visibility.Visible;
            }
        }
        private void redCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (redCheckBox.IsChecked == false)
            {
                redBox.Visibility = Visibility.Hidden;
            }
        }

        private void grayCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (grayCheckBox.IsChecked == true)
            {
                grayBox.Visibility = Visibility.Visible;
            }
        }

        private void grayCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (grayCheckBox.IsChecked == false)
            {
                grayBox.Visibility = Visibility.Hidden;
            }
        }
    }
}
