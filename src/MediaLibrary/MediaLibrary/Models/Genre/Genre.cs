using System.ComponentModel.DataAnnotations;

namespace MediaLibrary.Models
{
    public class Genre : EntityBase
    {
        [Required]
        public string Name { get; set; }        
    }
}
