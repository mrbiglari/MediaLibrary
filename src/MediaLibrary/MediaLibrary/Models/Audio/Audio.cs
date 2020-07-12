using System;

namespace MediaLibrary.Models
{
    public class Audio : Media
    {
        public string Artist { get; set; }
        public AudioGenre Genre { get; set; }
        public DateTime Length { get; set; }
    }
}
