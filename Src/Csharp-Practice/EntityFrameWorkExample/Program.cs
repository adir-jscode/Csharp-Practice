using Microsoft.EntityFrameworkCore;
using System;

namespace EntityFrameWorkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Student student = new Student();
            //student.Name = "Test";
            //student.DateOfBirth = new DateTime(2000, 5, 4);
            //student.Cgpa = 3.2;

            TrainingDbContext context = new TrainingDbContext();
            //context.Students.Add(student);
            //context.SaveChanges();

            //context.Students.Add(new Student
            //{
            //    Name = "Bijoy",
            //    Cgpa = 4.0,
            //    DateOfBirth = new DateTime(2000, 2, 5)
            //});

            //context.Students.Add(new Student
            //{
            //    Name = "Mahruf",
            //    Cgpa = 3.4,
            //    DateOfBirth = new DateTime(1998, 2, 5)
            //});

            //context.Students.Add(new Student
            //{
            //    Name = "Al Hossain",
            //    Cgpa = 2.7,
            //    DateOfBirth = new DateTime(1999, 2, 5)
            //});

            //context.SaveChanges();

            //Get all Students

            //List<Student> students = context.Students.ToList();

            //using condition => FirstOrDefault
            // List<Student> students = context.Students.Where(x=> x.Cgpa <=3.2).ToList();

            // foreach (var s in students)
            // {
            //     Console.WriteLine($" Name : {s.Name} CGPA : {s.Cgpa}");
            //     //s.Name = "A"; update data
            // }

            // //context.SaveChanges(); After update data

            // //Delete a data
            //Student s1= context.Students.Where(x=>x.Id == 2).FirstOrDefault();
            // if(s1 != null)
            // {
            //     context.Students.Remove(s1);
            //     Console.WriteLine("Deleted Successfully");
            // }
            // context.SaveChanges();




            //var course = new Course()
            //{
            //    Name = "C#",
            //    Duration = 2,
            //    Topic = new List<Topic> 
            //    { 
            //        new Topic{Name = "Variable"},
            //        new Topic{Name = "List"},
            //        new Topic{Name="Generics"}
            //    }

            //};
            //context.Courses.Add(course);
            //context.SaveChanges();  
            //course.Topic.Add(new Topic { Name = "Getting Started" });

            //course.Topic = new List<Topic>();
            //course.Topic.Add(new Topic { Name = "Getting Started" });


            //var course = context.Courses.Where(x => x.Id == 2).Include(x => x.Topic).FirstOrDefault();
            //Console.WriteLine(course.Name);
            //Console.WriteLine("-----------------");
            //if(course.Topic !=null)
            //{
            //    foreach(var topic in course.Topic)
            //    {
            //        Console.WriteLine(topic.Name);
            //    }
            //}

            //Delete

            //var t = course.Topic[1];
            //course.Topic.Remove(t);
            //context.SaveChanges();

            var course = new Course()
            {
                Name = "Asp.net",
                Duration = 4,
                Topic = new List<Topic>
                {
                    new Topic { Name = "Logger" },
                    new Topic { Name = "Dapper" }
                },
                Students = new List<CourseStudent>
                {
                    new CourseStudent {Student= new Student { Name = "Adir", Cgpa = 3.29,DateOfBirth= new DateTime(2002,7,8) } }
                }
            };
            context.Courses.Add(course);
            context.SaveChanges();


            Console.WriteLine("Done");

        }
    }
}
