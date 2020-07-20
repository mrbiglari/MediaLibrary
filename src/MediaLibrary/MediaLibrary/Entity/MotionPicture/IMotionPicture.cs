using System;
using System.Collections.Generic;

namespace MediaLibrary.Models
{
    public interface IMotionPicture : IMedia
    {
        IEnumerable<Artist> Cast { get; set; }
        string Director { get; set; }
        MovieGenre Genre { get; set; }
        DateTime Length { get; set; }
    }
}