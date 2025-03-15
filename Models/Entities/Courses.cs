namespace Models.Entities
{
    public class Courses
    {
        public int CourseId {  get; set; }
        public string Name { get; set; }


        public int Cridets { get; set; }



        public int TeacherID { get; set; }
        public virtual Teacher Teatcher { get; set; }

        public int ClassroomID { get; set; }


        public virtual Classrooms Classrooms { get; set; }


        public virtual ICollection<Attendances> Attendances { get; set; }
        public virtual ICollection<Enrollments> Enrollments { get; set; }


    }
}