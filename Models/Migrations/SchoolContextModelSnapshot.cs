﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.Context;

#nullable disable

namespace Models.Migrations
{
    [DbContext(typeof(SchoolContext))]
    partial class SchoolContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Entities.Attendances", b =>
                {
                    b.Property<int>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AttendanceId"));

                    b.Property<int>("CoursId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPresent")
                        .HasColumnType("bit");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("AttendanceId");

                    b.HasIndex("CoursId");

                    b.HasIndex("StudentId");

                    b.ToTable("Attendances");

                    b.HasData(
                        new
                        {
                            AttendanceId = 1,
                            CoursId = 1,
                            Date = new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPresent = true,
                            StudentId = 1
                        },
                        new
                        {
                            AttendanceId = 2,
                            CoursId = 2,
                            Date = new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPresent = false,
                            StudentId = 2
                        },
                        new
                        {
                            AttendanceId = 3,
                            CoursId = 3,
                            Date = new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPresent = true,
                            StudentId = 3
                        },
                        new
                        {
                            AttendanceId = 4,
                            CoursId = 4,
                            Date = new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPresent = true,
                            StudentId = 4
                        },
                        new
                        {
                            AttendanceId = 5,
                            CoursId = 5,
                            Date = new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPresent = false,
                            StudentId = 5
                        },
                        new
                        {
                            AttendanceId = 6,
                            CoursId = 6,
                            Date = new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPresent = true,
                            StudentId = 6
                        },
                        new
                        {
                            AttendanceId = 7,
                            CoursId = 7,
                            Date = new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPresent = true,
                            StudentId = 7
                        },
                        new
                        {
                            AttendanceId = 8,
                            CoursId = 8,
                            Date = new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPresent = false,
                            StudentId = 8
                        },
                        new
                        {
                            AttendanceId = 9,
                            CoursId = 9,
                            Date = new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPresent = true,
                            StudentId = 9
                        },
                        new
                        {
                            AttendanceId = 10,
                            CoursId = 10,
                            Date = new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsPresent = false,
                            StudentId = 10
                        });
                });

            modelBuilder.Entity("Models.Entities.Classrooms", b =>
                {
                    b.Property<int>("ClassroomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassroomId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ClassroomId");

                    b.ToTable("classrooms");

                    b.HasData(
                        new
                        {
                            ClassroomId = 1,
                            Capacity = 30,
                            Location = "Building 1",
                            Name = "A101"
                        },
                        new
                        {
                            ClassroomId = 2,
                            Capacity = 25,
                            Location = "Building 2",
                            Name = "B202"
                        },
                        new
                        {
                            ClassroomId = 3,
                            Capacity = 20,
                            Location = "Building 3",
                            Name = "C303"
                        },
                        new
                        {
                            ClassroomId = 4,
                            Capacity = 35,
                            Location = "Building 4",
                            Name = "D404"
                        },
                        new
                        {
                            ClassroomId = 5,
                            Capacity = 40,
                            Location = "Building 5",
                            Name = "E505"
                        },
                        new
                        {
                            ClassroomId = 6,
                            Capacity = 28,
                            Location = "Building 6",
                            Name = "F606"
                        },
                        new
                        {
                            ClassroomId = 7,
                            Capacity = 32,
                            Location = "Building 7",
                            Name = "G707"
                        },
                        new
                        {
                            ClassroomId = 8,
                            Capacity = 27,
                            Location = "Building 8",
                            Name = "H808"
                        },
                        new
                        {
                            ClassroomId = 9,
                            Capacity = 22,
                            Location = "Building 9",
                            Name = "I909"
                        },
                        new
                        {
                            ClassroomId = 10,
                            Capacity = 30,
                            Location = "Building 10",
                            Name = "J1010"
                        });
                });

            modelBuilder.Entity("Models.Entities.Courses", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<int>("ClassroomID")
                        .HasColumnType("int");

                    b.Property<int>("Cridets")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("ClassroomID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            ClassroomID = 1,
                            Cridets = 3,
                            Name = "Mathematics",
                            TeacherID = 1
                        },
                        new
                        {
                            CourseId = 2,
                            ClassroomID = 2,
                            Cridets = 4,
                            Name = "Physics",
                            TeacherID = 2
                        },
                        new
                        {
                            CourseId = 3,
                            ClassroomID = 3,
                            Cridets = 3,
                            Name = "Chemistry",
                            TeacherID = 3
                        },
                        new
                        {
                            CourseId = 4,
                            ClassroomID = 4,
                            Cridets = 3,
                            Name = "Biology",
                            TeacherID = 4
                        },
                        new
                        {
                            CourseId = 5,
                            ClassroomID = 5,
                            Cridets = 2,
                            Name = "History",
                            TeacherID = 5
                        },
                        new
                        {
                            CourseId = 6,
                            ClassroomID = 6,
                            Cridets = 3,
                            Name = "English",
                            TeacherID = 6
                        },
                        new
                        {
                            CourseId = 7,
                            ClassroomID = 7,
                            Cridets = 2,
                            Name = "Geography",
                            TeacherID = 7
                        },
                        new
                        {
                            CourseId = 8,
                            ClassroomID = 8,
                            Cridets = 2,
                            Name = "Art",
                            TeacherID = 8
                        },
                        new
                        {
                            CourseId = 9,
                            ClassroomID = 9,
                            Cridets = 2,
                            Name = "Music",
                            TeacherID = 9
                        },
                        new
                        {
                            CourseId = 10,
                            ClassroomID = 10,
                            Cridets = 4,
                            Name = "Computer Science",
                            TeacherID = 10
                        });
                });

            modelBuilder.Entity("Models.Entities.Enrollments", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CoursId")
                        .HasColumnType("int");

                    b.Property<decimal>("Grade")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("StudentId", "CoursId");

                    b.HasIndex("CoursId");

                    b.ToTable("Enrollments");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CoursId = 1,
                            Grade = 85.5m
                        },
                        new
                        {
                            StudentId = 2,
                            CoursId = 2,
                            Grade = 78.0m
                        },
                        new
                        {
                            StudentId = 3,
                            CoursId = 3,
                            Grade = 92.3m
                        },
                        new
                        {
                            StudentId = 4,
                            CoursId = 4,
                            Grade = 67.8m
                        },
                        new
                        {
                            StudentId = 5,
                            CoursId = 5,
                            Grade = 88.6m
                        },
                        new
                        {
                            StudentId = 6,
                            CoursId = 6,
                            Grade = 90.0m
                        },
                        new
                        {
                            StudentId = 7,
                            CoursId = 7,
                            Grade = 76.4m
                        },
                        new
                        {
                            StudentId = 8,
                            CoursId = 8,
                            Grade = 89.1m
                        },
                        new
                        {
                            StudentId = 9,
                            CoursId = 9,
                            Grade = 94.5m
                        },
                        new
                        {
                            StudentId = 10,
                            CoursId = 10,
                            Grade = 81.2m
                        });
                });

            modelBuilder.Entity("Models.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            DateOfBirth = new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alice@school.com",
                            Name = "Alice Johnson",
                            Phone = "123456789"
                        },
                        new
                        {
                            StudentId = 2,
                            DateOfBirth = new DateTime(2004, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "bob@school.com",
                            Name = "Bob Williams",
                            Phone = "987654321"
                        },
                        new
                        {
                            StudentId = 3,
                            DateOfBirth = new DateTime(2006, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "charlie@school.com",
                            Name = "Charlie Brown",
                            Phone = "555123456"
                        },
                        new
                        {
                            StudentId = 4,
                            DateOfBirth = new DateTime(2005, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "david@school.com",
                            Name = "David Smith",
                            Phone = "666987654"
                        },
                        new
                        {
                            StudentId = 5,
                            DateOfBirth = new DateTime(2003, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "eve@school.com",
                            Name = "Eve Miller",
                            Phone = "777654321"
                        },
                        new
                        {
                            StudentId = 6,
                            DateOfBirth = new DateTime(2004, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "frank@school.com",
                            Name = "Frank White",
                            Phone = "888123987"
                        },
                        new
                        {
                            StudentId = 7,
                            DateOfBirth = new DateTime(2005, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "grace@school.com",
                            Name = "Grace Hall",
                            Phone = "999654789"
                        },
                        new
                        {
                            StudentId = 8,
                            DateOfBirth = new DateTime(2006, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hank@school.com",
                            Name = "Hank Adams",
                            Phone = "111222333"
                        },
                        new
                        {
                            StudentId = 9,
                            DateOfBirth = new DateTime(2003, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ivy@school.com",
                            Name = "Ivy Parker",
                            Phone = "444555666"
                        },
                        new
                        {
                            StudentId = 10,
                            DateOfBirth = new DateTime(2004, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jack@school.com",
                            Name = "Jack Carter",
                            Phone = "777888999"
                        });
                });

            modelBuilder.Entity("Models.Entities.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teatchers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            Email = "john@school.com",
                            Name = "John Smith",
                            Subject = "Math",
                            phone = "123456789"
                        },
                        new
                        {
                            TeacherId = 2,
                            Email = "sarah@school.com",
                            Name = "Sarah Johnson",
                            Subject = "Physics",
                            phone = "987654321"
                        },
                        new
                        {
                            TeacherId = 3,
                            Email = "michael@school.com",
                            Name = "Michael Brown",
                            Subject = "Chemistry",
                            phone = "555123456"
                        },
                        new
                        {
                            TeacherId = 4,
                            Email = "emily@school.com",
                            Name = "Emily Davis",
                            Subject = "Biology",
                            phone = "666987654"
                        },
                        new
                        {
                            TeacherId = 5,
                            Email = "robert@school.com",
                            Name = "Robert Wilson",
                            Subject = "History",
                            phone = "777654321"
                        },
                        new
                        {
                            TeacherId = 6,
                            Email = "jessica@school.com",
                            Name = "Jessica Taylor",
                            Subject = "English",
                            phone = "888123987"
                        },
                        new
                        {
                            TeacherId = 7,
                            Email = "david@school.com",
                            Name = "David White",
                            Subject = "Geography",
                            phone = "999654789"
                        },
                        new
                        {
                            TeacherId = 8,
                            Email = "linda@school.com",
                            Name = "Linda Martin",
                            Subject = "Art",
                            phone = "111222333"
                        },
                        new
                        {
                            TeacherId = 9,
                            Email = "james@school.com",
                            Name = "James Clark",
                            Subject = "Music",
                            phone = "444555666"
                        },
                        new
                        {
                            TeacherId = 10,
                            Email = "mary@school.com",
                            Name = "Mary Lewis",
                            Subject = "Computer Science",
                            phone = "777888999"
                        });
                });

            modelBuilder.Entity("Models.Entities.Attendances", b =>
                {
                    b.HasOne("Models.Entities.Courses", "Courses")
                        .WithMany("Attendances")
                        .HasForeignKey("CoursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.Student", "Student")
                        .WithMany("Attendances")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Models.Entities.Courses", b =>
                {
                    b.HasOne("Models.Entities.Classrooms", "Classrooms")
                        .WithMany("Courses")
                        .HasForeignKey("ClassroomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.Teacher", "Teatcher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classrooms");

                    b.Navigation("Teatcher");
                });

            modelBuilder.Entity("Models.Entities.Enrollments", b =>
                {
                    b.HasOne("Models.Entities.Courses", "Courses")
                        .WithMany("Enrollments")
                        .HasForeignKey("CoursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Models.Entities.Classrooms", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("Models.Entities.Courses", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("Models.Entities.Student", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("Models.Entities.Teacher", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
