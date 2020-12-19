using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core.Infrastructure.Data.Migrations
{
    public partial class RefineInitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lectures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LectureId = table.Column<string>(type: "varchar(256)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    DoccumentUrl = table.Column<string>(type: "varchar(256)", nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectures", x => new { x.Id, x.LectureId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(256)", nullable: false),
                    FirstName = table.Column<string>(type: "varchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", nullable: false),
                    Email = table.Column<string>(type: "varchar(256)", nullable: true),
                    Birthday = table.Column<DateTime>(nullable: true),
                    Phone = table.Column<string>(type: "varchar(25)", nullable: true),
                    Gender = table.Column<byte>(nullable: false, defaultValue: (byte)0),
                    ImageUrl = table.Column<string>(type: "varchar(256)", nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => new { x.Id, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ExerciseId = table.Column<string>(type: "varchar(256)", nullable: false),
                    LectureId = table.Column<string>(nullable: true),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    OrderNumber = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => new { x.Id, x.ExerciseId });
                    table.ForeignKey(
                        name: "FK_Exercises_Lectures_Id_LectureId",
                        columns: x => new { x.Id, x.LectureId },
                        principalTable: "Lectures",
                        principalColumns: new[] { "Id", "LectureId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CommentId = table.Column<string>(type: "varchar(256)", nullable: false),
                    ParentId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    CourseId = table.Column<string>(nullable: false),
                    LectureId = table.Column<string>(nullable: false),
                    CommentContent = table.Column<string>(type: "text", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => new { x.Id, x.CommentId });
                    table.ForeignKey(
                        name: "FK_Comments_Users_Id_UserId",
                        columns: x => new { x.Id, x.UserId },
                        principalTable: "Users",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FaqId = table.Column<string>(type: "varchar(256)", nullable: false),
                    Question = table.Column<string>(type: "text", nullable: false),
                    Answer = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => new { x.Id, x.FaqId });
                    table.ForeignKey(
                        name: "FK_Faqs_Users_Id_UserId",
                        columns: x => new { x.Id, x.UserId },
                        principalTable: "Users",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NewsId = table.Column<string>(type: "varchar(256)", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => new { x.Id, x.NewsId });
                    table.ForeignKey(
                        name: "FK_News_Users_Id_UserId",
                        columns: x => new { x.Id, x.UserId },
                        principalTable: "Users",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SubjectId = table.Column<string>(type: "varchar(256)", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(256)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => new { x.Id, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_Subjects_Users_Id_UserId",
                        columns: x => new { x.Id, x.UserId },
                        principalTable: "Users",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    QuestionId = table.Column<string>(type: "varchar(256)", nullable: false),
                    ExerciseId = table.Column<string>(nullable: true),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    OrderNumber = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => new { x.Id, x.QuestionId });
                    table.ForeignKey(
                        name: "FK_Questions_Exercises_Id_ExerciseId",
                        columns: x => new { x.Id, x.ExerciseId },
                        principalTable: "Exercises",
                        principalColumns: new[] { "Id", "ExerciseId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<string>(type: "varchar(256)", nullable: false),
                    SubjectId = table.Column<string>(nullable: true),
                    Code = table.Column<string>(type: "varchar(50)", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    Resources = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10, 2)", nullable: false, defaultValue: 0m),
                    ImageFile = table.Column<string>(type: "varchar(256)", nullable: true),
                    Status = table.Column<byte>(nullable: false, defaultValue: (byte)0),
                    UserId = table.Column<string>(nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => new { x.Id, x.CourseId });
                    table.ForeignKey(
                        name: "FK_Courses_Subjects_Id_SubjectId",
                        columns: x => new { x.Id, x.SubjectId },
                        principalTable: "Subjects",
                        principalColumns: new[] { "Id", "SubjectId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnswerId = table.Column<string>(type: "varchar(256)", nullable: false),
                    QuestionId = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: false),
                    CorrectFlag = table.Column<bool>(nullable: false),
                    OrderNumber = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => new { x.Id, x.AnswerId });
                    table.ForeignKey(
                        name: "FK_Answers_Questions_Id_QuestionId",
                        columns: x => new { x.Id, x.QuestionId },
                        principalTable: "Questions",
                        principalColumns: new[] { "Id", "QuestionId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseLecture",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CourseLectureId = table.Column<string>(type: "varchar(256)", nullable: false),
                    CourseId = table.Column<string>(nullable: true),
                    LectureId = table.Column<string>(nullable: true),
                    OrderNumber = table.Column<int>(nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseLecture", x => new { x.Id, x.CourseLectureId });
                    table.ForeignKey(
                        name: "FK_CourseLecture_Courses_Id_CourseId",
                        columns: x => new { x.Id, x.CourseId },
                        principalTable: "Courses",
                        principalColumns: new[] { "Id", "CourseId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseLecture_Lectures_Id_LectureId",
                        columns: x => new { x.Id, x.LectureId },
                        principalTable: "Lectures",
                        principalColumns: new[] { "Id", "LectureId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CourseUserId = table.Column<string>(type: "varchar(256)", nullable: false),
                    CourseId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    OrderStatus = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    OrderType = table.Column<byte>(nullable: false),
                    OrderDateTime = table.Column<DateTime>(type: "timestamp", nullable: false),
                    PaymentDateTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseUser", x => new { x.Id, x.CourseUserId });
                    table.ForeignKey(
                        name: "FK_CourseUser_Courses_Id_CourseId",
                        columns: x => new { x.Id, x.CourseId },
                        principalTable: "Courses",
                        principalColumns: new[] { "Id", "CourseId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseUser_Users_Id_UserId",
                        columns: x => new { x.Id, x.UserId },
                        principalTable: "Users",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnswerUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnswerUserId = table.Column<string>(type: "varchar(256)", nullable: false),
                    AnswerId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    CourseId = table.Column<string>(nullable: false),
                    LectureId = table.Column<string>(nullable: false),
                    QuestionId = table.Column<string>(nullable: false),
                    CreationTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "timestamp", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerUser", x => new { x.Id, x.AnswerUserId });
                    table.ForeignKey(
                        name: "FK_AnswerUser_Answers_Id_AnswerId",
                        columns: x => new { x.Id, x.AnswerId },
                        principalTable: "Answers",
                        principalColumns: new[] { "Id", "AnswerId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnswerUser_Users_Id_UserId",
                        columns: x => new { x.Id, x.UserId },
                        principalTable: "Users",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_Id_QuestionId",
                table: "Answers",
                columns: new[] { "Id", "QuestionId" });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerUser_Id_AnswerId",
                table: "AnswerUser",
                columns: new[] { "Id", "AnswerId" });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerUser_Id_UserId",
                table: "AnswerUser",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Id_UserId",
                table: "Comments",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_CourseLecture_Id_CourseId",
                table: "CourseLecture",
                columns: new[] { "Id", "CourseId" });

            migrationBuilder.CreateIndex(
                name: "IX_CourseLecture_Id_LectureId",
                table: "CourseLecture",
                columns: new[] { "Id", "LectureId" });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Id_SubjectId",
                table: "Courses",
                columns: new[] { "Id", "SubjectId" });

            migrationBuilder.CreateIndex(
                name: "IX_CourseUser_Id_CourseId",
                table: "CourseUser",
                columns: new[] { "Id", "CourseId" });

            migrationBuilder.CreateIndex(
                name: "IX_CourseUser_Id_UserId",
                table: "CourseUser",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_Id_LectureId",
                table: "Exercises",
                columns: new[] { "Id", "LectureId" });

            migrationBuilder.CreateIndex(
                name: "IX_Faqs_Id_UserId",
                table: "Faqs",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_News_Id_UserId",
                table: "News",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_Id_ExerciseId",
                table: "Questions",
                columns: new[] { "Id", "ExerciseId" });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_Id_UserId",
                table: "Subjects",
                columns: new[] { "Id", "UserId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerUser");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "CourseLecture");

            migrationBuilder.DropTable(
                name: "CourseUser");

            migrationBuilder.DropTable(
                name: "Faqs");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Lectures");
        }
    }
}
