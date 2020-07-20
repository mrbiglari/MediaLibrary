using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaLibrary.Models
{
    [Table(nameof(Music))]
    public class Music : EntityBase, IMedia
    {
        public virtual Artist Artist { get; set; }
        public virtual MusicGenre Genre { get; set; }
        public DateTime Length { get; set; }
        public string Title { get; set; }
    }
}
