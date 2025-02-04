using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace School.People
{
    public class Service_staff : Person
    {
        public string Type { get; set; }

        public Service_staff(string name, string lastname, int age, string type) : base(name, lastname, age)
        {
            Type = type;
        }
    }
}
