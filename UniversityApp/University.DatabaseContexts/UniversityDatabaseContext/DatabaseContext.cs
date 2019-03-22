using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using University.Models;
using University.Models.EntityModels;

namespace University.DatabaseContexts.UniversityDatabaseContext
{
    public class DatabaseContext:IdentityDbContext<AppUser>
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-L0SIFSL\SQLEXPRESS;Database=UniDB;Trusted_Connection=True;");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<CourseAssignToTeacher> CourseAssignToTeachers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<AllocateClassRoom> AllocateClassRooms { get; set; }
        public DbSet<CourseEnrollToStudent> CourseEnrollToStudents { get; set; }
        public DbSet<GradePoint> GradePoints { get; set; }
        public DbSet<StudentResult> StudentResults { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Department>()
                .Property(c => c.DepartmentCode).IsRequired();
            builder.Entity<Department>()
                .Property(c => c.DepartmentName).IsRequired();

            builder.Entity<Course>()
                .Property(c => c.CourseCode).IsRequired();
            builder.Entity<Course>()
               .Property(c => c.CourseName).IsRequired();
            builder.Entity<Course>()
               .Property(c => c.Credit).IsRequired();

            builder.Entity<CourseAssignToTeacher>()
                .Property(c => c.DepartmentId).IsRequired();
            builder.Entity<CourseAssignToTeacher>()
                .Property(c => c.CourseAssignToTeacherId).IsRequired();
            builder.Entity<CourseAssignToTeacher>()
                .Property(c => c.CourseId).IsRequired();
            builder.Entity<CourseAssignToTeacher>()
               .Property(c => c.IsActive).IsRequired();

            builder.Entity<Teacher>().
                Property(c => c.TeacherName).IsRequired();
            builder.Entity<Teacher>().
               Property(c => c.Address).IsRequired();
            builder.Entity<Teacher>().
               Property(c => c.Email).IsRequired();
            builder.Entity<Teacher>().
               Property(c => c.PhoneNo).IsRequired();
            builder.Entity<Teacher>().
               Property(c => c.DepartmentId).IsRequired();
            builder.Entity<Teacher>().
               Property(c => c.DesignationId).IsRequired();
            builder.Entity<Teacher>().
               Property(c => c.TakenCredit).IsRequired();

            builder.Entity<Student>()
                .Property(c => c.StudentName).IsRequired();
            builder.Entity<Student>()
                .Property(c => c.Email).IsRequired();
            builder.Entity<Student>()
                .Property(c => c.ContactNo).IsRequired();
            builder.Entity<Student>()
                .Property(c => c.Address).IsRequired();
            builder.Entity<Student>()
                .Property(c => c.RegNo).IsRequired();
            builder.Entity<Student>()
                .Property(c => c.DepartmentId).IsRequired();
            builder.Entity<Student>()
                .Property(c => c.Date).IsRequired();

            builder.Entity<Designation>().Property(e => e.DesignationName).IsRequired();

            builder.Entity<StudentResult>().Property(e => e.StudentId).IsRequired();
            builder.Entity<StudentResult>().Property(e => e.CourseId).IsRequired();
            builder.Entity<StudentResult>().Property(e => e.GradePointId).IsRequired();

        }

    }
}
