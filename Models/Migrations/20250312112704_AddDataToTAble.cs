using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToTAble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classrooms",
                columns: table => new
                {
                    ClassroomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classrooms", x => x.ClassroomId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Teatchers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teatchers", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Cridets = table.Column<int>(type: "int", nullable: false),
                    TeacherID = table.Column<int>(type: "int", nullable: false),
                    ClassroomID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Teatchers_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "Teatchers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_classrooms_ClassroomID",
                        column: x => x.ClassroomID,
                        principalTable: "classrooms",
                        principalColumn: "ClassroomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPresent = table.Column<bool>(type: "bit", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CoursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.AttendanceId);
                    table.ForeignKey(
                        name: "FK_Attendances_Courses_CoursId",
                        column: x => x.CoursId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attendances_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CoursId = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => new { x.StudentId, x.CoursId });
                    table.ForeignKey(
                        name: "FK_Enrollments_Courses_CoursId",
                        column: x => x.CoursId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DateOfBirth", "Email", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(2005, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "alice@school.com", "Alice Johnson", "123456789" },
                    { 2, new DateTime(2004, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "bob@school.com", "Bob Williams", "987654321" },
                    { 3, new DateTime(2006, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "charlie@school.com", "Charlie Brown", "555123456" },
                    { 4, new DateTime(2005, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "david@school.com", "David Smith", "666987654" },
                    { 5, new DateTime(2003, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "eve@school.com", "Eve Miller", "777654321" },
                    { 6, new DateTime(2004, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "frank@school.com", "Frank White", "888123987" },
                    { 7, new DateTime(2005, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "grace@school.com", "Grace Hall", "999654789" },
                    { 8, new DateTime(2006, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "hank@school.com", "Hank Adams", "111222333" },
                    { 9, new DateTime(2003, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ivy@school.com", "Ivy Parker", "444555666" },
                    { 10, new DateTime(2004, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "jack@school.com", "Jack Carter", "777888999" }
                });

            migrationBuilder.InsertData(
                table: "Teatchers",
                columns: new[] { "TeacherId", "Email", "Name", "Subject", "phone" },
                values: new object[,]
                {
                    { 1, "john@school.com", "John Smith", "Math", "123456789" },
                    { 2, "sarah@school.com", "Sarah Johnson", "Physics", "987654321" },
                    { 3, "michael@school.com", "Michael Brown", "Chemistry", "555123456" },
                    { 4, "emily@school.com", "Emily Davis", "Biology", "666987654" },
                    { 5, "robert@school.com", "Robert Wilson", "History", "777654321" },
                    { 6, "jessica@school.com", "Jessica Taylor", "English", "888123987" },
                    { 7, "david@school.com", "David White", "Geography", "999654789" },
                    { 8, "linda@school.com", "Linda Martin", "Art", "111222333" },
                    { 9, "james@school.com", "James Clark", "Music", "444555666" },
                    { 10, "mary@school.com", "Mary Lewis", "Computer Science", "777888999" }
                });

            migrationBuilder.InsertData(
                table: "classrooms",
                columns: new[] { "ClassroomId", "Capacity", "Location", "Name" },
                values: new object[,]
                {
                    { 1, 30, "Building 1", "A101" },
                    { 2, 25, "Building 2", "B202" },
                    { 3, 20, "Building 3", "C303" },
                    { 4, 35, "Building 4", "D404" },
                    { 5, 40, "Building 5", "E505" },
                    { 6, 28, "Building 6", "F606" },
                    { 7, 32, "Building 7", "G707" },
                    { 8, 27, "Building 8", "H808" },
                    { 9, 22, "Building 9", "I909" },
                    { 10, 30, "Building 10", "J1010" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "ClassroomID", "Cridets", "Name", "TeacherID" },
                values: new object[,]
                {
                    { 1, 1, 3, "Mathematics", 1 },
                    { 2, 2, 4, "Physics", 2 },
                    { 3, 3, 3, "Chemistry", 3 },
                    { 4, 4, 3, "Biology", 4 },
                    { 5, 5, 2, "History", 5 },
                    { 6, 6, 3, "English", 6 },
                    { 7, 7, 2, "Geography", 7 },
                    { 8, 8, 2, "Art", 8 },
                    { 9, 9, 2, "Music", 9 },
                    { 10, 10, 4, "Computer Science", 10 }
                });

            migrationBuilder.InsertData(
                table: "Attendances",
                columns: new[] { "AttendanceId", "CoursId", "Date", "IsPresent", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 2, 2, new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 2 },
                    { 3, 3, new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 3 },
                    { 4, 4, new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 4 },
                    { 5, 5, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 5 },
                    { 6, 6, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 6 },
                    { 7, 7, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 7 },
                    { 8, 8, new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 8 },
                    { 9, 9, new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 9 },
                    { 10, 10, new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, 10 }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "CoursId", "StudentId", "Grade" },
                values: new object[,]
                {
                    { 1, 1, 85.5m },
                    { 2, 2, 78.0m },
                    { 3, 3, 92.3m },
                    { 4, 4, 67.8m },
                    { 5, 5, 88.6m },
                    { 6, 6, 90.0m },
                    { 7, 7, 76.4m },
                    { 8, 8, 89.1m },
                    { 9, 9, 94.5m },
                    { 10, 10, 81.2m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_CoursId",
                table: "Attendances",
                column: "CoursId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_StudentId",
                table: "Attendances",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ClassroomID",
                table: "Courses",
                column: "ClassroomID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherID",
                table: "Courses",
                column: "TeacherID");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CoursId",
                table: "Enrollments",
                column: "CoursId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teatchers");

            migrationBuilder.DropTable(
                name: "classrooms");
        }
    }
}
