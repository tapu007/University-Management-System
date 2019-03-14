using Microsoft.EntityFrameworkCore.Migrations;

namespace University.DatabaseContexts.Migrations
{
    public partial class Teacher_Modified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Credit",
                table: "Teachers",
                newName: "TakenCredit");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Teachers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Teachers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNo",
                table: "Teachers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TimeFromAMPM",
                table: "AllocateClassRooms",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TimeToAMPM",
                table: "AllocateClassRooms",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "TimeFromAMPM",
                table: "AllocateClassRooms");

            migrationBuilder.DropColumn(
                name: "TimeToAMPM",
                table: "AllocateClassRooms");

            migrationBuilder.RenameColumn(
                name: "TakenCredit",
                table: "Teachers",
                newName: "Credit");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Teachers",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
