using System.ComponentModel.DataAnnotations;

namespace MediaLibrary.Models
{
    public class Book : Media
    {
        [Required]
        public string Author { get; set; }
        public int PageCount { get; set; }
        public int ChapterCount { get; set; }
        [Required]
        public BookGenre Genre { get; set; }
    }
}
