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
using System.Windows.Shapes;
using WpfApp1.database;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        DbConnection conn = new DbConnection();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //if ((conn.loggedInResponse(tbName.Text, pbPassword.Password)).Rows.Count > 0)
            //{
            //    MessageBox.Show("User: " + tbName.Text.ToUpper() + " logged in successfully.");
            //    DogLeafForward main = new DogLeafForward();
            //    main.Show();

            //}
            //else
            //{
            //    MessageBox.Show("Please check your input data.");
            //}

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
