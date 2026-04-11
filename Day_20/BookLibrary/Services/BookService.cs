using System;
using System.Collections.Generic;
using System.Linq;
using BookLibrary.Models;

namespace BookLibrary.Services
{
    public class BookService : IBookService
    {
        private static List<Book> _books = new List<Book>
        {
            new Book { Id = 1, Title = "Война и мир", Author = "Лев Толстой",
                       ISBN = "9785170909373", Genre = "Роман-эпопея", Year = 1869, DateAdded = DateTime.Now },
            new Book { Id = 2, Title = "Преступление и наказание", Author = "Фёдор Достоевский",
                       ISBN = "9785171180804", Genre = "Роман", Year = 1866, DateAdded = DateTime.Now },
            new Book { Id = 3, Title = "Мастер и Маргарита", Author = "Михаил Булгаков",
                       ISBN = "9785170922877", Genre = "Мистический роман", Year = 1967, DateAdded = DateTime.Now }
        };

        public List<Book> GetAllBooks()
        {
            return _books;
        }

        public Book GetBookById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public void AddBook(Book book)
        {
            book.Id = _books.Count + 1;
            book.DateAdded = DateTime.Now;
            _books.Add(book);
        }
    }
}