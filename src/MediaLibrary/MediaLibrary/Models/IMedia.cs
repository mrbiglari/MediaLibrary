using System;

namespace MediaLibrary.Models
{
    public interface IMedia
    {
        int Id { get; set; }
        DateTime CreatedDate { get; set; }        
        string Title { get; set; }
    }
}