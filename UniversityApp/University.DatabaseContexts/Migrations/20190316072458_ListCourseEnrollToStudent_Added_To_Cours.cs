using Microsoft.EntityFrameworkCore.Migrations;

namespace University.DatabaseContexts.Migrations
{
    public partial class ListCourseEnrollToStudent_Added_To_Cours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_CourseEnrollToStudents_CourseId",
                table: "CourseEnrollToStudents",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseEnrollToStudents_Courses_CourseId",
                table: "CourseEnrollToStudents",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseEnrollToStudents_Courses_CourseId",
                table: "CourseEnrollToStudents");

            migrationBuilder.DropIndex(
                name: "IX_CourseEnrollToStudents_CourseId",
                table: "CourseEnrollToStudents");

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
    }
}
