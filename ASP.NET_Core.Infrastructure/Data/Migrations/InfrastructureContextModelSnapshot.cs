﻿// <auto-generated />
using System;
using ASP.NET_Core.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP.NET_Core.Infrastructure.Data.Migrations
{
    [DbContext(typeof(InfrastructureContext))]
    partial class InfrastructureContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.AnswerUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AnswerUserId")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("AnswerId")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("CourseId")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("LectureId")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("QuestionId")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id", "AnswerUserId");

                    b.HasIndex("Id", "AnswerId");

                    b.HasIndex("Id", "UserId");

                    b.ToTable("AnswerUser");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CommentId")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("CommentContent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CourseId")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("LectureId")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ParentId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id", "CommentId");

                    b.HasIndex("Id", "UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseAggregate.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CourseId")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("Description")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue(null);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("ImageFile")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10, 2)")
                        .HasDefaultValue(0m);

                    b.Property<string>("Resources")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue(null);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.Property<byte>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint unsigned")
                        .HasDefaultValue((byte)0);

                    b.Property<string>("SubjectId")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id", "CourseId");

                    b.HasIndex("Id", "SubjectId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseAggregate.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("SubjectId")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id", "SubjectId");

                    b.HasIndex("Id", "UserId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseLecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CourseLectureId")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("CourseId")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("LectureId")
                        .HasColumnType("varchar(256)");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.HasKey("Id", "CourseLectureId");

                    b.HasIndex("Id", "CourseId");

                    b.HasIndex("Id", "LectureId");

                    b.ToTable("CourseLecture");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CourseUserId")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("CourseId")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime>("OrderDateTime")
                        .HasColumnType("timestamp");

                    b.Property<sbyte>("OrderStatus")
                        .HasColumnType("tinyint(4)");

                    b.Property<byte>("OrderType")
                        .HasColumnType("tinyint unsigned");

                    b.Property<DateTime?>("PaymentDateTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id", "CourseUserId");

                    b.HasIndex("Id", "CourseId");

                    b.HasIndex("Id", "UserId");

                    b.ToTable("CourseUser");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.Faq", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FaqId")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id", "FaqId");

                    b.HasIndex("Id", "UserId");

                    b.ToTable("Faqs");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AnswerId")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("CorrectFlag")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<sbyte>("OrderNumber")
                        .HasColumnType("tinyint(4)");

                    b.Property<string>("QuestionId")
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id", "AnswerId");

                    b.HasIndex("Id", "QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ExerciseId")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("LectureId")
                        .HasColumnType("varchar(256)");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id", "ExerciseId");

                    b.HasIndex("Id", "LectureId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Lecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("LectureId")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("DoccumentUrl")
                        .IsRequired()
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<sbyte>("Type")
                        .HasColumnType("tinyint(4)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id", "LectureId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("QuestionId")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ExerciseId")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.HasKey("Id", "QuestionId");

                    b.HasIndex("Id", "ExerciseId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NewsId")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id", "NewsId");

                    b.HasIndex("Id", "UserId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("CreationTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<byte>("Gender")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint unsigned")
                        .HasDefaultValue((byte)0);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("varchar(256)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(25)");

                    b.HasKey("Id", "UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.AnswerUser", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Answer", "Answer")
                        .WithMany("AnswerUsers")
                        .HasForeignKey("Id", "AnswerId");

                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.User", "User")
                        .WithMany("AnswerUsers")
                        .HasForeignKey("Id", "UserId");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.Comment", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("Id", "UserId");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseAggregate.Course", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.CourseAggregate.Subject", "Subject")
                        .WithMany("Courses")
                        .HasForeignKey("Id", "SubjectId");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseAggregate.Subject", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.User", "User")
                        .WithMany("Subjects")
                        .HasForeignKey("Id", "UserId");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseLecture", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.CourseAggregate.Course", "Course")
                        .WithMany("CourseLectures")
                        .HasForeignKey("Id", "CourseId");

                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Lecture", "Lecture")
                        .WithMany("CourseLectures")
                        .HasForeignKey("Id", "LectureId");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseUser", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.CourseAggregate.Course", "Course")
                        .WithMany("CourseUsers")
                        .HasForeignKey("Id", "CourseId");

                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.User", "User")
                        .WithMany("CourseUsers")
                        .HasForeignKey("Id", "UserId");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.Faq", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.User", "User")
                        .WithMany("Faqs")
                        .HasForeignKey("Id", "UserId");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Answer", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("Id", "QuestionId");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Exercise", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Lecture", "Lecture")
                        .WithMany("Exercises")
                        .HasForeignKey("Id", "LectureId");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Question", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Exercise", "Exercise")
                        .WithMany("Questions")
                        .HasForeignKey("Id", "ExerciseId");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.News", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.User", "User")
                        .WithMany("News")
                        .HasForeignKey("Id", "UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
