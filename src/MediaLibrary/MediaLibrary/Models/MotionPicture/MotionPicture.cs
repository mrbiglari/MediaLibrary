using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MediaLibrary.Models
{
    public class MotionPicture : Media
    {
        public string Director { get; set; }
        public IEnumerable<string> Cast { get; set; }
        public DateTime Length { get; set; }
        [Required]
        public MovieGenre Genre { get; set; }
    }
}
