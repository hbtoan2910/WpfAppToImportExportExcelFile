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
using WpfApp1.models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnCheckInfo_onClick(object sender, RoutedEventArgs e)
        {
            String fullname = "", language = "", location = "", sex = "", registerDate = "";

            fullname = tbLname.Text + " " +  tbFname.Text;
            if (rdBtnNam.IsChecked == true )
            {
                sex = "Nam";
            }
            if (rdBtnNu.IsChecked == true)
            {
                sex = "Nữ";
            }
            if (cbEng.IsChecked == true )
            {
                language = lbEng.Content.ToString();
            }
            if (cbFre.IsChecked == true )
            {
                language = lbFre.Content.ToString();
            }
            if (cbChi.IsChecked == true ) {
                language = lbFre.Content.ToString();            
            }

            if (lbLocation.SelectedIndex >=0)
            {
                ListBoxItem lbItem = lbLocation.SelectedItem as ListBoxItem;
                location = lbItem.Content.ToString() ;
            }

            registerDate = dpRegisterDate.Text;
            lvStudent.Items.Add(new Student(fullname, language, location, sex, registerDate));

        }

        private void btnReEntry_Click(object sender, RoutedEventArgs e)
        {
            tbFname.Clear();
            tbLname.Clear();
            rdBtnNam.IsChecked = false;
            rdBtnNu.IsChecked = false;
            cbChi.IsChecked = false;
            cbEng.IsChecked = false;
            cbFre.IsChecked = false;
            lbLocation.SelectedItem = null;
            dpRegisterDate.SelectedDate = null;
        }
    }
}
