using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace task_day_2_entityf_ramework.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    specialization = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    percent = table.Column<decimal>(type: "decimal(4,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.CheckConstraint("CK_Student_Age", "[Age] >= 16");
                    table.CheckConstraint("CK_Student_Email", "[Email] LIKE '%_@__%.__%'");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "VARCHAR(150)", maxLength: 150, nullable: false),
                    durationInHours = table.Column<int>(type: "int", nullable: false),
                    instructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Instructors_instructorId",
                        column: x => x.instructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "email", "name", "specialization" },
                values: new object[,]
                {
                    { 1, "ahmed@test.com", "Ahmed Ali", "Backend" },
                    { 2, "mona@test.com", "Mona Hassan", "Frontend" },
                    { 3, "omar@test.com", "Omar Said", "Database" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "age", "name", "percent" },
                values: new object[,]
                {
                    { 1, "shahd@gmail.com", 20, "shahd", 85m },
                    { 2, "sara.ali@gmail.com", 19, "Sara Ali", 92m },
                    { 3, "mariam.tarek@yahoo.com", 22, "mariam Tarek", 78m },
                    { 4, "nour.hassan@outlook.com", 18, "Nour Hassan", 88m },
                    { 5, "katy.adel@gmail.com", 21, " katy Adel", 65m },
                    { 6, "shahd@gmail.com", 20, "shahd", 85m },
                    { 7, "sara.ali@gmail.com", 19, "Sara Ali", 92m },
                    { 8, "mariam.tarek@yahoo.com", 22, "mariam Tarek", 78m },
                    { 9, "nour.hassan@outlook.com", 18, "Nour Hassan", 88m },
                    { 10, "hana.sameh@yahoo.com", 16, "Hana Sameh", 82m }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "description", "durationInHours", "instructorId", "name" },
                values: new object[,]
                {
                    { 1, "Learn the basics of C# programming language including variables, loops and OOP concepts.", 30, 1, "C# Fundamentals" },
                    { 2, "Build modern web applications and APIs using ASP.NET Core framework.", 40, 2, "ASP.NET Core" },
                    { 3, "Master Code First approach, migrations, relationships and querying with EF Core.", 25, 1, "Entity Framework Core" },
                    { 4, "Understand database design, T-SQL queries, joins and stored procedures.", 20, 3, "SQL Server Basics" },
                    { 5, "Introduction to HTML, CSS and JavaScript for building interactive websites.", 35, 2, "Web Development" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_instructorId",
                table: "Courses",
                column: "instructorId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseId",
                table: "StudentCourses",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
