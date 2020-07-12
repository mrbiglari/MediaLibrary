namespace MediaLibrary.Models
{
    public class Book : Media
    {
        public string Author { get; set; }
        public int PageCount { get; set; }
        public int ChapterCount { get; set; }
        public BookGenre Genre { get; set; }
    }
}
