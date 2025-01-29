

using System.Xml.Linq;
using School;
using School.People;

namespace SchoolProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Classroom newclass = new Classroom();

            Building building = new Building(2, 2, newclass);

            List<Student> studentList = new List<Student>()
            {
               new Student(5, "Tom", "Jefferson", 14),
               new Student(7, "Mat", "Pattison", 13),
               new Student(9, "Daimon", "Robertson", 14),
               new Student(3, "Jhon", "Smith", 15)
            };
            
            List <Teacher> teacherList = new List<Teacher>()
            {
                new Teacher("English", "Dana", "Simpson", 34),
                new Teacher("Math", "Alan", "Draizer", 40),
                new Teacher("Physical training", "Stan", "Richmond", 28),
                new Teacher("Physics", "Edgard", "White", 43)
            };

            List<Service_staff> serviceList = new List<Service_staff>()
            {
                new Service_staff("Clear", "Andrew", "Washing", 48),
                new Service_staff("Repairman", "Robert", "Kosinski", 45),
                new Service_staff("Security", "Mark", "Wotni", 37),
                new Service_staff("Security", "Dave", "Sunders", 38)
            };

            School school = new School(studentList, teacherList, serviceList, building);

            school.ViewwerBuilding();
            school.ViewwerTeachers();
            school.ViewwerStudents();
            school.ViewwerService();
            

            

            /*school1.View();
            school2.View();*/
        }
    }
}