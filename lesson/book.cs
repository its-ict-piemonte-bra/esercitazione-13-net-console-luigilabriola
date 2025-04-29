namespace lesson
{
    /// <summary>
    /// Represents a book in the system.
    /// </summary>
    class Book : ICloneable, IComparable
    {
        /// <summary>
        /// The ID of the book.
        /// </summary>
        public readonly int ID;

        /// <summary>
        /// The title of the book.
        /// </summary>
        public readonly string Title;

        /// <summary>
        /// The author of the book.
        /// </summary>
        public readonly BookAuthor Author;

        /// <summary>
        /// The book publication year.
        /// </summary>
        public readonly int PublicationYear;

        /// <summary>
        /// Creates a new instance of a valid Book.
        /// </summary>
        /// <param name="ID">The ID of the book</param>
        /// <param name="Title">The title of the book</param>
        /// <param name="author">The author of the book</param>
        /// <param name="publicationYear">The book publication year</param>
        /// <exception cref="ArgumentException">If any param is invalid</exception>
        public Book(int ID, string title, BookAuthor author, int publicationYear)
        {
            if (ID <= 0)
            {
                throw new ArgumentException("ID is invalid");
            }
            else if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title is invalid");
            }
            else if (author == null)
            {
                throw new ArgumentException("author is invalid");
            }
            else if (publicationYear < -3500)
            {
                throw new ArgumentException("publication year is invalid");
            }

            this.ID = ID;
            this.Title = title;
            this.Author = author;
            this.PublicationYear = publicationYear;
        }

        public Book(int ID, string Title, int PublicationYear)
            : this(ID, Title, new BookAuthor(900), PublicationYear)
        { }

        /// <summary>
        /// Returns if 2 objects are equal
        /// </summary>
        /// <param name="obj">The second object to check for equality</param>
        /// <returns>True if the 2 objects are equal, false otherwise</returns>
        public override bool Equals(object? obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the string representation of a book.
        /// </summary>
        /// <returns>The string representation of a book</returns>
        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public string ToString(bool details)
        {
            string result = this.ToString();
            if (details)
            {
                result += "altri dettagli";
            }

            return result;
        }

        public object Clone()
        {
            return new Book(
                this.ID,
                this.Title,
                this.Author,
                this.PublicationYear
            );
        }

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                throw new ArgumentException("obj cannot be null");
            }
            else if (!(obj is Book))
            {
                throw new InvalidCastException("Cannot convert obj to Book");
            }

            Book book = (Book)obj!;

            if (this.PublicationYear < book.PublicationYear)
            {
                return -1;
            }
            else if (this.PublicationYear == book.PublicationYear)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}