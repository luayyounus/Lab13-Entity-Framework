using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StarGazersUniversity.Migrations
{
    public partial class StudentModelRemovedClassTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassOne",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "ClassTwo",
                table: "Students",
                newName: "Class");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Class",
                table: "Students",
                newName: "ClassTwo");

            migrationBuilder.AddColumn<string>(
                name: "ClassOne",
                table: "Students",
                nullable: true);
        }
    }
}
