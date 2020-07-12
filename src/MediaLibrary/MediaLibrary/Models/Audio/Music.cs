using System;
using System.ComponentModel.DataAnnotations;

namespace MediaLibrary.Models
{
    public class Music : Media
    {
        public virtual Artist Artist { get; set; }

        public virtual MusicGenre Genre { get; set; }
        public DateTime Length { get; set; }
    }
}
