using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.People
{
    public class Teacher : Person
    {
        public string TeacherType { get; set; }
        public Teacher(string name, string lastname, int age, string teachertype) : base(name, lastname, age)
        {
            TeacherType = teachertype;
        }
    }
}
