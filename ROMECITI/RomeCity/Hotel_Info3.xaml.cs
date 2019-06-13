﻿using System;
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
    /// Interaktionslogik für Hotel_Info3.xaml
    /// </summary>
    public partial class Hotel_Info3 : Page
    {
        public Hotel_Info3()
        {
            InitializeComponent();
            bildgross.Source = new BitmapImage(new Uri("Bilder1/city3.jpg", UriKind.Relative));
            bildgross.Width = this.Width;
        }
        private void buchen_click(object sender, RoutedEventArgs e)
        {
            miFrame_buchen.Content = new Login();
        }

        private void zurück_click(object sender, RoutedEventArgs e)
        {
            miFrame_buchen.Content = new hotels();
        }
    }
}
