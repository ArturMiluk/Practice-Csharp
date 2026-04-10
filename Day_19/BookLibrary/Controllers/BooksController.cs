using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BookLibrary.Models;

namespace BookLibrary.Controllers
{
    public class BooksController : Controller
    {
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "Война и мир", Author = "Лев Толстой", Year = 1869, DateAdded = DateTime.Now },
            new Book { Id = 2, Title = "Преступление и наказание", Author = "Фёдор Достоевский", Year = 1866, DateAdded = DateTime.Now },
            new Book { Id = 3, Title = "Мастер и Маргарита", Author = "Михаил Булгаков", Year = 1967, DateAdded = DateTime.Now }
        };

        public IActionResult Index()
        {
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();
            return View(book);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                book.Id = books.Count + 1;
                book.DateAdded = DateTime.Now;
                books.Add(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }
    }
}