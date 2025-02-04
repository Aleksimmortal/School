using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Building
    {
        public int CountFloor {  get; set; }
        public int CountClassFloor { get; set; }
        
        public List <Classroom> Classrooms { get; set; }
        public Building(int floor, int countclassfloor, List<Classroom> classroom)
        {
            CountFloor = floor;
            CountClassFloor = countclassfloor;
            Classrooms = classroom;
        }
    }
}
