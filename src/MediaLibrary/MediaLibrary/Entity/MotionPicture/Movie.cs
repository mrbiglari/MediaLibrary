using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaLibrary.Models
{
    [Table(nameof(Movie))]
    public class Movie : EntityBase, IMotionPicture
    {
        public IEnumerable<Artist> Cast { get; set; }
        public string Director { get; set; }
        public MovieGenre Genre { get; set; }
        public DateTime Length { get; set; }
        public string Title { get; set; }
    }
}
