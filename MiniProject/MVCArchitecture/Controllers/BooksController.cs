using Microsoft.AspNetCore.Mvc;
using MVCArchitecture.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCArchitecture.Controllers
{
    public class BooksController : Controller
    {
        // A simple static list to act as our data source for this basic example
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", YearPublished = 1960 },
            new Book { Id = 3, Title = "1984", Author = "George Orwell", YearPublished = 1949 }
        };

        // GET: /Books
        public IActionResult Index()
        {
            // Pass the model (list of books) to the view
            return View(books);
        }

        // GET: /Books/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Books/Create
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                // Generate a new ID (for demonstration purposes only with an in-memory list)
                book.Id = books.Count > 0 ? books.Max(b => b.Id) + 1 : 1;
                books.Add(book);
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: /Books/Edit/5
        public IActionResult Edit(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: /Books/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, Book updatedBook)
        {
            if (id != updatedBook.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingBook = books.FirstOrDefault(b => b.Id == id);
                if (existingBook != null)
                {
                    existingBook.Title = updatedBook.Title;
                    existingBook.Author = updatedBook.Author;
                    existingBook.YearPublished = updatedBook.YearPublished;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(updatedBook);
        }

        // GET: /Books/Delete/5
        public IActionResult Delete(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: /Books/Delete/5
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
