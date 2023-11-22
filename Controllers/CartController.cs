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
			var session = new BookSession(HttpContext.Session);
			var cart = session.GetMyBooks();

			var model = new BookListViewModel
			{
				Books = cart
			};

			return View(model);
		}

        [HttpPost]
        public IActionResult Add(BookViewModel model)
        {
            var session = new BookSession(HttpContext.Session);
            var cookies = new BookCookies(Response.Cookies);

            var books = session.GetMyBooks();
            books.Add(model.Book);
            session.SetMyBooks(books);
            cookies.SetMyBookIds(books);

            var cartUrl = Url.Action("Index", "Cart");
            TempData["Message"] = $"{model.Book.Title} has been added. <a href='{cartUrl}'>View Cart</a>.";

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
