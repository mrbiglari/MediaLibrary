using System.Collections;
using System.Collections.Generic;

namespace MediaLibrary.Models
{
    public class BookGenreBook
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int BookGenreId { get; set; }
        public BookGenre BookGenre { get; set; }
    }
    public class BookGenre : Genre
    {
        public IEnumerable<BookGenreBook> Books { get; set; }
    }
}
