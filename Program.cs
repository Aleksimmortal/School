

namespace SchoolProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List <Student> studentList = new List<Student>();
            List <Teacher> teacherList = new List<Teacher>();

            School school1 = new School(studentList);
            School school2 = new School(teacherList);

            school1.View();
            school2.View();
        }
    }
}