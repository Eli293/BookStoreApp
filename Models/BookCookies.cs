namespace BookStoreApp.Models
{
    public class BookCookies
    {
        private const string BooksKey = "mybooks";
        private const string Delimiter = "-";

        private IRequestCookieCollection requestCookies { get; set; } =
            null!;

        private IResponseCookies responseCookies { get; set; } = null!;

        public BookCookies(IRequestCookieCollection cookies)
        {
            requestCookies = cookies;
        }

        public BookCookies(IResponseCookies cookies)
        {
            responseCookies = cookies;
        }

        public void SetMyBookIds(List<Book> mybooks)
        {
			List<string> ids = mybooks.Select(b => b.BookId.ToString()).ToList();
			string idsString = String.Join(Delimiter, ids);
			CookieOptions options = new CookieOptions
			{
				Expires = DateTime.Now.AddDays(30)
			};
			RemoveMyBookIds(); // Delete old cookie first
			responseCookies.Append(BooksKey, idsString, options);
		}

        public int[] GetMyBooksIds()
        {
            string cookie = requestCookies[BooksKey] ?? String.Empty;
            if (string.IsNullOrEmpty(cookie))
                return Array.Empty<int>();   
            else
                return cookie.Split(Delimiter).Select(int.Parse).ToArray();
        }

        public void RemoveMyBookIds()
        {
            responseCookies.Delete(BooksKey);
        }
    }
}
