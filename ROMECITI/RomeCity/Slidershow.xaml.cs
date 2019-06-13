using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Threading;

namespace WPFSlideShow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        int ctr = 0;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Tick += new EventHandler(timer_Tick);
        }
        void timer_Tick(object sender, EventArgs e)
        {
            ctr++;
            if (ctr > 21)
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
            string filename = ((ctr < 10) ? "Foto/rome0" + ctr + ".jpeg" : "Foto/rome" + ctr + ".jpeg");
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

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            ctr--;
            if (ctr < 1)
            {
                ctr = 21;
            }
            PlaySlideShow(ctr);
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            ctr++;
            if (ctr > 21)
            {
                ctr = 1;
            }
            PlaySlideShow(ctr);
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            ctr = 21;
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
    }
}