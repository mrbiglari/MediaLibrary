using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaLibrary.Models
{
    [Table(nameof(Book))]
    public class Book : IMedia
    {
        public virtual Artist Author { get; set; }

        public int PageCount { get; set; }
        public int ChapterCount { get; set; }
        public virtual BookGenre Genre { get; set; }
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }
    }
}
