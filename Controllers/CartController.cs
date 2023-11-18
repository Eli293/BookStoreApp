using Microsoft.AspNetCore.Mvc;
using BookStoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Controllers
{
    public class CartController : Controller
    {
        private BookstoreContext context { get; set; }
        public CartController(BookstoreContext ctx) => context = ctx;

        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }


        [HttpPost]
        public RedirectToActionResult Add(int id)
        {
            Book book = context.Books
                .Include(a => a.authorObject)
                .Include(g => g.Genre)
                .Where(t => t.BookId == id)
                .FirstOrDefault() ?? new Book();

            var session = new BookSession(HttpContext.Session);
            var cookies = new BookCookies(Response.Cookies);
            var books = session.GetMyBooks();

            books.Add(book);
            session.SetMyBooks(books);
            cookies.SetMyBookIds(books);

            // notify user and redirect to home page
            TempData["message"] = $"{book.Title} added to your favorites";
            return RedirectToAction("Index", "Book");
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new BookSession(HttpContext.Session);
            var cookies = new BookCookies(Response.Cookies);

            session.RemoveMyBooks();
            cookies.RemoveMyBookIds();

            // notify user and redirect to home page
            TempData["message"] = "Cart cleared";
            return RedirectToAction("Index", "Book");
        }
    }
}
