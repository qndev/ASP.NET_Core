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

                    b.Property<int>("AnswerId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<int>("LectureId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnswerId");

                    b.HasIndex("UserId");

                    b.ToTable("AnswerUser");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CommentContent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<int>("LectureId")
                        .HasColumnType("int");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseAggregate.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("Description")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue(null);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("ImageFile")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

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

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseAggregate.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseLecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<int>("LectureId")
                        .HasColumnType("int");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("LectureId");

                    b.ToTable("CourseLecture");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("getdate()");

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

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("CourseUser");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.Faq", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("Faqs");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("CorrectFlag")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<sbyte>("OrderNumber")
                        .HasColumnType("tinyint(4)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<int>("LectureId")
                        .HasColumnType("int");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("LectureId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Lecture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("DoccumentUrl")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<sbyte>("Type")
                        .HasColumnType("tinyint(4)");

                    b.HasKey("Id");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("News");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("EmailVerifiedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<byte>("Gender")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint unsigned")
                        .HasDefaultValue((byte)0);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("varchar(25)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("timestamp");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(25)");

                    b.Property<string>("RememberToken")
                        .HasColumnType("varchar(25)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.AnswerUser", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Answer", "Answer")
                        .WithMany("AnswerUsers")
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.User", "User")
                        .WithMany("AnswerUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.Comment", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseAggregate.Course", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.CourseAggregate.Subject", "Subject")
                        .WithMany("Courses")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseAggregate.Subject", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.User", "User")
                        .WithMany("Subjects")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseLecture", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.CourseAggregate.Course", "Course")
                        .WithMany("CourseLectures")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Lecture", "Lecture")
                        .WithMany("CourseLectures")
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.CourseUser", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.CourseAggregate.Course", "Course")
                        .WithMany("CourseUsers")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.User", "User")
                        .WithMany("CourseUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.Faq", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.User", "User")
                        .WithMany("Faqs")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Answer", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Exercise", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Lecture", "Lecture")
                        .WithMany("Exercises")
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Question", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.LectureAggregate.Exercise", "Exercise")
                        .WithMany("Questions")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NET_Core.ApplicationCore.Entities.News", b =>
                {
                    b.HasOne("ASP.NET_Core.ApplicationCore.Entities.User", "User")
                        .WithMany("News")
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
