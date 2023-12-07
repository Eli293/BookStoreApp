using BookStoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace BookStoreApp.Controllers
{

	//Hopefully, we will get 100 for this final project
    public class BookController : Controller
    {

        private BookstoreContext context { get; set; }
        public BookController(BookstoreContext ctx) =>  context = ctx;
        public IActionResult Index(int page = 1, int pageSize = 5, int selectedGenreId = 0)
        {
			int skip = (page - 1) * pageSize;
			var genres = context.Genres.ToList();

			// Search the books based on the selected genre.
			var booksQuery = context.Books.Include(m => m.Genre).Include(m => m.authorObject).OrderBy(m => m.Title);
			if (selectedGenreId != 0)
			{
				booksQuery = (IOrderedQueryable<Book>)booksQuery.Where(b => b.GenreId == selectedGenreId);
			}
			var totalCount = booksQuery.Count();
			var books = booksQuery.Skip(skip).Take(pageSize).ToList();

			var pagedList = new PagedList<Book>
			{
				Items = books,
				PageNumber = page,
				PageSize = pageSize,
				TotalCount = totalCount
			};

			var viewModel = new BookViewModel
			{
				PageResult = pagedList,
				Genres = new SelectList(genres, "GenreId", "Name"),
				SelectedGenreId = selectedGenreId
			};

			return View(viewModel);
        }

		public IActionResult BookDetails(int bookId)
        {
            Book book = context.Books.Where(b => b.BookId == bookId)
				.Include(a => a.authorObject)
				.Include(g => g.Genre)
				.FirstOrDefault() ?? new Book();
            return View(book);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Edit(int bookId)
        {
            Book book = context.Books.Where(b => b.BookId == bookId)
                .Include(a => a.authorObject)
                .Include(g => g.Genre)
                .FirstOrDefault() ?? new Book();

            return View(book);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Edit(Book book)
        {

            context.Books.Update(book);
            context.SaveChanges();
            return RedirectToAction("Index", "Book");

        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Delete(int bookId)
        {
            Book book = context.Books.Where(b => b.BookId == bookId)
                .Include(a => a.authorObject)
                .Include(g => g.Genre)
                .FirstOrDefault() ?? new Book();

            return View(book);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult DeleteConfirmed(Book book)
        {
            context.Books.Remove(book);
            context.SaveChanges();
            return RedirectToAction("Index", "Book");
        }

        public ViewResult AccessDenied()
        {
            return View();
        }

    }
}
