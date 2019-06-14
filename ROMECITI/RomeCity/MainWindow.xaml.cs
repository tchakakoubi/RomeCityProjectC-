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
using Microsoft.Maps.MapControl.WPF;
using System.Windows.Threading;

namespace RomeCity
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        //Inserer le Apikey pour le map
        public ApplicationIdCredentialsProvider Provider { get; set; } = new ApplicationIdCredentialsProvider("9J0Zv03MwOiYXQrfrEPO~BDnBUXv8_caoV5dsXIA3Lw~AgIl2pu-05XtU1x5ReR3-eU2yNnywn8mK3I797gljELvI7zfHxah7IR4t5QcAUwA");


        DispatcherTimer timer;
        int ctr = 0;
        public MainWindow()
        {
            //Pour activer le map
            this.DataContext = this;
            InitializeComponent();
            myMap.Focus();
            myMap.CredentialsProvider = Provider;
            //définir le zoom de la carte a 10;
            myMap.Mode = new AerialMode(true);


            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            this.MinHeight = SystemParameters.MinimizedGridHeight;

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Tick += new EventHandler(timer_Tick);
            

        }
        void timer_Tick(object sender, EventArgs e)
        {
            ctr++;
            if (ctr > 10)
            {
                ctr = 1;
            }
            PlaySlideShow(ctr);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ctr = 1;
            PlaySlideShow(ctr);
        }
        private void PlaySlideShow(int ctr)
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            string filename = ((ctr < 0) ? "Foto/rome0" + ctr + ".jpg" : "Foto/rome" + ctr + ".jpg");
            image.UriSource = new Uri(filename, UriKind.Relative);
            image.EndInit();
            myImage.Source = image;
            myImage.Stretch = Stretch.Uniform;
            progressBar1.Value = ctr;
        }
        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            ctr = 1;
            PlaySlideShow(ctr);
        }
        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            ctr = 10;
            PlaySlideShow(ctr);
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            ctr--;
            if (ctr < 1)
            {
                ctr = 10;
            }
            PlaySlideShow(ctr);
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            ctr++;
            if (ctr > 10)
            {
                ctr = 1;
            }
            PlaySlideShow(ctr);
        }
        private void chkAutoPlay_Click(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = chkAutoPlay.IsChecked.Value;
            btnFirst.Visibility = (btnFirst.IsVisible == true) ? Visibility.Hidden : Visibility.Visible;
            btnPrevious.Visibility = (btnPrevious.IsVisible == true) ? Visibility.Hidden : Visibility.Visible;
            btnNext.Visibility = (btnNext.IsVisible == true) ? Visibility.Hidden : Visibility.Visible;
            btnLast.Visibility = (btnLast.IsVisible == true) ? Visibility.Hidden : Visibility.Visible;
        }


        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonOfOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOfOpenMenu.Visibility = Visibility.Collapsed;
            ButtonOfCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonOfCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOfOpenMenu.Visibility = Visibility.Visible;
            ButtonOfCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void GridBarratitulo_MouseDown(object sender, RoutedEventArgs e)
        {
            DragMove();
        }

        private void ButtonFechar_Click1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonMax_Click2(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else if(this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
           
        }

        private void ButtonMin_Click3(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Minimized;
            }
            else if (this.WindowState == WindowState.Minimized)
            {
                this.WindowState = WindowState.Normal;
            }
        }

       

        private void ListViewItem_Hotel(object sender, RoutedEventArgs e)
        {
            //Main.Content = new hotels();

            hotels h1 = new hotels();
            //this.Content = h1;

            Main.NavigationService.Navigate(h1);


            home.Visibility = Visibility.Hidden;

            zimmer.Visibility = Visibility.Visible;
            places.Visibility = Visibility.Hidden;
        }

        private void ListViewItem_Home(object sender, RoutedEventArgs e)
        {
            hotels h2 = new hotels();

            Main.NavigationService.Navigate(h2);
            home.Visibility = Visibility.Visible;

            h2.Visibility = Visibility.Hidden;
            

            zimmer.Visibility = Visibility.Hidden;
            places.Visibility = Visibility.Hidden;

        

        }

        private void register_click(object sender, RoutedEventArgs e)
        {

        }

        private void logout_click(object sender, RoutedEventArgs e)
        {

        }

        private void login_click(object sender, RoutedEventArgs e)
        {

        }

        private void aboutUs_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("We are Team Franck && Lea");
        }

        private void suchButton(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeMapView_Click1(object sender, RoutedEventArgs e)
        {
            Location myLoc = new Location(41.835590, 12.554630);
            myMap.SetView(myLoc, Convert.ToDouble(14), Convert.ToDouble(0));
            Pushpin mypin = new Pushpin();
            MapLayer.SetPosition(mypin, myLoc);
            myMap.Children.Add(mypin);

            System.Windows.Controls.Label label = new System.Windows.Controls.Label();
            label.Content = "Via Siderno, 37, 00178 Roma RM, Italia";
            label.Foreground = new SolidColorBrush(Colors.White);
            label.Background = new SolidColorBrush(Colors.DarkOliveGreen);
            label.FontFamily = new FontFamily("Berlin Sans FB");
            label.FontSize = 13;
            MapLayer.SetPosition(label, myLoc);
            myMap.Children.Add(label);
        }

        private void ChangeMapView_Click2(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeMapView_Click3(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeMapView_Click4(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeMapView_Click10(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewItem_Mapper(object sender, RoutedEventArgs e)
        {
            hotels h2 = new hotels();

            Main.NavigationService.Navigate(h2);
            home.Visibility = Visibility.Hidden;

            h2.Visibility = Visibility.Hidden;


            zimmer.Visibility = Visibility.Hidden;
            places.Visibility = Visibility.Visible;

        }
    }
}
