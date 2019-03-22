using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University.DatabaseContexts.Migrations
{
    public partial class IsActive_Added_To_AllocateClassRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeFromAMPM",
                table: "AllocateClassRooms");

            migrationBuilder.DropColumn(
                name: "TimeToAMPM",
                table: "AllocateClassRooms");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ToTime",
                table: "AllocateClassRooms",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FromTime",
                table: "AllocateClassRooms",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AllocateClassRooms",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AllocateClassRooms");

            migrationBuilder.AlterColumn<string>(
                name: "ToTime",
                table: "AllocateClassRooms",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "FromTime",
                table: "AllocateClassRooms",
                nullable: false,
                oldClrType: typeof(DateTime));

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
    }
}
