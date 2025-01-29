using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.People
{
    public class Service_staff : Person
    {
        public string Type { get; set; }

        public Service_staff(string type, string name, string lastname, int age)
        {
            Type = type;
            Name = name;
            LastName = lastname;
            Age = age;
        }
    }
}
