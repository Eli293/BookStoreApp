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
		public IActionResult Index(int page = 1, int pageSize = 5)
		{
			int skip = (page - 1) * pageSize;

			var authorQuery = context.Authors.OrderBy(m => m.AuthorId);
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
    }
}
