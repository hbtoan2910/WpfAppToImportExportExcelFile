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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for DogLeafForward.xaml
    /// </summary>
    public partial class DogLeafForward : Window
    {
        public DogLeafForward()
        {
            InitializeComponent();
        }

        private void btnDog_Click(object sender, RoutedEventArgs e)
        {
            W_FeedDog dog = new W_FeedDog();
            dog.Show();
        }

        private void btnLeaf_Click(object sender, RoutedEventArgs e)
        {
            W_CollecLeaf leaf = new W_CollecLeaf();
            leaf.Show();
        }
    }
}