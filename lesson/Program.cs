namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            BookAuthor author = new BookAuthor(10, "Giacomo", "Leopardi", DateOnly.Parse("2025-11-11"));
            BookAuthor anonymous = new BookAuthor(999);

            Book book = new Book(1, "esempio", 1990);
            Book book2 = new Book(2, "esempio 2", anonymous, 1991);
            Book book3 = new Book(3, "esempio 3", author, 1992);

            //Console.WriteLine(book.Author.ID);
            //Console.WriteLine(book2.Author.ID);
            //Console.WriteLine(book3.Author.ID);

            Book[] books = { book3, book, book2 };

            Array.Sort(books);

            foreach (Book currentBook in books)
            {
                Console.WriteLine(currentBook.ID);
            }

        }

        private static void ordinamento(IComparable[] books)
        {
            for (int i = 0; i < books.Length - 1; i++)
            {
                for (int j = 1; j < books.Length; j++)
                {
                    if (
                        books[i].CompareTo(books[j]) > 0
                    )
                    {
                        IComparable temp = books[i];
                        books[i] = books[j];
                        books[j] = temp;
                    }
                }
            }
        }
    }
}