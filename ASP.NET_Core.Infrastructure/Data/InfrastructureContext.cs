using Microsoft.EntityFrameworkCore;
using ASP.NET_Core.ApplicationCore.Entities;
using ASP.NET_Core.ApplicationCore.Entities.CourseAggregate;
using ASP.NET_Core.ApplicationCore.Entities.LectureAggregate;
using ASP.NET_Core.Infrastructure.Data.Configurations;
using System.Reflection;

namespace ASP.NET_Core.Infrastructure.Data
{
    public class InfrastructureContext : DbContext
    {
        public const string DEFAULT_SCHEMA = "elc";
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<AnswerUser> AnswerUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CourseLecture> CourseLectures { get; set; }
        public DbSet<CourseUser> CourseUsers { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<User> Users { get; set; }
        public InfrastructureContext(DbContextOptions<InfrastructureContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // modelBuilder.ApplyConfiguration(new AnswerConfiguration());
            // modelBuilder.ApplyConfiguration(new AnswerUserConfiguration());
            // modelBuilder.ApplyConfiguration(new CommentConfiguration());
            // modelBuilder.ApplyConfiguration(new CourseConfiguration());
            // modelBuilder.ApplyConfiguration(new CourseLectureConfiguration());
            // modelBuilder.ApplyConfiguration(new CourseUserConfiguration());
            // modelBuilder.ApplyConfiguration(new ExerciseConfiguration());
            // modelBuilder.ApplyConfiguration(new FaqConfiguration());
            // modelBuilder.ApplyConfiguration(new LectureConfiguration());
            // modelBuilder.ApplyConfiguration(new NewsConfiguration());
            // modelBuilder.ApplyConfiguration(new QuestionConfiguration());
            // modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            // modelBuilder.ApplyConfiguration(new UserConfiguration());

        }
    }
}
