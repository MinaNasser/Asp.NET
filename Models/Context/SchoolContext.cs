

using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Models.Context
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students {  get; set; }
        public DbSet<Teacher> Teatchers { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Attendances> Attendances { get; set; }
        public DbSet<Enrollments> Enrollments { get; set; }
        public DbSet<Classrooms> classrooms { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
                  .UseSqlServer("Data source = .; Initial catalog = DB_SchoolASP; Integrated security= true; trustservercertificate = true;").UseLazyLoadingProxies();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Student table
            modelBuilder.Entity<Student>().HasKey(S => S.StudentId);
            modelBuilder.Entity<Student>().Property(S => S.Name).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<Student>().Property(S => S.Email).HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<Student>().Property(S => S.Phone).HasColumnType("nvarchar(20)").IsRequired();

            // Cours Table
            modelBuilder.Entity<Courses>().HasKey(C => C.CourseId);
            modelBuilder.Entity<Courses>().Property(C => C.Name).HasColumnType("nvarchar(50)").IsRequired();


            // Teacher Table
            modelBuilder.Entity<Teacher>().HasKey(T => T.TeacherId);
            modelBuilder.Entity<Teacher>().Property(T => T.Subject)
                .HasColumnType("nvarchar(100)").IsRequired(false);
            modelBuilder.Entity<Teacher>().Property(t => t.Email).HasColumnType("nvarchar(50)").IsRequired();

            //Enrollment 

            modelBuilder.Entity<Enrollments>()
                .HasKey(e => new { e.StudentId, e.CoursId });
            modelBuilder.Entity<Enrollments>()
                .Property(e => e.Grade).IsRequired(true);

            //Attendenc 

            modelBuilder.Entity<Attendances>()
                .HasKey(a => a.AttendanceId);


            //ClassRoom 
            modelBuilder.Entity<Classrooms>()
                .HasKey(cl =>cl.ClassroomId);
            modelBuilder.Entity<Classrooms>()
                .Property(C => C.Name)
                .HasColumnType("nvarchar(50)").IsRequired();
            modelBuilder.Entity<Classrooms>()
                .Property(e => e.Capacity).IsRequired(true);

            // Realashion
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Courses)
                .WithOne(c => c.Teatcher)
                .HasForeignKey(c => c.TeacherID);

            modelBuilder.Entity<Classrooms>()
                .HasMany(c => c.Courses)
                .WithOne(cl => cl.Classrooms)
                .HasForeignKey(cl => cl.ClassroomID);


            modelBuilder.Entity<Courses>()
                .HasMany(c => c.Attendances)
                .WithOne(a=> a.Courses)
                .HasForeignKey(a=>a.CoursId);

            modelBuilder.Entity<Courses>()
                .HasMany(c => c.Enrollments)
                .WithOne(e => e.Courses)
                .HasForeignKey(e=>e.CoursId);


            modelBuilder.Entity<Student>()
               .HasMany(S => S.Attendances)
               .WithOne(a  =>a.Student)
               .HasForeignKey(a =>a.StudentId);

            modelBuilder.Entity<Student>()
                .HasMany(S => S.Enrollments)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.StudentId);
            // Seed Classrooms
            modelBuilder.Entity<Classrooms>().HasData(
                new Classrooms { ClassroomId = 1, Name = "A101", Capacity = 30, Location = "Building 1" },
                new Classrooms { ClassroomId = 2, Name = "B202", Capacity = 25, Location = "Building 2" },
                new Classrooms { ClassroomId = 3, Name = "C303", Capacity = 20, Location = "Building 3" },
                new Classrooms { ClassroomId = 4, Name = "D404", Capacity = 35, Location = "Building 4" },
                new Classrooms { ClassroomId = 5, Name = "E505", Capacity = 40, Location = "Building 5" },
                new Classrooms { ClassroomId = 6, Name = "F606", Capacity = 28, Location = "Building 6" },
                new Classrooms { ClassroomId = 7, Name = "G707", Capacity = 32, Location = "Building 7" },
                new Classrooms { ClassroomId = 8, Name = "H808", Capacity = 27, Location = "Building 8" },
                new Classrooms { ClassroomId = 9, Name = "I909", Capacity = 22, Location = "Building 9" },
                new Classrooms { ClassroomId = 10, Name = "J1010", Capacity = 30, Location = "Building 10" }
            );

            // Seed Teachers
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { TeacherId = 1, Name = "John Smith", Subject = "Math", Email = "john@school.com", phone = "123456789" },
                new Teacher { TeacherId = 2, Name = "Sarah Johnson", Subject = "Physics", Email = "sarah@school.com", phone = "987654321" },
                new Teacher { TeacherId = 3, Name = "Michael Brown", Subject = "Chemistry", Email = "michael@school.com", phone = "555123456" },
                new Teacher { TeacherId = 4, Name = "Emily Davis", Subject = "Biology", Email = "emily@school.com", phone = "666987654" },
                new Teacher { TeacherId = 5, Name = "Robert Wilson", Subject = "History", Email = "robert@school.com", phone = "777654321" },
                new Teacher { TeacherId = 6, Name = "Jessica Taylor", Subject = "English", Email = "jessica@school.com", phone = "888123987" },
                new Teacher { TeacherId = 7, Name = "David White", Subject = "Geography", Email = "david@school.com", phone = "999654789" },
                new Teacher { TeacherId = 8, Name = "Linda Martin", Subject = "Art", Email = "linda@school.com", phone = "111222333" },
                new Teacher { TeacherId = 9, Name = "James Clark", Subject = "Music", Email = "james@school.com", phone = "444555666" },
                new Teacher { TeacherId = 10, Name = "Mary Lewis", Subject = "Computer Science", Email = "mary@school.com", phone = "777888999" }
            );
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, Name = "Alice Johnson", DateOfBirth = new DateTime(2005, 5, 20), Email = "alice@school.com", Phone = "123456789" },
                new Student { StudentId = 2, Name = "Bob Williams", DateOfBirth = new DateTime(2004, 8, 15), Email = "bob@school.com", Phone = "987654321" },
                new Student { StudentId = 3, Name = "Charlie Brown", DateOfBirth = new DateTime(2006, 2, 10), Email = "charlie@school.com", Phone = "555123456" },
                new Student { StudentId = 4, Name = "David Smith", DateOfBirth = new DateTime(2005, 11, 25), Email = "david@school.com", Phone = "666987654" },
                new Student { StudentId = 5, Name = "Eve Miller", DateOfBirth = new DateTime(2003, 9, 5), Email = "eve@school.com", Phone = "777654321" },
                new Student { StudentId = 6, Name = "Frank White", DateOfBirth = new DateTime(2004, 7, 18), Email = "frank@school.com", Phone = "888123987" },
                new Student { StudentId = 7, Name = "Grace Hall", DateOfBirth = new DateTime(2005, 4, 3), Email = "grace@school.com", Phone = "999654789" },
                new Student { StudentId = 8, Name = "Hank Adams", DateOfBirth = new DateTime(2006, 1, 29), Email = "hank@school.com", Phone = "111222333" },
                new Student { StudentId = 9, Name = "Ivy Parker", DateOfBirth = new DateTime(2003, 6, 12), Email = "ivy@school.com", Phone = "444555666" },
                new Student { StudentId = 10, Name = "Jack Carter", DateOfBirth = new DateTime(2004, 12, 8), Email = "jack@school.com", Phone = "777888999" }
            );

            modelBuilder.Entity<Courses>().HasData(
                new Courses { CourseId = 1, Name = "Mathematics", Cridets = 3, TeacherID = 1, ClassroomID = 1 },
                new Courses { CourseId = 2, Name = "Physics", Cridets = 4, TeacherID = 2, ClassroomID = 2 },
                new Courses { CourseId = 3, Name = "Chemistry", Cridets = 3, TeacherID = 3, ClassroomID = 3 },
                new Courses { CourseId = 4, Name = "Biology", Cridets = 3, TeacherID = 4, ClassroomID = 4 },
                new Courses { CourseId = 5, Name = "History", Cridets = 2, TeacherID = 5, ClassroomID = 5 },
                new Courses { CourseId = 6, Name = "English", Cridets = 3, TeacherID = 6, ClassroomID = 6 },
                new Courses { CourseId = 7, Name = "Geography", Cridets = 2, TeacherID = 7, ClassroomID = 7 },
                new Courses { CourseId = 8, Name = "Art", Cridets = 2, TeacherID = 8, ClassroomID = 8 },
                new Courses { CourseId = 9, Name = "Music", Cridets = 2, TeacherID = 9, ClassroomID = 9 },
                new Courses { CourseId = 10, Name = "Computer Science", Cridets = 4, TeacherID = 10, ClassroomID = 10 }
            );
            modelBuilder.Entity<Attendances>().HasData(
                new Attendances { AttendanceId = 1, Date = new DateTime(2024, 3, 1), IsPresent = true, StudentId = 1, CoursId = 1 },
                new Attendances { AttendanceId = 2, Date = new DateTime(2024, 3, 2), IsPresent = false, StudentId = 2, CoursId = 2 },
                new Attendances { AttendanceId = 3, Date = new DateTime(2024, 3, 3), IsPresent = true, StudentId = 3, CoursId = 3 },
                new Attendances { AttendanceId = 4, Date = new DateTime(2024, 3, 4), IsPresent = true, StudentId = 4, CoursId = 4 },
                new Attendances { AttendanceId = 5, Date = new DateTime(2024, 3, 5), IsPresent = false, StudentId = 5, CoursId = 5 },
                new Attendances { AttendanceId = 6, Date = new DateTime(2024, 3, 6), IsPresent = true, StudentId = 6, CoursId = 6 },
                new Attendances { AttendanceId = 7, Date = new DateTime(2024, 3, 7), IsPresent = true, StudentId = 7, CoursId = 7 },
                new Attendances { AttendanceId = 8, Date = new DateTime(2024, 3, 8), IsPresent = false, StudentId = 8, CoursId = 8 },
                new Attendances { AttendanceId = 9, Date = new DateTime(2024, 3, 9), IsPresent = true, StudentId = 9, CoursId = 9 },
                new Attendances { AttendanceId = 10, Date = new DateTime(2024, 3, 10), IsPresent = false, StudentId = 10, CoursId = 10 }
            );
            modelBuilder.Entity<Enrollments>().HasData(
                new Enrollments { StudentId = 1, CoursId = 1, Grade = 85.5m },
                new Enrollments { StudentId = 2, CoursId = 2, Grade = 78.0m },
                new Enrollments { StudentId = 3, CoursId = 3, Grade = 92.3m },
                new Enrollments { StudentId = 4, CoursId = 4, Grade = 67.8m },
                new Enrollments { StudentId = 5, CoursId = 5, Grade = 88.6m },
                new Enrollments { StudentId = 6, CoursId = 6, Grade = 90.0m },
                new Enrollments { StudentId = 7, CoursId = 7, Grade = 76.4m },
                new Enrollments { StudentId = 8, CoursId = 8, Grade = 89.1m },
                new Enrollments { StudentId = 9, CoursId = 9, Grade = 94.5m },
                new Enrollments { StudentId = 10, CoursId = 10, Grade = 81.2m }
            );






            base.OnModelCreating(modelBuilder);


        }

    }
}
