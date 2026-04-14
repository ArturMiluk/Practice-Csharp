using System.Collections.Generic;
using BookLibrary.Models;

namespace BookLibrary.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
    }
}