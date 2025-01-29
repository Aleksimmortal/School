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
        
        Classroom Classroom { get; set; }
        public Building(int floor, int countclassfloor, Classroom classroom)
        {
            CountFloor = floor;
            CountClassFloor = countclassfloor;
            Classroom = classroom;
        }
    }
}
