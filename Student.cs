using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class Student : Person 
    {
        public int Id {  get; set; }
        
        public Student(int id, string name, string lastname, int age)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            Age = age;
        }

        public void Veiw()
        {
            Console.WriteLine($"ID {Id} Имя {Name} Фамилия {LastName} Возраст {Age}");
        }
    }
}
