using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core.Infrastructure.Data.Migrations
{
    public partial class ConfigProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoccumentUrl",
                table: "Faqs");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Faqs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CourseLecture");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "CourseLecture");

            migrationBuilder.AlterColumn<string>(
                name: "RememberToken",
                table: "Users",
                type: "varchar(25)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Users",
                type: "varchar(25)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Users",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Users",
                type: "varchar(25)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Gender",
                table: "Users",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(byte),
                oldType: "tinyint unsigned");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EmailVerifiedAt",
                table: "Users",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Users",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Users",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Users",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Subjects",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Subjects",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Subjects",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Subjects",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Questions",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Questions",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Questions",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Questions",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Questions",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "News",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "News",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "News",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "News",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "News",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<sbyte>(
                name: "Type",
                table: "Lectures",
                type: "tinyint(4)",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint unsigned");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Lectures",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Lectures",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DoccumentUrl",
                table: "Lectures",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Lectures",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Lectures",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Lectures",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Question",
                table: "Faqs",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Faqs",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Faqs",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Faqs",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Answer",
                table: "Faqs",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Exercises",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Exercises",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Exercises",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Exercises",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Exercises",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDateTime",
                table: "CourseUser",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<sbyte>(
                name: "OrderStatus",
                table: "CourseUser",
                type: "tinyint(4)",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint unsigned");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDateTime",
                table: "CourseUser",
                type: "timestamp",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "CourseUser",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "CourseUser",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "CourseUser",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "Courses",
                nullable: false,
                defaultValue: (byte)0,
                oldClrType: typeof(byte),
                oldType: "tinyint unsigned");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Courses",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Resources",
                table: "Courses",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Courses",
                type: "decimal(10, 2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Courses",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageFile",
                table: "Courses",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Courses",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Courses",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Courses",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Courses",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Courses",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "CourseLecture",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "CourseLecture",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "CourseLecture",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Comments",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Comments",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Comments",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "CommentContent",
                table: "Comments",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "AnswerUser",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "AnswerUser",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "AnswerUser",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<sbyte>(
                name: "OrderNumber",
                table: "Answers",
                type: "tinyint(4)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Answers",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Answers",
                type: "timestamp",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Answers",
                type: "timestamp",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<bool>(
                name: "CorrectFlag",
                table: "Answers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Answers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RememberToken",
                table: "Users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Users",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Gender",
                table: "Users",
                type: "tinyint unsigned",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValue: (byte)0);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EmailVerifiedAt",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Users",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Users",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Subjects",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Subjects",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Subjects",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Subjects",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Questions",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Questions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Questions",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Questions",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Questions",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "Title",
                table: "News",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "News",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "News",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "News",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "News",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<byte>(
                name: "Type",
                table: "Lectures",
                type: "tinyint unsigned",
                nullable: false,
                oldClrType: typeof(sbyte),
                oldType: "tinyint(4)");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Lectures",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Lectures",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DoccumentUrl",
                table: "Lectures",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Lectures",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Lectures",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Lectures",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<int>(
                name: "Question",
                table: "Faqs",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Faqs",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Faqs",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Faqs",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "Answer",
                table: "Faqs",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<DateTime>(
                name: "DoccumentUrl",
                table: "Faqs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte>(
                name: "Type",
                table: "Faqs",
                type: "tinyint unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Exercises",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Exercises",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Exercises",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Exercises",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Exercises",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PaymentDateTime",
                table: "CourseUser",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "OrderStatus",
                table: "CourseUser",
                type: "tinyint unsigned",
                nullable: false,
                oldClrType: typeof(sbyte),
                oldType: "tinyint(4)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDateTime",
                table: "CourseUser",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "CourseUser",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "CourseUser",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "CourseUser",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "Courses",
                type: "tinyint unsigned",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValue: (byte)0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Courses",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Resources",
                table: "Courses",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Courses",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10, 2)",
                oldDefaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Courses",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Courses",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageFile",
                table: "Courses",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Courses",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Courses",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Courses",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Courses",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Courses",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "CourseLecture",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "CourseLecture",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "CourseLecture",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "CourseLecture",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "CourseLecture",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Comments",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Comments",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Comments",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "CommentContent",
                table: "Comments",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "AnswerUser",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "AnswerUser",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "AnswerUser",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<int>(
                name: "OrderNumber",
                table: "Answers",
                type: "int",
                nullable: false,
                oldClrType: typeof(sbyte),
                oldType: "tinyint(4)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Answers",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeletionTime",
                table: "Answers",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Answers",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp",
                oldDefaultValueSql: "getdate()");

            migrationBuilder.AlterColumn<string>(
                name: "CorrectFlag",
                table: "Answers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Answers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
