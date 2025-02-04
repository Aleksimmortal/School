using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.People
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; } 
        public Person(string name, string lastname, int age)
        {
            Name = name;
            LastName = lastname;
            Age = age;
        }
    }
}
