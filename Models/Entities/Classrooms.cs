namespace Models.Entities
{
    public class Classrooms
    {
        public int ClassroomId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public string Location {  get; set; }

        public virtual ICollection<Courses> Courses { get; set; }

    }
}