

using System.Xml.Linq;
using School;
using School.People;

namespace SchoolProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List <Classroom> newclass = new List<Classroom>()
            {
                new Classroom("101C"),
                new Classroom("107A"),
                new Classroom("205T"),
                new Classroom("210D")
            };
                    
            Building building = new Building(2, 2, newclass);


            List<Student> studentList = new List<Student>()
            {
               new Student("Tom", "Jefferson", 14, 5),
               new Student("Mat", "Pattison", 13, 7),
               new Student("Daimon", "Robertson", 14, 9),
               new Student("Jhon", "Smith", 15, 3)
            };
            
            List <Teacher> teacherList = new List<Teacher>()
            {
                new Teacher("Dana", "Simpson", 34, "English"),
                new Teacher("Alan", "Draizer", 40, "Math"),
                new Teacher("Stan", "Richmond", 28, "Physical training"),
                new Teacher("Edgard", "White", 43, "Physics")
            };

            List<Service_staff> serviceList = new List<Service_staff>()
            {
                new Service_staff("Andrew", "Washing", 48, "Clear"),
                new Service_staff("Robert", "Kosinski", 45, "Repairman"),
                new Service_staff("Mark", "Wotni", 37, "Security"),
                new Service_staff("Dave", "Sunders", 38, "Security")
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