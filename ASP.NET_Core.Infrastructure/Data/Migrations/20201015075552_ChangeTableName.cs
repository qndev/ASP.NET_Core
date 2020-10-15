using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core.Infrastructure.Data.Migrations
{
    public partial class ChangeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseUsers",
                table: "CourseUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseLectures",
                table: "CourseLectures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswerUsers",
                table: "AnswerUsers");

            migrationBuilder.RenameTable(
                name: "CourseUsers",
                newName: "CourseUser");

            migrationBuilder.RenameTable(
                name: "CourseLectures",
                newName: "CourseLecture");

            migrationBuilder.RenameTable(
                name: "AnswerUsers",
                newName: "AnswerUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseUser",
                table: "CourseUser",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseLecture",
                table: "CourseLecture",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnswerUser",
                table: "AnswerUser",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseUser",
                table: "CourseUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseLecture",
                table: "CourseLecture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswerUser",
                table: "AnswerUser");

            migrationBuilder.RenameTable(
                name: "CourseUser",
                newName: "CourseUsers");

            migrationBuilder.RenameTable(
                name: "CourseLecture",
                newName: "CourseLectures");

            migrationBuilder.RenameTable(
                name: "AnswerUser",
                newName: "AnswerUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseUsers",
                table: "CourseUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseLectures",
                table: "CourseLectures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnswerUsers",
                table: "AnswerUsers",
                column: "Id");
        }
    }
}
