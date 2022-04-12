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
                progressBox.Value++;
            }
        }
        private void redCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (redCheckBox.IsChecked == false)
            {
                redBox.Visibility = Visibility.Hidden;
                progressBox.Value--;
            }
        }

        private void grayCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (grayCheckBox.IsChecked == true)
            {
                grayBox.Visibility = Visibility.Visible;
                progressBox.Value++;
            }
        }

        private void grayCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (grayCheckBox.IsChecked == false)
            {
                grayBox.Visibility = Visibility.Hidden;
                progressBox.Value--;
            }
        }

        private void blueCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (blueCheckBox.IsChecked == true)
            {
                blueBox.Visibility = Visibility.Visible;
                progressBox.Value++;
            }
        }

        private void blueCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (blueCheckBox.IsChecked == false)
            {
                blueBox.Visibility = Visibility.Hidden;
                progressBox.Value--;
            }
        }

        private void greenCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (greenCheckBox.IsChecked == true)
            {
                greenBox.Visibility = Visibility.Visible;
                progressBox.Value++;
            }
        }
        private void greenCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (greenCheckBox.IsChecked == false)
            {
                greenBox.Visibility = Visibility.Hidden;
                progressBox.Value--;
            }
        }

        private void yellowCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (yellowCheckBox.IsChecked == true)
            {
                yellowBox.Visibility = Visibility.Visible;
                progressBox.Value++;
            }
        }

        private void yellowCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (yellowCheckBox.IsChecked == false)
            {
                yellowBox.Visibility = Visibility.Hidden;
                progressBox.Value--;
            }
        }

        private void purpleCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (purpleCheckBox.IsChecked == true)
            {
                purpleBox.Visibility = Visibility.Visible;
                progressBox.Value++;
            }
        }
        private void purpleCheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            if (purpleCheckBox.IsChecked == false)
            {
                purpleBox.Visibility = Visibility.Hidden;
                progressBox.Value--;
            }
        }
    }
}
