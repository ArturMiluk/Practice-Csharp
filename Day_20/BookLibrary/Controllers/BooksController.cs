using Microsoft.AspNetCore.Mvc;
using BookLibrary.Models;
using BookLibrary.Services;

namespace BookLibrary.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            var books = _bookService.GetAllBooks();
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null)
                return NotFound();
            return View(book);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(BookViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var book = new Book
                {
                    Title = viewModel.Title,
                    Author = viewModel.Author,
                    ISBN = viewModel.ISBN,
                    Genre = viewModel.Genre,
                    Year = DateTime.Now.Year
                };

                _bookService.AddBook(book);

                TempData["SuccessMessage"] = $"Книга \"{book.Title}\" успешно добавлена в библиотеку!";

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }
    }
}