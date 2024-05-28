using System;
using System.Data;
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
using Microsoft.Win32;
using OfficeOpenXml;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.DirectoryServices.ActiveDirectory;
using System.Net.Mail;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for CustomerDisplay.xaml
    /// </summary>
    public partial class CustomerDisplay : Window
    {
        DataTable dt;
        public CustomerDisplay()
        {
            InitializeComponent();

            Customer customer = new Customer();
            dt = customer.getCustomerData();

            this.DataContext = dt;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            customer.addCustomer("Ryan", "Huynh", "InformedicSys", "ryan@infomedicsystem.com", "647 523 3477");
        }

        private void btnImport_Click(object sender, RoutedEventArgs e)
        {
            string filePath = "";

            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            if (openFileDialog.ShowDialog() == true)
            {
                filePath = openFileDialog.FileName;
            }
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("File path could not be found.");
                return;
            }
            //List<Customer> customerList = new List<Customer>();
            dt = new DataTable();
            dt.Columns.Add("CustomerID");
            dt.Columns.Add("FirstName");       
            dt.Columns.Add("LastName");
            dt.Columns.Add("CompanyName");
            dt.Columns.Add("EmailAddress");
            dt.Columns.Add("Phone");
            try
            {
                var package = new ExcelPackage(new FileInfo(filePath));
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelWorksheet workSheet = package.Workbook.Worksheets[0];
                for (int i = workSheet.Dimension.Start.Row + 2; i <= workSheet.Dimension.End.Row; i++)
                {
                    int j = 1; // this is variable for column
                    var customerId = workSheet.Cells[i, j++].Value.ToString();
                    var firstName = workSheet.Cells[i, j++].Value.ToString();
                    var lastName = workSheet.Cells[i, j++].Value.ToString();
                    var company = workSheet.Cells[i, j++].Value.ToString();
                    var email = workSheet.Cells[i, j++].Value.ToString();
                    var phone = workSheet.Cells[i, j++].Value.ToString();

                    dt.Rows.Add(customerId, firstName, lastName, company, email, phone);
                    this.DataContext = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string filePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                filePath = saveFileDialog.FileName;
            }
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("File path could not be found.");
                return;
            }
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            try
            {
                using (ExcelPackage package = new ExcelPackage())
                {
                    package.Workbook.Properties.Author = "RYAN HUYNH";
                    package.Workbook.Properties.Title = "BAO CAO VE DS KHACH HANG";
                    package.Workbook.Worksheets.Add("demo sheet");
                    ExcelWorksheet ws = package.Workbook.Worksheets[0];
                    ws.Name = "MY_SHEET";
                    ws.Cells.Style.Font.Size = 11;
                    ws.Cells.Style.Font.Name = "Times New Roman";
                    string[] columnHeaders = { "First name", "Last name", "Company", "Email", "Phone" };
                    int noOfColumns = columnHeaders.Count();
                    ws.Cells[1, 1].Value = "DANH SÁCH KHÁCH HÀNG 2024"; //row 1 is title
                    ws.Cells[1, 1, 1, noOfColumns].Merge = true; //merge all cells in a row
                    int colIndex = 1;
                    int rowIndex = 2;
                    //Tạo các column headers
                    foreach (string columnHeader in columnHeaders) //row 2 is header
                    {
                        var cell = ws.Cells[rowIndex, colIndex];
                        var fill = cell.Style.Fill;
                        fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                        var border = cell.Style.Border;
                        border.Bottom.Style = border.Top.Style = border.Left.Style = border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;
                        cell.Value = columnHeader;
                        colIndex++;
                    }
                    //Initialize data
                    foreach ( DataRow dr in dt.Rows)
                    {
                        colIndex = 1;
                        rowIndex++;
                        //row 3 start initializing data
                        //CustomerID, FirstName, LastName, CompanyName, EmailAddress, Phone must be same with SQL's column name for correct binding                       
                        ws.Cells[rowIndex, colIndex++].Value = dr["FirstName"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["LastName"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["CompanyName"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["EmailAddress"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["Phone"].ToString();
                    }
                    //Save into file
                    byte[] bin = package.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Done saving file.");
            }
            catch (Exception ex)
            {   
                MessageBox.Show("Error while creating file: " + ex.Message);
            }
        }
    }
}
