using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School;
using School.People;

namespace SchoolProject
{
    public class School
    {
        public List<Student> Students;
        public List<Teacher> Teachers;
        public List<Service_staff> Service;
        public Building Builder;
       
        public School(List<Student> stud, List<Teacher> teach, List<Service_staff> service, Building build)
        {
            Students = stud;
            Teachers = teach;
            Service = service;
            Builder = build;
        }

        public void ViewwerBuilding()
        {
            Console.WriteLine();
            Console.WriteLine("=======Здание школы=======");
            Console.WriteLine($" {Builder.CountFloor}-х этажное здание, на каждом этаже {Builder.CountClassFloor} класса, номер 1-ой аудитории  ");
        }
        
        public void ViewwerStudents()
        {
            Console.WriteLine();
            Console.WriteLine("=======Список учеников=======");
            foreach (Student student in Students)
            {
                Console.WriteLine($"Номер класса {student.NumberClass} Имя {student.Name} Фамилия {student.LastName}  Возраст {student.Age}");
            }
            Console.WriteLine();
        }
        public void ViewwerTeachers()
        {
            Console.WriteLine();
            Console.WriteLine("=======Список учителей=======");
            foreach (Teacher teacher in Teachers)
            {
                Console.WriteLine($"Предмет {teacher.TeacherType} Имя {teacher.Name} Фамилия {teacher.LastName} Возраст {teacher.Age}");
            }
            Console.WriteLine();
        }
        public void ViewwerService()
        {
            Console.WriteLine();
            Console.WriteLine("=======Список обслуживающего персонала=======");
            foreach (Service_staff service in Service)
            {
                Console.WriteLine($"Должность {service.Type} Имя {service.Name} Фамилия {service.LastName} Возраст {service.Age}");
            }
            Console.WriteLine();
        }
    }
}
