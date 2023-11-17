using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Models
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<Author> Authors { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(
          new Genre { GenreId = 1, Name = "Novel" },
          new Genre { GenreId = 2, Name = "SciFi" },
          new Genre { GenreId = 3, Name = "Drama" },
          new Genre { GenreId = 4, Name = "Horror" },
          new Genre { GenreId = 5, Name = "Mystery" },
          new Genre { GenreId = 6, Name = "History" },
          new Genre { GenreId = 7, Name = "Fantasy" }

      );

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "Carrie",
                    ISBN = "978-0-385-08695-0",
                    GenreId = 4,
                    AuthorId = 1,
                    Price = 14.94
                },
                new Book
                {
                    BookId = 2,
                    Title = "Christine",
                    ISBN = "978-0-670-22026-7",
                    GenreId = 1,
                    AuthorId = 1,
                    Price = 17.99
                },

                new Book
                {
                    BookId = 3,
                    Title = "The Dark Tower: The Gunslinger",
                    ISBN = "978-0-937986-50-9",
                    GenreId = 1,
                    AuthorId = 1,
                    Price = 11.62
                },
                new Book
                {
                    BookId = 4,
                    Title = "It",
                    ISBN = "978-0-670-81302-5",
                    GenreId = 4,
                    AuthorId = 1,
                    Price = 15.24
                },
                new Book
                {
                    BookId = 5,
                    Title = "Misery",
                    ISBN = "978-0-670-81364-3",
                    GenreId = 1,
                    AuthorId = 1,
                    Price = 13.69
                },
                new Book
                {
                    BookId = 6,
                    Title = "The Murder of Roger Ackroyd",
                    ISBN = "978-0-06-207356-3",
                    GenreId = 5,
                    AuthorId = 2,
                    Price = 14.99
                },
                new Book
                {
                    BookId = 7,
                    Title = "Peril at End House",
                    ISBN = "978-0-06-207402-7",
                    GenreId = 5,
                    AuthorId = 2,
                    Price = 19.99
                },
                new Book
                {
                    BookId = 8,
                    Title = "Murder on the Orient Express",
                    ISBN = "978-0-06-207350-1",
                    GenreId = 5,
                    AuthorId = 2,
                    Price = 11.99
                },
                new Book
                {
                    BookId = 9,
                    Title = "And Then There Were None",
                    ISBN = "978-0-06-207348-8",
                    GenreId = 5,
                    AuthorId = 2,
                    Price = 12.99
                },
                new Book
                {
                    BookId = 10,
                    Title = "The ABC Murders",
                    ISBN = "978-0-06-207358-7",
                    GenreId = 5,
                    AuthorId = 2,
                    Price = 20.87
                },
                new Book
                {
                    BookId = 11,
                    Title = "Safe Harbour",
                    ISBN = "978-0-440-23762-4",
                    GenreId = 1,
                    AuthorId = 3,
                    Price = 12.99
                },
                new Book
                {
                    BookId = 12,
                    Title = "The Gift",
                    ISBN = "978-0-552-14245-8",
                    GenreId = 1,
                    AuthorId = 3,
                    Price = 25.74
                },
                new Book
                {
                    BookId = 13,
                    Title = "All That Glitters",
                    ISBN = "978-0-593-33916-9",
                    GenreId = 3,
                    AuthorId = 3,
                    Price = 27.80
                },
                new Book
                {
                    BookId = 14,
                    Title = "Finding Ashley",
                    ISBN = "978-1-9848-2146-1",
                    GenreId = 1,
                    AuthorId = 3,
                    Price = 24.73
                },
                new Book
                {
                    BookId = 15,
                    Title = "His Bright Light",
                    ISBN = "978-0-385-33467-9",
                    GenreId = 3,
                    AuthorId = 3,
                    Price = 24.01
                },









                new Book
                {
                    BookId = 16,
                    Title = "To Kill a Mockingbird",
                    ISBN = "978-0-446-31078-9",
                    GenreId = 1,
                    AuthorId = 7,
                    Price = 10.99
                },
                new Book
                {
                    BookId = 17,
                    Title = "Romeo and Juliet",
                    ISBN = "978-1-77426-642-7",
                    GenreId = 3,
                    AuthorId = 17,
                    Price = 16.99
                },
                new Book
                {
                    BookId = 18,
                    Title = "The Shining",
                    ISBN = "978-0-307-74365-7",
                    GenreId = 4,
                    AuthorId = 1,
                    Price = 35.78
                },
                new Book
                {
                    BookId = 19,
                    Title = "A People's History of the United States",
                    ISBN = "978-0-06-239734-8",
                    GenreId = 6,
                    AuthorId = 8,
                    Price = 24.09
                },
                new Book
                {
                    BookId = 20,
                    Title = "Dune",
                    ISBN = "978-0-441-17271-9",
                    GenreId = 2,
                    AuthorId = 9,
                    Price = 19.99
                },
                new Book
                {
                    BookId = 21,
                    Title = "Pride and Prejudice",
                    ISBN = "978-1-4209-5871-3",
                    GenreId = 1,
                    AuthorId = 11,
                    Price = 12.99
                },
                new Book
                {
                    BookId = 22,
                    Title = "Hamlet",
                    ISBN = "979-84-9779-677-3",
                    GenreId = 3,
                    AuthorId = 17,
                    Price = 50.89
                },
                new Book
                {
                    BookId = 23,
                    Title = "The Exorcist",
                    ISBN = "978-0-06-209436-0",
                    GenreId = 4,
                    AuthorId = 16,
                    Price = 14.99
                },
                new Book
                {
                    BookId = 24,
                    Title = "Sapiens: A Brief History of Humankind",
                    ISBN = "978-0-09-959008-8",
                    GenreId = 6,
                    AuthorId = 15,
                    Price = 15.99
                },
                new Book
                {
                    BookId = 25,
                    Title = "Neuromancer",
                    ISBN = "978-0-441-00746-2",
                    GenreId = 2,
                    AuthorId = 12,
                    Price = 21.25
                },
                new Book
                {
                    BookId = 26,
                    Title = "The Great Gatsby",
                    ISBN = "978-0-7432-7356-5",
                    GenreId = 1,
                    AuthorId = 10,
                    Price = 60.99
                },
                new Book
                {
                    BookId = 27,
                    Title = "Macbeth",
                    ISBN = "979-86-510-2746-0",
                    GenreId = 3,
                    AuthorId = 17,
                    Price = 28.99
                },
                new Book
                {
                    BookId = 28,
                    Title = "1776",
                    ISBN = "978-0-7432-2672-1",
                    GenreId = 3,
                    AuthorId = 4,
                    Price = 16.50
                },
                new Book
                {
                    BookId = 29,
                    Title = "The Wright Brothers",
                    ISBN = "978-1-4767-2875-9",
                    GenreId = 6,
                    AuthorId = 4,
                    Price = 32.99
                },
                new Book
                {
                    BookId = 30,
                    Title = "Foundation",
                    ISBN = "978-0-553-29335-7",
                    GenreId = 2,
                    AuthorId = 6,
                    Price = 13.99
                },

                new Book
                {
                    BookId = 31,
                    Title = "The Lord of the Rings",
                    ISBN = "978-0-00-847128-6",
                    GenreId = 7,
                    AuthorId = 5,
                    Price = 14.99
                },

                 new Book
                 {
                     BookId = 32,
                     Title = "The Silmarillion",
                     ISBN = "978-0-261-10273-6",
                     GenreId = 7,
                     AuthorId = 5,
                     Price = 17.99
                 },


                 new Book
                 {
                     BookId = 33,
                     Title = "Love in the Night",
                     ISBN = "978-0-09-178183-5",
                     GenreId = 1,
                     AuthorId = 10,
                     Price = 18.99
                 },
                 new Book
                 {
                     BookId = 34,
                     Title = "The Catcher in the Rye",
                     ISBN = "978-0-316-76948-8",
                     GenreId = 1,
                     AuthorId = 13,
                     Price = 13.67
                 },
                 new Book
                 {
                     BookId = 35,
                     Title = "Old Man and the Sea",
                     ISBN = "978-0-684-80122-3",
                     GenreId = 1,
                     AuthorId = 14,
                     Price = 17.99
                 }

            );

            modelBuilder.Entity<Author>().HasData(
               new Author
               {
                   AuthorId = 1,
                   FirstName = "Stephen",
                   LastName = "King"
               },
                new Author
                {
                    AuthorId = 2,
                    FirstName = "Agatha",
                    LastName = "Christie"
                },

                new Author
                {
                    AuthorId = 3,
                    FirstName = "Danielle",
                    LastName = "Steel"
                },




                new Author
                {
                    AuthorId = 4,
                    FirstName = "David",
                    LastName = "McCullough"
                },
                new Author
                {
                    AuthorId = 5,
                    FirstName = "J.R.R.",
                    LastName = "Tolkien"
                },
                new Author
                {
                    AuthorId = 6,
                    FirstName = "Isaac",
                    LastName = "Asimov"
                },
                new Author
                {
                    AuthorId = 7,
                    FirstName = "Harper",
                    LastName = "Lee"
                },
                new Author
                {
                    AuthorId = 8,
                    FirstName = "Haword",
                    LastName = "Zinn"
                },
                new Author
                {
                    AuthorId = 9,
                    FirstName = "Frank",
                    LastName = "Herbert"
                },
                new Author
                {
                    AuthorId = 10,
                    FirstName = "F. Scott",
                    LastName = "Fitzgerald"
                },
                new Author
                {
                    AuthorId = 11,
                    FirstName = "Jane",
                    LastName = "Austen"
                },
                new Author
                {
                    AuthorId = 12,
                    FirstName = "William",
                    LastName = "Gibson"
                },
                new Author
                {
                    AuthorId = 13,
                    FirstName = "J.D.",
                    LastName = "Salinger"
                },
                new Author
                {
                    AuthorId = 14,
                    FirstName = "Ernest",
                    LastName = "Hemingway"
                },
                new Author
                {
                    AuthorId = 15,
                    FirstName = "Yuval",
                    LastName = "Harari"
                },
                new Author
                {
                    AuthorId = 16,
                    FirstName = "William",
                    LastName = "Blatty"
                },
                new Author
                {
                    AuthorId = 17,
                    FirstName = "William",
                    LastName = "Shakespeare"
                }
            );
        }
    }
}
