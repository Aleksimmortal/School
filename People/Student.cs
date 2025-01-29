using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.People
{
    public class Student : Person
    {
        public int NumberClass { get; set; }

        public Student(int numberclass, string name, string lastname, int age)
        {
            NumberClass = numberclass;
            Name = name;
            LastName = lastname;
            Age = age;
        }
    }
}
