namespace BookStoreApp.Models
{
    public class BookSession
    {
        private const string BooksKey = "mybooks";
        private const string CountKey = "bookcount";
        private const string AuthorKey = "author";
        private const string GenreKey = "genre";

        private ISession session { get; set; }
        public BookSession(ISession session) =>
            this.session = session;

        public void SetMyBooks(List<Book> books)
        {
            session.SetObject(BooksKey, books);
            session.SetInt32(CountKey, books.Count);
        }

        public List<Book> GetMyBooks() =>
        session.GetObject<List<Book>>(BooksKey) ??
            new List<Book>();

        public int? GetMyBookCount() =>
        session.GetInt32(CountKey);

        public void RemoveMyBooks()
        {
            session.Remove(BooksKey);
            session.Remove(CountKey);
        }
    }
}
