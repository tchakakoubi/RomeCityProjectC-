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
    /// Interaktionslogik für Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }
        private void sing_In_Click(object sender, RoutedEventArgs e)
        {
            if (pass.Password != "" && user.Text != "")
            {
                if (pass.Password == "test" && user.Text == "user")
                {
                    MessageBox.Show("Success", "Valid");
                }
                else
                {
                    MessageBox.Show("Not Valid");
                }
            }
        }
    }
}
