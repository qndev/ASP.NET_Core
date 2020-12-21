using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core.Infrastructure.Data.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lectures",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_Lectures", x => x.LectureId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_Exercises", x => x.ExerciseId);
                    table.ForeignKey(
                        name: "FK_Exercises_Lectures_LectureId",
                        column: x => x.LectureId,
                        principalTable: "Lectures",
                        principalColumn: "LectureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_Faqs", x => x.FaqId);
                    table.ForeignKey(
                        name: "FK_Faqs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_News", x => x.NewsId);
                    table.ForeignKey(
                        name: "FK_News_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                    table.ForeignKey(
                        name: "FK_Subjects_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Questions_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "ExerciseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_Answers", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseLecture",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_CourseLecture", x => x.CourseLectureId);
                    table.ForeignKey(
                        name: "FK_CourseLecture_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseLecture_Lectures_LectureId",
                        column: x => x.LectureId,
                        principalTable: "Lectures",
                        principalColumn: "LectureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CourseUser",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_CourseUser", x => x.CourseUserId);
                    table.ForeignKey(
                        name: "FK_CourseUser_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CourseUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnswerUser",
                columns: table => new
                {
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
                    table.PrimaryKey("PK_AnswerUser", x => x.AnswerUserId);
                    table.ForeignKey(
                        name: "FK_AnswerUser_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "AnswerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnswerUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerUser_AnswerId",
                table: "AnswerUser",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerUser_UserId",
                table: "AnswerUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLecture_CourseId",
                table: "CourseLecture",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLecture_LectureId",
                table: "CourseLecture",
                column: "LectureId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SubjectId",
                table: "Courses",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseUser_CourseId",
                table: "CourseUser",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseUser_UserId",
                table: "CourseUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_LectureId",
                table: "Exercises",
                column: "LectureId");

            migrationBuilder.CreateIndex(
                name: "IX_Faqs_UserId",
                table: "Faqs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_News_UserId",
                table: "News",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExerciseId",
                table: "Questions",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_UserId",
                table: "Subjects",
                column: "UserId");
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
