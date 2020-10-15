using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core.Infrastructure.Data.Migrations
{
    public partial class UpdateEntityRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Subjects_CreatedBy",
                table: "Subjects",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExerciseId",
                table: "Questions",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CreatedBy",
                table: "News",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Faqs_CreatedBy",
                table: "Faqs",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_LectureId",
                table: "Exercises",
                column: "LectureId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseUser_CourseId",
                table: "CourseUser",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseUser_UserId",
                table: "CourseUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SubjectId",
                table: "Courses",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLecture_CourseId",
                table: "CourseLecture",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseLecture_LectureId",
                table: "CourseLecture",
                column: "LectureId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerUser_AnswerId",
                table: "AnswerUser",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_AnswerUser_UserId",
                table: "AnswerUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerUser_Answers_AnswerId",
                table: "AnswerUser",
                column: "AnswerId",
                principalTable: "Answers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerUser_Users_UserId",
                table: "AnswerUser",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseLecture_Courses_CourseId",
                table: "CourseLecture",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseLecture_Lectures_LectureId",
                table: "CourseLecture",
                column: "LectureId",
                principalTable: "Lectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Subjects_SubjectId",
                table: "Courses",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseUser_Courses_CourseId",
                table: "CourseUser",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseUser_Users_UserId",
                table: "CourseUser",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_Lectures_LectureId",
                table: "Exercises",
                column: "LectureId",
                principalTable: "Lectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Faqs_Users_CreatedBy",
                table: "Faqs",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Users_CreatedBy",
                table: "News",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Exercises_ExerciseId",
                table: "Questions",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Users_CreatedBy",
                table: "Subjects",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_AnswerUser_Answers_AnswerId",
                table: "AnswerUser");

            migrationBuilder.DropForeignKey(
                name: "FK_AnswerUser_Users_UserId",
                table: "AnswerUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseLecture_Courses_CourseId",
                table: "CourseLecture");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseLecture_Lectures_LectureId",
                table: "CourseLecture");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Subjects_SubjectId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseUser_Courses_CourseId",
                table: "CourseUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseUser_Users_UserId",
                table: "CourseUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_Lectures_LectureId",
                table: "Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Faqs_Users_CreatedBy",
                table: "Faqs");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Users_CreatedBy",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Exercises_ExerciseId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Users_CreatedBy",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_CreatedBy",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ExerciseId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_News_CreatedBy",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_Faqs_CreatedBy",
                table: "Faqs");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_LectureId",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_CourseUser_CourseId",
                table: "CourseUser");

            migrationBuilder.DropIndex(
                name: "IX_CourseUser_UserId",
                table: "CourseUser");

            migrationBuilder.DropIndex(
                name: "IX_Courses_SubjectId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_CourseLecture_CourseId",
                table: "CourseLecture");

            migrationBuilder.DropIndex(
                name: "IX_CourseLecture_LectureId",
                table: "CourseLecture");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_AnswerUser_AnswerId",
                table: "AnswerUser");

            migrationBuilder.DropIndex(
                name: "IX_AnswerUser_UserId",
                table: "AnswerUser");

            migrationBuilder.DropIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers");
        }
    }
}
