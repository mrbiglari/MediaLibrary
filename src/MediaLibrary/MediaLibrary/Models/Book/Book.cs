using System.ComponentModel.DataAnnotations;

namespace MediaLibrary.Models
{
    public class Book : Media
    {
        public virtual Artist Author { get; set; }

        public int PageCount { get; set; }
        public int ChapterCount { get; set; }
        public virtual BookGenre Genre { get; set; }
    }
}
