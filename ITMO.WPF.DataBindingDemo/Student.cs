using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.WPF.DataBindingDemo
{

    public class StudentList : ObservableCollection<Student>
    {
        public StudentList() : base()
        {
            Add(new Student("Syed Abbas", false));
            Add(new Student("Lori Kane", true));
            Add(new Student("Steve Masters", false));
            Add(new Student("Tai Yee", true));
            Add(new Student("Brenda Diaz", true));
        }

    }
    public class Student
    {
        public string StudentName { get; set; }
        public bool IsEnrolled { get; set; }
        public Student(string StudentName, bool IsEnrolled)
        {
            this.StudentName = StudentName;
            this.IsEnrolled = IsEnrolled;
        }
    }
}
