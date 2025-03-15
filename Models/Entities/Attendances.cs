using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Attendances
    {
        public int AttendanceId { get; set; }
        public DateTime Date { get; set; }


        public bool IsPresent { get; set; }

        
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }


        public int CoursId { get; set; }
        public virtual Courses Courses { get; set; }



    }
}
