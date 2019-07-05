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
using System.Data.SQLite;


namespace RomeCity
{
    /// <summary>
    /// Interaktionslogik für Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        string dbConnectionString = @"Data Source=database.db;Version=3;";

        public Login()
        {
            InitializeComponent();
        }
        private void sing_In_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteConnection = new SQLiteConnection(dbConnectionString);

            //Open Connection  to Database
            try
            {
                sqliteConnection.Open();

                string Query = "select * from user where username ='" + this.user.Text + "'and password='" + pass.Password.ToString() + "' ";

                SQLiteCommand createCommand = new SQLiteCommand(Query, sqliteConnection);

                createCommand.ExecuteNonQuery();

                SQLiteDataReader dataReader = createCommand.ExecuteReader();

                int count = 0;

                while (dataReader.Read())
                {
                    count++;
                }

                if (count == 1)
                {

                    MessageBox.Show("Username and password richtig");
                }

                if (count < 1)
                {
                    MessageBox.Show("username and password are wrong please try again");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void zurueck_Click(object sender, RoutedEventArgs e)
        {
            miFrame_zurueck.Content = new ReadMehr();
        }
    }
}
