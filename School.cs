using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class School
    {
        public List<Student> Students;
       
        public School()
        {
            List<Student> Students = new List<Student>(100);
            Student student1 = new Student(1, "Tom", "Jefferson", 14);
            Student student2 = new Student(2, "Mat", "Pattison", 13);
            Student student3 = new Student(3, "Daimon", "Robertson", 14);
            Student student4 = new Student(4, "Jhon", "Smith", 15);
            Students.Add(student1);
            Students.Add(student2);
            Students.Add(student3);
            Students.Add(student4);


            List<Teacher> Teachers = new List<Teacher>();
            Teacher teacher1 = new Teacher("English","Dana", "Simpson", 34);
            Teacher teacher2 = new Teacher("Math", "Alan", "Draizer", 40);
            Teacher teacher3 = new Teacher("Physical training", "Stan", "Richmond", 28);
            Teacher teacher4 = new Teacher("Physics", "Edgard", "White", 43);
            Teachers.Add(teacher1);
            Teachers.Add(teacher2);
            Teachers.Add(teacher3);
            Teachers.Add(teacher4);

        }

        public void ViewStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
