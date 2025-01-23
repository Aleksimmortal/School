using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class School <T>
    {
        public List <T> SchoolPersons;
        public List Teachers;
       
        public School(List<Student> stud)
        {
            SchoolPersons = new List <Student>();
            Student student1 = new Student(1, "Tom", "Jefferson", 14);
            Student student2 = new Student(2, "Mat", "Pattison", 13);
            Student student3 = new Student(3, "Daimon", "Robertson", 14);
            Student student4 = new Student(4, "Jhon", "Smith", 15);
            SchoolPersons.Add(student1);
            SchoolPersons.Add(student2);
            SchoolPersons.Add(student3);
            SchoolPersons.Add(student4);     
        }

        public School(List<Teacher> teach)
        {
            SchoolPersons = new List<Teacher<T>>();
            Teacher<T> teacher1 = new Teacher<T>("English", "Dana", "Simpson", 34);
            Teacher<T> teacher2 = new Teacher<T>("Math", "Alan", "Draizer", 40);
            Teacher<T> teacher3 = new Teacher<T>("Physical training", "Stan", "Richmond", 28);
            Teacher<T> teacher4 = new Teacher<T>("Physics", "Edgard", "White", 43);
            Teachers.Add(teacher1);
            Teachers.Add(teacher2);
            Teachers.Add(teacher3);
            Teachers.Add(teacher4);
        }

        public void Viewwer()
        {
            for (int i = 0; i < SchoolPersons.Count; i++)
            {
                SchoolPersons[i].Veiw();
                Console.WriteLine();
            }
        }
    }
}
