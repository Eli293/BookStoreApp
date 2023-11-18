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
            List<int> ids = mybooks.Select(b => b.BookId).ToList();
            string idsString = String.Join(Delimiter, ids);
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };
            RemoveMyBookIds();     // delete old cookie first
            responseCookies.Append(BooksKey, idsString, options);
        }

        public string[] GetMyBooksIds()
        {
            string cookie = requestCookies[BooksKey] ?? String.Empty;
            if (string.IsNullOrEmpty(cookie))
                return Array.Empty<string>();   // empty string array
            else
                return cookie.Split(Delimiter);
        }

        public void RemoveMyBookIds()
        {
            responseCookies.Delete(BooksKey);
        }
    }
}
