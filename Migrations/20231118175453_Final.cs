using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0-670-81302-8");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "000000014");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000006");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000007");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000008");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000009");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000010");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000011");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000012");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000013");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000015");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000016");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000017");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000018");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000019");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000020");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000095");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "00000097");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "000092");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "000096");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0062073488");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0062073501");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0062073563");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0062073587");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0062074027");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0385334679");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0552142458");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0593339169");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-1459745186");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-1984821461");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jane", "Austen" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 12,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "William", "Gibson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "J.D.", "Salinger" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 14,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ernest", "Hemingway" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Yuval", "Harari" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "William", "Blatty" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "William", "Shakespeare" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 4, "David", "McCullough" },
                    { 5, "J.R.R.", "Tolkien" },
                    { 6, "Isaac", "Asimov" },
                    { 7, "Harper", "Lee" },
                    { 8, "Haword", "Zinn" },
                    { 9, "Frank", "Herbert" },
                    { 10, "F. Scott", "Fitzgerald" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ISBN", "AuthorId", "BookId", "GenreId", "Price", "Title" },
                values: new object[,]
                {
                    { "978-0-06-207348-8", 2, 9, 5, 12.99, "And Then There Were None" },
                    { "978-0-06-207350-1", 2, 8, 5, 11.99, "Murder on the Orient Express" },
                    { "978-0-06-207356-3", 2, 6, 5, 14.99, "The Murder of Roger Ackroyd" },
                    { "978-0-06-207358-7", 2, 10, 5, 20.870000000000001, "The ABC Murders" },
                    { "978-0-06-207402-7", 2, 7, 5, 19.989999999999998, "Peril at End House" },
                    { "978-0-06-209436-0", 16, 23, 4, 14.99, "The Exorcist" },
                    { "978-0-09-959008-8", 15, 24, 6, 15.99, "Sapiens: A Brief History of Humankind" },
                    { "978-0-307-74365-7", 1, 18, 4, 35.780000000000001, "The Shining" },
                    { "978-0-316-76948-8", 13, 34, 1, 13.67, "The Catcher in the Rye" },
                    { "978-0-385-33467-9", 3, 15, 3, 24.010000000000002, "His Bright Light" },
                    { "978-0-440-23762-4", 3, 11, 1, 12.99, "Safe Harbour" },
                    { "978-0-441-00746-2", 12, 25, 2, 21.25, "Neuromancer" },
                    { "978-0-552-14245-8", 3, 12, 1, 25.739999999999998, "The Gift" },
                    { "978-0-593-33916-9", 3, 13, 3, 27.800000000000001, "All That Glitters" },
                    { "978-0-670-81302-5", 1, 4, 4, 15.24, "It" },
                    { "978-0-684-80122-3", 14, 35, 1, 17.989999999999998, "Old Man and the Sea" },
                    { "978-1-4209-5871-3", 11, 21, 1, 12.99, "Pride and Prejudice" },
                    { "978-1-77426-642-7", 17, 17, 3, 16.989999999999998, "Romeo and Juliet" },
                    { "978-1-9848-2146-1", 3, 14, 1, 24.73, "Finding Ashley" },
                    { "979-84-9779-677-3", 17, 22, 3, 50.890000000000001, "Hamlet" },
                    { "979-86-510-2746-0", 17, 27, 3, 28.989999999999998, "Macbeth" }
                });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6,
                column: "Name",
                value: "History");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ISBN", "AuthorId", "BookId", "GenreId", "Price", "Title" },
                values: new object[,]
                {
                    { "978-0-00-847128-6", 5, 31, 7, 14.99, "The Lord of the Rings" },
                    { "978-0-06-239734-8", 8, 19, 6, 24.09, "A People's History of the United States" },
                    { "978-0-09-178183-5", 10, 33, 1, 18.989999999999998, "Love in the Night" },
                    { "978-0-261-10273-6", 5, 32, 7, 17.989999999999998, "The Silmarillion" },
                    { "978-0-441-17271-9", 9, 20, 2, 19.989999999999998, "Dune" },
                    { "978-0-446-31078-9", 7, 16, 1, 10.99, "To Kill a Mockingbird" },
                    { "978-0-553-29335-7", 6, 30, 2, 13.99, "Foundation" },
                    { "978-0-7432-2672-1", 4, 28, 3, 16.5, "1776" },
                    { "978-0-7432-7356-5", 10, 26, 1, 60.990000000000002, "The Great Gatsby" },
                    { "978-1-4767-2875-9", 4, 29, 6, 32.990000000000002, "The Wright Brothers" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-00-847128-6");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-06-207348-8");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-06-207350-1");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-06-207356-3");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-06-207358-7");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-06-207402-7");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-06-209436-0");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-06-239734-8");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-09-178183-5");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-09-959008-8");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-261-10273-6");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-307-74365-7");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-316-76948-8");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-385-33467-9");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-440-23762-4");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-441-00746-2");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-441-17271-9");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-446-31078-9");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-552-14245-8");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-553-29335-7");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-593-33916-9");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-670-81302-5");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-684-80122-3");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-7432-2672-1");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-0-7432-7356-5");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-1-4209-5871-3");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-1-4767-2875-9");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-1-77426-642-7");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "978-1-9848-2146-1");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "979-84-9779-677-3");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "979-86-510-2746-0");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "David", "McCullough" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 12,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "George", "Orwell" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "J.K.", "Rowling" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 14,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "J.R.R.", "Tolkien" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Augusten", "Burroughs" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Harper", "Lee" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Leo", "Tolstoy" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 18, "Jane", "Austen" },
                    { 19, "F. Scott", "Fitzgerald" },
                    { 20, "Agatha", "Christie" },
                    { 21, "Dan", "Brown" },
                    { 22, "Mark", "Twain" },
                    { 23, "J.D.", "Salinger" },
                    { 24, "Ernest", "Hemingway" },
                    { 25, "Aldous", "Huxley" },
                    { 26, "Herman", "Melville" },
                    { 27, "Stephen", "King" },
                    { 28, "J.R.R.", "Tolkien" },
                    { 29, "Lewis", "Carroll" },
                    { 30, "Andy", "Weir" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ISBN", "AuthorId", "BookId", "GenreId", "Price", "Title" },
                values: new object[,]
                {
                    { "0-670-81302-8", 1, 4, 4, 15.24, "It" },
                    { "00000006", 14, 16, 1, 10.99, "To Kill a Mockingbird" },
                    { "00000007", 15, 17, 3, 16.989999999999998, "Romeo and Juliet" },
                    { "00000008", 16, 18, 4, 35.780000000000001, "The Shining" },
                    { "00000009", 17, 19, 6, 24.09, "A People's History of the United States" },
                    { "00000012", 15, 22, 3, 50.890000000000001, "Hamlet" },
                    { "00000017", 15, 27, 3, 28.0, "Macbeth" },
                    { "00000018", 16, 28, 4, 16.5, "It" },
                    { "00000019", 14, 29, 6, 32.990000000000002, "The Wright Brothers" },
                    { "00000020", 15, 30, 2, 13.99, "Foundation" },
                    { "000092", 14, 32, 7, 14.99, "The Lord of the Rings" },
                    { "000096", 14, 33, 7, 17.989999999999998, "The Silmarillion" },
                    { "978-0062073488", 2, 9, 5, 12.99, "And Then There Were None" },
                    { "978-0062073501", 2, 8, 5, 11.99, "Murder on the Orient Express" },
                    { "978-0062073563", 2, 6, 5, 14.99, "The Murder of Roger Ackroyd" },
                    { "978-0062073587", 2, 10, 5, 20.870000000000001, "The ABC Murders" },
                    { "978-0062074027", 2, 7, 5, 19.989999999999998, "Peril at End House" },
                    { "978-0385334679", 3, 15, 3, 24.010000000000002, "His Bright Light" },
                    { "978-0552142458", 3, 12, 1, 25.739999999999998, "The Gift" },
                    { "978-0593339169", 3, 13, 3, 27.800000000000001, "All That Glitters" },
                    { "978-1459745186", 3, 11, 3, 12.99, "Safe Harbour" },
                    { "978-1984821461", 3, 14, 1, 24.73, "Finding Ashley" }
                });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6,
                column: "Name",
                value: "history");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ISBN", "AuthorId", "BookId", "GenreId", "Price", "Title" },
                values: new object[,]
                {
                    { "000000014", 21, 24, 6, 15.99, "Sapiens: A Brief History of Humankind" },
                    { "00000010", 18, 20, 2, 19.989999999999998, "Dune" },
                    { "00000011", 19, 11, 1, 12.99, "Pride and Prejudice" },
                    { "00000013", 20, 23, 4, 14.99, "The Exorcist" },
                    { "00000015", 22, 25, 2, 21.25, "Neuromancer" },
                    { "00000016", 23, 26, 1, 60.990000000000002, "The Great Gatsby" },
                    { "00000095", 19, 34, 1, 18.989999999999998, "Love in the Night" },
                    { "00000097", 23, 35, 1, 13.67, "The Catcher in the Rye" }
                });
        }
    }
}
