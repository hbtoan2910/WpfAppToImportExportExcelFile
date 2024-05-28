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
    /// Interaction logic for SimpleDataTemplate_ListBox.xaml
    /// </summary>
    public partial class SimpleDataTemplate_ListBox : Window
    {
        public SimpleDataTemplate_ListBox()
        {
            InitializeComponent();

            List<Person> persons = new List<Person>();
            persons.Add(new Person() { Age = 10, Name = "Yin" });
            persons.Add(new Person() { Age = 11, Name = "Yang" });
            persons.Add(new Person() { Age = 12, Name = "Yo" });
            persons.Add(new Person() { Age = 10, Name = "Yin" });
            persons.Add(new Person() { Age = 11, Name = "Yang" });
            persons.Add(new Person() { Age = 12, Name = "Yo" });
            persons.Add(new Person() { Age = 10, Name = "Yin" });
            persons.Add(new Person() { Age = 11, Name = "Yang" });
            persons.Add(new Person() { Age = 12, Name = "Yo" });
            persons.Add(new Person() { Age = 10, Name = "Yin" });
            persons.Add(new Person() { Age = 11, Name = "Yang" });
            persons.Add(new Person() { Age = 12, Name = "Yo" });
            persons.Add(new Person() { Age = 10, Name = "Yin" });
            persons.Add(new Person() { Age = 11, Name = "Yang" });
            persons.Add(new Person() { Age = 12, Name = "Yo" });
            persons.Add(new Person() { Age = 10, Name = "Yin" });
            persons.Add(new Person() { Age = 11, Name = "Yang" });
            persons.Add(new Person() { Age = 12, Name = "Yo" });
            persons.Add(new Person() { Age = 10, Name = "Yin" });
            persons.Add(new Person() { Age = 11, Name = "Yang" });
            persons.Add(new Person() { Age = 12, Name = "Yo" });

            this.DataContext = persons;
        }
    }
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
