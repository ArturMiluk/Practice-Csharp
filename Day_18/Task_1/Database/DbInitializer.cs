using System;
using System.Linq;

namespace StudentDiary.Database
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }

            var students = new Student[]
            {
                new Student { Name = "Майоров Роман" },
                new Student { Name = "Милюк Артур" },
                new Student { Name = "Петров Егор" }
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var grades = new Grade[]
            {
                new Grade { Subject = "КПиЯП", Value = 10, Date = DateTime.Today, Comment = "Хорошо", StudentId = 1 },
                new Grade { Subject = "ТПО", Value = 10, Date = DateTime.Today, Comment = "Отлично", StudentId = 1 },
                new Grade { Subject = "КПиЯП", Value = 4, Date = DateTime.Today, Comment = "Отлично", StudentId = 2 },
                new Grade { Subject = "ТПО", Value = 5, Date = DateTime.Today, Comment = "Хорошо", StudentId = 2 }
            };

            context.Grades.AddRange(grades);
            context.SaveChanges();
        }
    }
}