namespace BookStoreApp.Models
{
	public class BookListViewModel: BookViewModel
	{
		public List<Book> Books { get; set; } = new List<Book>();
	}
}
