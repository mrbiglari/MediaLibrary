using System;
using System.ComponentModel.DataAnnotations;

namespace MediaLibrary.Models
{
    public class Music : Media
    {
        [Required]
        public string Artist { get; set; }
        [Required]
        public MusicGenre Genre { get; set; }
        public DateTime Length { get; set; }
    }
}
