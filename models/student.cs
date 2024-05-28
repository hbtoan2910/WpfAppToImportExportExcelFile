using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.models
{
    public class Student
    {
        public string fullname { get; set; }
        public string language { get; set; }
        public string location { get; set; }
        public string sex { get; set; }

        public string registerDate { get; set; }

        public Student(string fullname, string language, string location, string sex, string registerDate)
        {
            this.fullname = fullname;
            this.language = language;
            this.location = location;
            this.sex = sex;
            this.registerDate = registerDate;
        }
    }
}
