using Microsoft.EntityFrameworkCore.Migrations;

namespace University.DatabaseContexts.Migrations
{
    public partial class ListOfCourses_Added_To_CourseEnrollToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseEnrollToStudentId",
                table: "Courses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseEnrollToStudentId",
                table: "Courses",
                column: "CourseEnrollToStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseEnrollToStudents_CourseEnrollToStudentId",
                table: "Courses",
                column: "CourseEnrollToStudentId",
                principalTable: "CourseEnrollToStudents",
                principalColumn: "CourseEnrollToStudentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseEnrollToStudents_CourseEnrollToStudentId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseEnrollToStudentId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseEnrollToStudentId",
                table: "Courses");
        }
    }
}
