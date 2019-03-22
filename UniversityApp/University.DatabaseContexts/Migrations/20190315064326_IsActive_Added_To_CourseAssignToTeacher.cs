using Microsoft.EntityFrameworkCore.Migrations;

namespace University.DatabaseContexts.Migrations
{
    public partial class IsActive_Added_To_CourseAssignToTeacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CourseAssignToTeachers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CourseAssignToTeachers");
        }
    }
}
