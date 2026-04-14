using System.Collections.Generic;
using System.Reflection.Emit;
using BookLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Война и мир",
                    Author = "Лев Толстой",
                    ISBN = "9785170909373",
                    Genre = "Роман-эпопея",
                    Year = 1869,
                    DateAdded = DateTime.Now
                },
                new Book
                {
                    Id = 2,
                    Title = "Преступление и наказание",
                    Author = "Фёдор Достоевский",
                    ISBN = "9785171180804",
                    Genre = "Роман",
                    Year = 1866,
                    DateAdded = DateTime.Now
                },
                new Book
                {
                    Id = 3,
                    Title = "Мастер и Маргарита",
                    Author = "Михаил Булгаков",
                    ISBN = "9785170922877",
                    Genre = "Мистический роман",
                    Year = 1967,
                    DateAdded = DateTime.Now
                }
            );
        }
    }
}