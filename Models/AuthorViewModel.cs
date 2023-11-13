namespace BookStoreApp.Models
{
	public class AuthorViewModel
	{
		public Author author { get; set; }

		public PagedList<Author> AuthorPageResult { get; set; }
	}
}
