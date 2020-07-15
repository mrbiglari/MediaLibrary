using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaLibrary.Models
{
    [Table(nameof(Series))]
    public class Series : IMotionPicture
    {
        public int SeasonCount { get; set; }
        public IEnumerable<Artist> Cast { get; set; }
        public string Director { get; set; }
        public MovieGenre Genre { get; set; }
        public DateTime Length { get; set; }
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Title { get; set; }
    }
}
