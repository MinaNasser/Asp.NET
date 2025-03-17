using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }


        public virtual ICollection<Attendances> Attendances { get; set; }
        public virtual ICollection<Enrollments> Enrollments { get; set; }


    }
}
