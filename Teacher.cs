using SchoolProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class Teacher : Person
    {
        public string TeacherType { get; set; }
        public Teacher(string teachertype, string name, string lastname, int age)
        {
            TeacherType = teachertype;
            Name = name;
            LastName = lastname;
            Age = age;
        }    
    }
}
