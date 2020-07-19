using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaLibrary.Models
{
    [Table(nameof(Book))]
    public class Book : EntityBase, IMedia
    {
        public virtual Artist Author { get; set; }

        public int PageCount { get; set; }
        public int ChapterCount { get; set; }
        public virtual BookGenre Genre { get; set; }

        public string Title { get; set; }
    }
}
