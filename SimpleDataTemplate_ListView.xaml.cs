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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for SimpleDataTemplate_ListView.xaml
    /// </summary>
    public partial class SimpleDataTemplate_ListView : Window
    {
        public SimpleDataTemplate_ListView()
        {
            InitializeComponent();

            List<AnotherPerson> persons = new List<AnotherPerson>();
            persons.Add(new AnotherPerson() { AAge = 10, AName = "Toan" });
            persons.Add(new AnotherPerson() { AAge = 11, AName = "Kent" });
            persons.Add(new AnotherPerson() { AAge = 12, AName = "Trish" });
            persons.Add(new AnotherPerson() { AAge = 10, AName = "Toan" });
            persons.Add(new AnotherPerson() { AAge = 11, AName = "Kent" });
            persons.Add(new AnotherPerson() { AAge = 12, AName = "Trish" });
            persons.Add(new AnotherPerson() { AAge = 10, AName = "Toan" });
            persons.Add(new AnotherPerson() { AAge = 11, AName = "Kent" });
            persons.Add(new AnotherPerson() { AAge = 12, AName = "Trish" });
            persons.Add(new AnotherPerson() { AAge = 10, AName = "Toan" });
            persons.Add(new AnotherPerson() { AAge = 11, AName = "Kent" });
            persons.Add(new AnotherPerson() { AAge = 12, AName = "Trish" });
            persons.Add(new AnotherPerson() { AAge = 10, AName = "Toan" });
            persons.Add(new AnotherPerson() { AAge = 11, AName = "Kent" });
            persons.Add(new AnotherPerson() { AAge = 12, AName = "Trish" });
            persons.Add(new AnotherPerson() { AAge = 10, AName = "Toan" });
            persons.Add(new AnotherPerson() { AAge = 11, AName = "Kent" });
            persons.Add(new AnotherPerson() { AAge = 12, AName = "Trish" });

            this.DataContext = persons;
        }
    }
    public class AnotherPerson
    {
        public int AAge { get; set; }
        public string AName { get; set; }
    }
}
