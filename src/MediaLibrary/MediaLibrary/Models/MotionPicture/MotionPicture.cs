using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MediaLibrary.Models
{
    public class MotionPicture : Media
    {
        public string Director { get; set; }        
        public DateTime Length { get; set; }
        public virtual MovieGenre Genre { get; set; }

        public virtual IEnumerable<Artist> Cast { get; set; }
    }
}
