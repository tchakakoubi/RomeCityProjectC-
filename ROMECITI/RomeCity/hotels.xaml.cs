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

namespace RomeCity
{
    /// <summary>
    /// Interaktionslogik für hotels.xaml
    /// </summary>
    public partial class hotels : Page
    {
        public hotels()
        {
            InitializeComponent();
        }


        private void foto2_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void foto3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void foto4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void foto5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void foto6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void foto7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void foto8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void foto9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void foto10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Read_More_Click(object sender, RoutedEventArgs e)
        {
            //ReadMehr mehr = new ReadMehr();
            //miFrame.NavigationService.Navigate(mehr);

            //this.Content = mehr;
            
           Grid bla1 = bild1;
            hotelos.Children.Clear();
            hotelos.ColumnDefinitions.Clear();

            miFrame.Content = new ReadMehr();

            bild1.Width = this.Width -50;
            bild1.HorizontalAlignment = HorizontalAlignment.Center;
            hotelos.Children.Add(bild1);
        }
    }
}
