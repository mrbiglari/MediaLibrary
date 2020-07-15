using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaLibrary.Models
{
    [Table(nameof(Music))]
    public class Music : IMedia
    {
        public virtual Artist Artist { get; set; }
        public virtual MusicGenre Genre { get; set; }
        public DateTime Length { get; set; }
        public DateTime CreatedDate { get; set; }
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
