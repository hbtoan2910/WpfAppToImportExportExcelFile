using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for PreOrder.xaml
    /// </summary>
    public partial class PreOrder : Window
    {
        bool selected_nuocchanh;
        bool selected_nuoccam;
        bool selected_cafeden;
        bool selected_cafesua;
        bool selected_pho;
        bool selected_bunbohue;
        bool selected_comsuon;
        bool selected_trungchien;
        public PreOrder()
        {
            InitializeComponent();
            selected_nuocchanh = false;
            selected_nuoccam = false;
            selected_cafeden = false;
            selected_cafesua = false;
            selected_pho = false;
            selected_bunbohue = false;
            selected_comsuon = false;
            selected_trungchien = false;
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            string message = "Bạn đã chọn các món: ";
            string newValue = "";

            //bool selected = false;            
            //ListBox listBox = listBoxList1;
            //foreach (var item in listBox.Items)
            //{
            //    StackPanel sp = ((ListBoxItem)item).Content as StackPanel; 

            //    foreach (var insideItem in sp.Children)
            //    {
            //        if (insideItem is CheckBox)
            //        {
            //            ((CheckBox)insideItem).IsChecked = true;
            //        }
            //    } 
            //}

            //if (selected_nuoccam)
            //{
            //    message += "Nước cam; ";
            //    selected = true;
            //}
            //if (selected_nuocchanh)
            //{
            //    message += "Nước chanh; ";
            //    selected = true;
            //}
            //if (selected_cafeden)
            //{
            //    message += "Cafe đen đá; ";
            //    selected = true;
            //}
            //if (selected_cafesua)
            //{
            //    message += "Cafe sữa đá; ";
            //    selected = true;
            //}
            //if (selected_pho)
            //{
            //    message += "Phở; ";
            //    selected = true;
            //}
            //if (selected_bunbohue)
            //{
            //    message += "Bún bò huế; ";
            //    selected = true;
            //}
            //if (selected_comsuon)
            //{
            //    message += "Cơm sườn; ";
            //    selected = true;
            //}
            //if (selected_trungchien)
            //{
            //    message += "Trứng chiên; ";
            //    selected = true;
            //}
            //if (!selected) {
            //    MessageBox.Show("You have not selected anything.");
            //}
            //else MessageBox.Show(message);
            List<string> selectedItems = new List<string>();
            string value="";
            if (cb1.IsChecked == true) { selectedItems.Add(tbl1.Text); };
            if (cb2.IsChecked == true) { selectedItems.Add(tbl2.Text); };
            if (cb3.IsChecked == true) { selectedItems.Add(tbl3.Text); };
            if (cb4.IsChecked == true) { selectedItems.Add(tbl4.Text); };
            for(int i = 0; i < selectedItems.Count; i++)
            {
                value += selectedItems[i] + "; ";
            }
            if (value.Length > 0)
            {
                newValue = value.Substring(0, value.Length - 2) ; 
            }
            MessageBox.Show(message + newValue);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result =  MessageBox.Show("Are you sure you want to exit ?", "Exit Confirmation", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
        private void handleCheck(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(cb1)) selected_nuoccam = true;
            if (sender.Equals(cb2)) selected_nuocchanh = true;
            if (sender.Equals(cb3)) selected_cafeden = true;
            if (sender.Equals(cb4)) selected_cafesua = true;
            if (sender.Equals(cb5)) selected_pho = true;
            if (sender.Equals(cb6)) selected_bunbohue = true;
            if (sender.Equals(cb7)) selected_comsuon = true;
            if (sender.Equals(cb8)) selected_trungchien = true;
        }
        private void handleUncheck(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(cb1)) selected_nuoccam = false;
            if (sender.Equals(cb2)) selected_nuocchanh = false;
            if (sender.Equals(cb3)) selected_cafeden = false;
            if (sender.Equals(cb4)) selected_cafesua = false;
            if (sender.Equals(cb5)) selected_pho = false;
            if (sender.Equals(cb6)) selected_bunbohue = false;
            if (sender.Equals(cb7)) selected_comsuon = false;
            if (sender.Equals(cb8)) selected_trungchien = false;
        }
    }
}
