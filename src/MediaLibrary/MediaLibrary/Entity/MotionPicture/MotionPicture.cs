using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaLibrary.Models
{

    public enum MotionPictureType
    {
        Movie,
        Series
    }

    public class MotionPicture : EntityBase, IMotionPicture
    {
        public string Director { get; set; }
        public DateTime Length { get; set; }
        public virtual MovieGenre Genre { get; set; }

        public MotionPictureType Type { get; set; }
        public virtual IEnumerable<Artist> Cast { get; set; }

        public int EntityId { get; set; }
        public string Title { get; set; }
    }
}
