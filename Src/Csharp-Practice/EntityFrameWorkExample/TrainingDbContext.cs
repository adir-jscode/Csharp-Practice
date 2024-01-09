using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExample
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connection;
        public TrainingDbContext()
        {
            _connection = "Server=ADIR\\SQLEXPRESS;Database=Csharpb-15;User Id=sarafat;Password=1111; Trust Server Certificate=True";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
                optionsBuilder.UseSqlServer(_connection);

            base.OnConfiguring(optionsBuilder);
        }


        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseStudent>().
                HasKey(x => new {x.CourseId,x.StudentId});

            modelBuilder.Entity<CourseStudent>().ToTable("CourseStudents");

            modelBuilder.Entity<Topic>().ToTable("Topics");

            //Fluent API

            modelBuilder.Entity<Course>()
                .HasMany(x => x.Topic)
                .WithOne(y => y.Course)
                .HasForeignKey(z => z.CourseId);

            modelBuilder.Entity<CourseStudent>()
                .HasOne(x => x.Student)
                .WithMany(y => y.Courses)
                .HasForeignKey(z => z.StudentId);

            modelBuilder.Entity<CourseStudent>()
                .HasOne(x => x.Course)
                .WithMany(y => y.Students)
                .HasForeignKey(z => z.CourseId);

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }



    }
}
