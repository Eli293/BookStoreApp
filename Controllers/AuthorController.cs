using BookStoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookStoreApp.Controllers
{
	public class AuthorController : Controller
    {
		private BookstoreContext context { get; set; }
		public AuthorController(BookstoreContext ctx) => context = ctx;
		public IActionResult Index(int page = 1, int pageSize = 5, string searchName = "")
		{
			int skip = (page - 1) * pageSize;

			var authorQuery = context.Authors.OrderBy(m => m.AuthorId);

			//search filter by name

			if (!string.IsNullOrEmpty(searchName))
			{
				authorQuery = (IOrderedQueryable<Author>)authorQuery.Where(m => m.FirstName.Contains(searchName) || m.LastName.Contains(searchName));
			}

			var authorCount = authorQuery.Count();

			var authors = authorQuery.Skip(skip).Take(pageSize).ToList();

			var pagedList = new PagedList<Author>
			{
				Items = authors,
				PageNumber = page,
				PageSize = pageSize,
				TotalCount = authorCount
			};
			var viewModel = new AuthorViewModel
			{
				AuthorPageResult = pagedList
			};
			return View(viewModel);
        }

		[HttpGet]
		public IActionResult Edit(int authorId)
		{
			Author author = context.Authors.Where(b => b.AuthorId == authorId).FirstOrDefault() ?? new Author();

			return View(author);
		}

		[HttpPost]
		public IActionResult Edit(Author author)
		{

			context.Authors.Update(author);
			context.SaveChanges();
			return RedirectToAction("Index", "Author");

		}

		[HttpGet]
		public IActionResult Delete(int authorId)
		{
			Author author = context.Authors.Where(b => b.AuthorId == authorId).FirstOrDefault() ?? new Author();

			return View(author);
		}

		[HttpPost]
		public IActionResult DeleteConfirmed(Author author)
		{


            var authorBooks = context.Books.Where(m => m.authorObject.AuthorId == author.AuthorId).ToList();


            context.Books.RemoveRange(authorBooks);
				context.Authors.Remove(author);

			context.SaveChanges();
			return RedirectToAction("Index", "Author");
		}

		public IActionResult Details(int authorId)
		{
			
			Author author = context.Authors.Where(b => b.AuthorId == authorId).FirstOrDefault() ?? new Author();
			var authorBooks = context.Books.Where(b => b.authorObject.AuthorId == authorId).ToList();

            ViewData["Author"] = author;
            // passing author all associated books
            ViewData["AuthorBooks"] = authorBooks;
      
            return View(author);
		}

       
    }
}
